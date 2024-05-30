namespace Blockout2024.Utils
{
    internal static class Helper
    {
        internal static void ErrorMsgBox(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void TaskResult(Func<Task> func, bool withDelay = true)
        {
            var task = Task.Run(func);
            Task taskResult;
            if (withDelay)
                taskResult = Task.WhenAny(task, Task.Delay(TimeSpan.FromSeconds(30))).Result;
            else
                taskResult = Task.WhenAny(task).Result;

            if (!taskResult.IsCompletedSuccessfully)
                ErrorMsgBox("Hata", "Instagram sunucusu hatasi. Lutfen sonra tekrar deneyiniz.");
        }

        internal static TResult TaskResult<TResult>(Func<Task<TResult>> func)
        {
            var task = Task.Run(func);
            var taskResult = Task.WhenAny(task, Task.Delay(TimeSpan.FromSeconds(30))).Result;
            if (!taskResult.IsCompletedSuccessfully)
                ErrorMsgBox("Hata", "Instagram sunucusu hatasi. Lutfen sonra tekrar deneyiniz.");

            return task.Result;
        }
    }
}
