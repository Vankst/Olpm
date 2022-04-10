using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olmp
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        public static string email;
        private void Account_Load(object sender, EventArgs e)
        {
           
            int hours = int.Parse(DateTime.Now.ToString("HH"));
            lbl_hi.Text = "Добро";
            if (hours > 6 && hours < 12)
                lbl_hi.Text += "е утро";
            else if (hours > 12 && hours < 18)
                lbl_hi.Text += "го дня";
            else if (hours > 18 && hours < 22)
                lbl_hi.Text += "го вечера";
            else
                lbl_hi.Text += "ой ночи";

            
            lbl_hi.Text += ", " + email;
        }
    }
}
