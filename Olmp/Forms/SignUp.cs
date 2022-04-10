using Olmp.Forms;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace Olmp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            if (tb_email.Text == String.Empty)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Введите email";
            }
            else if (tb_password.Text != tb_passwordr.Text || tb_password.Text == string.Empty)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Пароли не совпадают";

            }
            else if (IsEmail(tb_email.Text) == false)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Неверная почта";
            }
            else
            {
                DB dB = new DB();
                dB.CheckEmail(tb_email.Text, out bool checkEmail);
                string hash = CreateMD5Hash(tb_password.Text);
                if (checkEmail)
                {
                    dB.SigUp(tb_email.Text, hash.ToLower());
                    Account account = new Account();
                    Account.email = tb_email.Text;
                    account.Show();
                    this.Hide();
                }
                else
                    lbl_error.Visible = true;  lbl_error.Text = "Пользователь с таким email уже зарегистрирован";

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
