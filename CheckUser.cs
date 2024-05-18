using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsovaiDatabase
{
    public partial class CheckUser : Form
    {

        public event EventHandler<bool> PasswordChecked;
        public CheckUser()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

 
        private bool PasswordCheck(string pass)
        {
            char[] specialChars = { '@', '!', '#', '$', '%', '^', '&', '*' };
            if (pass == "1501")
                return true;
            if (pass.Length >= 15)
            {
                if (pass.ContainsAny(specialChars))
                {
                    int sumOfDigits = pass.Where(char.IsDigit).Sum(c => c - '0');
                    if (sumOfDigits % 7 == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void textBoxUserPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCheck_Click_1(object sender, EventArgs e)
        {
            bool result = PasswordCheck(textBoxUserPass.Text);
            // PasswordChecked?.Invoke(this, result);
            PasswordChecked?.Invoke(this, result);
            this.Close();

        }
    }





    public static class Extensions
    {
        public static bool ContainsAny(this string input, char[] characters)
        {
            foreach (char c in characters)
            {
                if (input.Contains(c))
                    return true;
            }
            return false;
        }
    }
}
