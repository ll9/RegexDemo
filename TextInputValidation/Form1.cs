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

namespace TextInputValidation
{
    public partial class Form1 : Form
    {
        List<string> existingItems = new List<string>()
        {
            "Table1", "Leuchtstellen"
        };

        public Form1()
        {
            InitializeComponent();
        }

        // Handle single letter input
        private void ValidationBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[a-zA-Z\bäöüß 0-9]"))
            {
                e.Handled = true;
            }
        }

        // Handle paste
        private void ValidationBox_TextChanged(object sender, EventArgs e)
        {
            ValidationBox.Text = Regex.Replace(ValidationBox.Text, "[^a-zA-Z\bäöüß 0-9]", "");
        }

        // Handle Special cases (for example special value is not allowed, complex regex etc.)
        private void ValidationBox_Validated(object sender, EventArgs e)
        {
            var regex = new Regex("bla");
            if (existingItems.Contains(ValidationBox.Text))
            {
                errorProvider1.SetError(ValidationBox, $"Table {ValidationBox.Text} already exists!");
            }
        }

    }
}
