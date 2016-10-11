using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormExample
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            SetControlState(true);
            /**
             * @desc Do your login thing here, for example we sleep it here for a bit of time
             */
            await Task.Run(() => Thread.Sleep(5 * 1000));
            SetControlState(false);
            // Login success? Open up dashboard
            var form = new DashboardForm();
            form.FormClosing += (a, b) => Close();
            Hide();
            form.Show();
        }

        protected void SetControlState(bool loading)
        {
            LoginButton.Enabled = !loading;
            UsernameTextBox.Enabled = !loading;
            PasswordTextBox.Enabled = !loading;
            RememberMeCheckBox.Enabled = !loading;
            LoginProgressBar.Style = loading ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
        }
    }
}
