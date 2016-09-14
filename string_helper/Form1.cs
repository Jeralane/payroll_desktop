using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace string_helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = DatabaseLibrary.StringHelper.ToPropertyName(textBox1.Text);
            textBox2.Text = DatabaseLibrary.StringHelper.ToCamelCase(input);
            textBox3.Text = DatabaseLibrary.StringHelper.ToSnakeCase(input);
            textBox4.Text = DatabaseLibrary.StringHelper.SplitCamelCase(input);
        }
    }
}
