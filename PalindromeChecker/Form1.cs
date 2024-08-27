using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalindromeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string inputWord = inputTextBox.Text;
            if (string.IsNullOrWhiteSpace(inputWord))
            {
                resultLabel.Text = "Please enter a word to check.";
                resultLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }
            PalindromeChecker checker = new PalindromeChecker(inputWord);

            string cleanedWord = checker.CleanedWord;

            if (checker.IsPalindrome())
            {
                resultLabel.Text = $"'{cleanedWord}' is a palindrome.";
                resultLabel.ForeColor = System.Drawing.Color.LimeGreen;
            }
            else
            {
                resultLabel.Text = $"'{cleanedWord}' is not a palindrome.";
                resultLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void inputTextBox_Enter(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "Input word")
            {
                inputTextBox.Text = "";

                inputTextBox.ForeColor = Color.Black;
            }
        }
        private void inputTextBox_Leave_1(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "")
            {
                inputTextBox.Text = "Input word";

                inputTextBox.ForeColor = Color.Silver;
            }
        }
    }
}
