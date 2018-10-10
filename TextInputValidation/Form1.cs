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

        private void ValidationBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[a-zA-Z\bß ]"))
            {
                e.Handled = true;
            }
        }
    }
}
