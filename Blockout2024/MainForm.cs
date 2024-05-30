using Blockout2024.Business;
using Blockout2024.Models;
using static Blockout2024.Utils.Helper;

namespace Blockout2024
{
    internal partial class MainForm : Form
    {
        private readonly InstagramService _instagramService;

        public MainForm()
        {
            _instagramService = new InstagramService();

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TaskResult(() => _instagramService.LoginWithSessionAsync());
            SetComponents();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (_instagramService.CurrentUser == null)
            {
                using var loginForm = new LoginForm(_instagramService);
                loginForm.ShowDialog();
            }
            else
                TaskResult(() => _instagramService.LogoutAsync());

            SetComponents();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SetComponents();
        }

        private void buttonBlockAccountsFollowedByAnAccount_Click(object sender, EventArgs e)
        {
            if (listBoxFollowing.SelectedItem is not InstagramUser selectedItem)
                return;

            var dialogResult = MessageBox.Show($"{selectedItem.FullName} hesabinin takip ettigi hesaplari engellemek istedigine emin misin?", "Blockout2024", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                TaskResult(() => _instagramService.BlockAccountsFollowingByAnAccountAsync(selectedItem.UserName), false);
        }

        private void SetComponents()
        {
            buttonLogin.Text = "Oturum Aç";
            labelUserName.Text = string.Empty;
            labelFullName.Text = string.Empty;
            labelFollowersCount.Text = string.Empty;
            labelFollowingCount.Text = string.Empty;
            labelDifferenceCount.Text = string.Empty;
            labelBlockedUsersCount.Text = string.Empty;
            listBoxFollowers.Items.Clear();
            listBoxFollowing.Items.Clear();
            listBoxDifference.Items.Clear();

            if (_instagramService.CurrentUser != null)
            {
                var currentUser = _instagramService.CurrentUser;
                var followers = TaskResult(() => _instagramService.GetFollowersAsync())
                    .OrderBy(x => x.UserName)
                    .ToArray();

                var followings = TaskResult(() => _instagramService.GetFollowingAsync())
                    .OrderBy(x => x.UserName)
                    .ToArray();

                var instagramUserComparer = EqualityComparer<InstagramUser>.Create((x, y) => x.UserName == y.UserName, obj => obj.UserName.GetHashCode());
                var differences = followings.Except(followers, instagramUserComparer)
                    .ToArray();

                buttonLogin.Text = "Oturumu Kapat";
                labelUserName.Text = currentUser.UserName;
                labelFullName.Text = currentUser.FullName;
                labelFollowersCount.Text = followers.Length.ToString();
                labelFollowingCount.Text = followings.Length.ToString();
                labelDifferenceCount.Text = differences.Length.ToString();
                labelBlockedUsersCount.Text = TaskResult(() => _instagramService.GetBlockedUserCountAsync()).ToString();
                listBoxFollowers.Items.AddRange(followers);
                listBoxFollowing.Items.AddRange(followings);
                listBoxDifference.Items.AddRange(differences);
            }

            buttonLogin.Refresh();
            labelUserName.Refresh();
            labelFullName.Refresh();
            labelFollowersCount.Refresh();
            labelFollowingCount.Refresh();
            labelDifferenceCount.Refresh();
            listBoxFollowers.Refresh();
            listBoxFollowing.Refresh();
            listBoxDifference.Refresh();
        }
    }
}
