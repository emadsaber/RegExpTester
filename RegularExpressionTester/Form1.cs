using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularExpressionTester
{
    public partial class Form1 : Form
    {
        StringBuilder sbLog;
        public Form1()
        {
            InitializeComponent();
            sbLog = new StringBuilder();
        }

        #region Events
        private void txtPattern_TextChanged(object sender, EventArgs e)
        {
            Validate(txtString.Text, txtPattern.Text);
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {
            Validate(txtString.Text, txtPattern.Text);
        }
        
        private void btnShowLog_Click(object sender, EventArgs e)
        {
            ToggleLog();
            ToggleButtonText();
        }
        #endregion

        #region Methods
        private void ToggleLog()
        {
            if (btnShowLog.Text == Constants.Controls.ShowLogText)
            {
                this.Width = Constants.Controls.ShowLogFormWidth;
            }
            else if (btnShowLog.Text == Constants.Controls.HideLogText)
            {
                this.Width = Constants.Controls.HideLogFormWidth;
            }
        }
        private void ToggleButtonText()
        {
            if (btnShowLog.Text == Constants.Controls.ShowLogText)
            {
                btnShowLog.Text = Constants.Controls.HideLogText;
            }
            else if (btnShowLog.Text == Constants.Controls.HideLogText)
            {
                btnShowLog.Text = Constants.Controls.ShowLogText;
            }
        }
        private void Validate(string target, string pattern)
        {
            try
            {
                var regex = new Regex(pattern);
                var isMatch = regex.IsMatch(target);

                ShowResult(isMatch);
                Log("Match Result: " + (isMatch ? "SUCCESS" : "FAIL"));
            }
            catch (Exception ex)
            {
                Log("Exception: " + ex.Message);
                ShowResult(false);
            }
        }
        private void Log(string message)
        {
            sbLog.AppendLine(message);
            sbLog.AppendLine("**********");
            txtResultLog.Text = sbLog.ToString();
            ScrollToEnd(txtResultLog);
        }
        private void ScrollToEnd(TextBox textBox)
        {
            textBox.SelectionStart = textBox.TextLength;
            textBox.ScrollToCaret();
        }
        private void ShowResult(bool isMatch)
        {
            lblResultColor.BackColor = isMatch ? Color.LimeGreen : Color.IndianRed;
        }
        #endregion

    }

    #region Constants

    public static class Constants
    {
        public static class Controls
        {
            public const string ShowLogText = ">>";
            public const string HideLogText = "<<";
            public const int ShowLogFormWidth = 751;
            public const int HideLogFormWidth = 467;
        }
    }

    #endregion
}
