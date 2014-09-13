using System;
using System.Threading;
using System.Windows.Forms;

namespace FBApp
{
    public partial class FormLogin : Form
    {   // $G$ CSS-016 (-5) Bad class name - The name of classes derived from Form should end with Form.
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (FacebookAppLogic.Instance.TryUserLogin())
            {
                this.Hide();
                startApp();
            }
            else
            {
                MessageBox.Show(@"Login Failed");
                buttonLogin.Visible = true;
            }
        }

        private void startApp()
        {
            FacebookAppForm facebookAppForm = new FacebookAppForm();
            facebookAppForm.ShowDialog();
            this.Close();
        }
    }
}
