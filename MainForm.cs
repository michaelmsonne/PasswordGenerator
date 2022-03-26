using System;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGenerate.PerformClick();
        }

        #region CheckBoxex

        // Påkrævet indebærer tilladt.
        private void ChkRequireLowercase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireLowercase.Checked) chkAllowLowercase.Checked = true;
        }

        private void ChkRequireUppercase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireUppercase.Checked) chkAllowUppercase.Checked = true;
        }

        private void ChkRequireNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireNumber.Checked) chkAllowNumber.Checked = true;
        }

        private void ChkRequireSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireSpecial.Checked) chkAllowSpecial.Checked = true;
        }

        private void ChkRequireUnderscore_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireUnderscore.Checked) chkAllowUnderscore.Checked = true;
        }

        private void ChkRequireSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRequireSpace.Checked) chkAllowSpace.Checked = true;
        }

        // Ikke tilladt indebærer ikke krævet.
        private void ChkAllowLowercase_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowLowercase.Checked) chkRequireLowercase.Checked = false;
        }

        private void ChkAllowUppercase_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowUppercase.Checked) chkRequireUppercase.Checked = false;
        }

        private void ChkAllowNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowNumber.Checked) chkRequireNumber.Checked = false;
        }

        private void ChkAllowSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowSpecial.Checked) chkRequireSpecial.Checked = false;
        }

        private void ChkAllowUnderscore_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowUnderscore.Checked) chkRequireUnderscore.Checked = false;
        }

        private void ChkAllowSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAllowSpace.Checked) chkRequireSpace.Checked = false;
        }

        #endregion CheckBoxex

        // Generer en ny adgangskode.
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = RandomPassword();

                // Når lavet en, kopier til udklipsholder
                if (txtPassword.Text != string.Empty)
                    Clipboard.SetText(txtPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Generer et kodeord, der opfylder kravene.
        private string RandomPassword()
        {
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string number = "0123456789";
            //const string special = @"~!@#$%^&*():;[]{}<>,.?/\|";
            const string special = @"?!@#$%&*/\.";

            // Lav en liste over tilladte tegn.
            var allowed = "";
            if (chkAllowLowercase.Checked) allowed += lower;
            if (chkAllowUppercase.Checked) allowed += upper;
            if (chkAllowNumber.Checked) allowed += number;
            if (chkAllowSpecial.Checked) allowed += special;
            if (chkAllowUnderscore.Checked) allowed += "_";
            if (chkAllowSpace.Checked) allowed += " ";

            // Vælg antallet af tegn.
            var minChars = int.Parse(txtMinLength.Text);
            var maxChars = int.Parse(txtMaxLength.Text);
            var numChars = Crypto.RandomInteger(minChars, maxChars);

            // Tilfredsstille krav.
            var password = "";
            if (chkRequireLowercase.Checked && password.IndexOfAny(lower.ToCharArray()) == -1)
                password += RandomChar(lower);
            if (chkRequireUppercase.Checked && password.IndexOfAny(upper.ToCharArray()) == -1)
                password += RandomChar(upper);
            if (chkRequireNumber.Checked && password.IndexOfAny(number.ToCharArray()) == -1)
                password += RandomChar(number);
            if (chkRequireSpecial.Checked && password.IndexOfAny(special.ToCharArray()) == -1)
                password += RandomChar(special);
            if (chkRequireUnderscore.Checked && password.IndexOfAny("_".ToCharArray()) == -1)
                password += "_";
            if (chkRequireSpace.Checked && password.IndexOfAny(" ".ToCharArray()) == -1)
                password += " ";

            // Tilføj de resterende tegn tilfældigt.
            while (password.Length < numChars)
                password += RandomChar(allowed);

            // Randomize (for at blande de krævede tegn foran).
            password = RandomizeString(password);

            return password;
        }

        // Returner et tilfældigt tegn fra en streng.
        private string RandomChar(string str)
        {
            return str.Substring(Crypto.RandomInteger(0, str.Length - 1), 1);
        }

        // Returner en tilfældig permutation af en streng.
        private string RandomizeString(string str)
        {
            var result = "";
            while (str.Length > 0)
            {
                // Vælg en tilfældig karakter.
                var i = Crypto.RandomInteger(0, str.Length - 1);
                result += str.Substring(i, 1);
                str = str.Remove(i, 1);
            }
            return result;
        }

        private void TxtMinLength_TextChanged(object sender, EventArgs e)
        {
            var actualdata = string.Empty;
            var entereddata = txtMinLength.Text.ToCharArray();
            foreach (var aChar in entereddata.AsEnumerable())
                if (char.IsDigit(aChar))
                {
                    actualdata = actualdata + aChar;
                    // MessageBox.Show(aChar.ToString());
                }
                else
                {
                    MessageBox.Show(@"´" + aChar + @"´ is not a number!", @"Only numbers is allowed in this box!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                    actualdata.Replace(aChar, ' ');
                    // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                    actualdata.Trim();
                }
            txtMinLength.Text = actualdata;
        }

        private void TxtMaxLength_TextChanged(object sender, EventArgs e)
        {
            var actualdata = string.Empty;
            var entereddata = txtMaxLength.Text.ToCharArray();
            foreach (var aChar in entereddata.AsEnumerable())
                if (char.IsDigit(aChar))
                {
                    actualdata = actualdata + aChar;
                    // MessageBox.Show(aChar.ToString());
                }
                else
                {
                    MessageBox.Show(@"´" + aChar + @"´ is not a number!", @"Only numbers is allowed in this box!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                    actualdata.Replace(aChar, ' ');
                    // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                    actualdata.Trim();
                }
            txtMaxLength.Text = actualdata;
        }
    }
}