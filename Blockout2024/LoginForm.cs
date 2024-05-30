using Blockout2024.Business;
using static Blockout2024.Utils.Helper;

namespace Blockout2024
{
    internal partial class LoginForm : Form
    {
        private readonly InstagramService _instagramService;

        public LoginForm(InstagramService instagramService)
        {
            _instagramService = instagramService;
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (_instagramService.CurrentUser != null)
                Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            var result = TaskResult(() => _instagramService.LoginAsync(username, password));
            if (result)
                Close();
            else
                ErrorMsgBox("Hata", "Kullanıcı adı veya Parola yanlış!");
        }
    }
}
