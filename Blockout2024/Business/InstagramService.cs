using Blockout2024.Models;
using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.Models;

namespace Blockout2024.Business
{
    internal class InstagramService
    {
        const string stateFile = "C:\\Temp\\session.json";

        private readonly IInstaApi _instaApi;

        internal InstaCurrentUser CurrentUser { get; set; }

        internal InstagramService()
        {
            var delay = RequestDelay.FromSeconds(0, 1);
            _instaApi = InstaApiBuilder.CreateBuilder()
                .SetRequestDelay(delay)
                .Build();
        }

        internal async Task LoginWithSessionAsync()
        {
            if (File.Exists(stateFile))
            {
                var sessionData = File.ReadAllText(stateFile);
                _instaApi.LoadStateDataFromString(sessionData);

                await SetCurrentUserAsync();
            }
        }

        internal async Task<bool> LoginAsync(string userName, string password)
        {
            if (File.Exists(stateFile))
            {
                var sessionData = File.ReadAllText(stateFile);
                _instaApi.LoadStateDataFromString(sessionData);
            }
            else
            {
                var userSession = new UserSessionData
                {
                    UserName = userName,
                    Password = password
                };
                _instaApi.SetUser(userSession);

                var androidDevice = AndroidDeviceGenerator.GetRandomAndroidDevice();
                androidDevice.DeviceModelIdentifier = "HCK";
                _instaApi.SetDevice(androidDevice);

                var loginRequest = await _instaApi.LoginAsync();
                if (!loginRequest.Succeeded)
                    return false;

                var sessionData = _instaApi.GetStateDataAsString();
                File.WriteAllText(stateFile, sessionData);
            }

            await SetCurrentUserAsync();

            if (CurrentUser == null)
            {
                if (File.Exists(stateFile))
                    File.Delete(stateFile);
                return false;
            }

            return true;
        }

        internal async Task LogoutAsync()
        {
            await _instaApi.LogoutAsync();

            CurrentUser = null;

            if (File.Exists(stateFile))
                File.Delete(stateFile);
        }

        internal async Task<IList<InstagramUser>> GetFollowersAsync()
        {
            var result = await _instaApi.UserProcessor.GetUserFollowersAsync(CurrentUser.UserName, PaginationParameters.MaxPagesToLoad(1));
            if (!result.Succeeded)
                return [];

            var followers = result.Value.
                Select(x => new InstagramUser
                {
                    UserName = x.UserName,
                    FullName = x.FullName,
                })
                .ToList();

            return followers;
        }

        internal async Task<IList<InstagramUser>> GetFollowingAsync()
        {
            var result = await _instaApi.UserProcessor.GetUserFollowingAsync(CurrentUser.UserName, PaginationParameters.MaxPagesToLoad(1));
            if (!result.Succeeded)
                return [];

            var following = result.Value.
                Select(x => new InstagramUser
                {
                    UserName = x.UserName,
                    FullName = x.FullName,
                })
                .ToList();

            return following;
        }

        internal async Task<int> GetBlockedUserCountAsync()
        {
            var result = await _instaApi.UserProcessor.GetBlockedUsersAsync(PaginationParameters.MaxPagesToLoad(1));
            if (!result.Succeeded)
                return 0;

            var x = result.Value.MaxId;

            return result.Value.BlockedList.Count;
        }

        internal async Task BlockAccountsFollowingByAnAccountAsync(string userName)
        {
            var result = await _instaApi.UserProcessor.GetUserFollowingAsync(userName, PaginationParameters.MaxPagesToLoad(1));
            if (!result.Succeeded)
                return;

            var x = result.Value.NextMaxId;

            var following = result.Value;
            foreach (var item in following)
            {
                _ = await _instaApi.UserProcessor.BlockUserAsync(item.Pk);
            }
        }

        private async Task SetCurrentUserAsync()
        {
            var resultInstaCurrentUser = await _instaApi.GetCurrentUserAsync();
            CurrentUser = resultInstaCurrentUser?.Value;
        }
    }
}
