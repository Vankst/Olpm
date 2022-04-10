using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Olmp.Forms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            
            string password = "";
            string hash = "";
            if (tb_email.Text == String.Empty)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Введите email";
            }
            else if (tb_password.Text == string.Empty)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Введите пароль";

            }
            else if (!IsEmail(tb_email.Text))
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Неверная почта";
            }
            else
            {
                hash = CreateMD5Hash(tb_password.Text);
                DB dB = new DB();
                dB.SignIn(tb_email.Text, out password) ;
            }
            if(hash.ToLower() == password)
            {
                Account account = new Account();
                Account.email = tb_email.Text;
                account.Show();
                this.Hide();
            }
            else
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Неправильный логин или пароль";
            }
        }
        public string CreateMD5Hash(string input)
        {

            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);


            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
        static bool IsEmail(string s)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(s);
                return addr.Address == s;

            }
            catch
            {
                return false;
            }

        }
    }
}
