using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petrik_2017_14s_kozos
{
    public partial class Form1 : Form
    {
        private readonly string defaultText = "HGabor";
        private readonly Color defaultColor = Color.Aqua;

        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel1.BackColor = defaultColor;

            var tb = new TextBox();
            tb.Text = defaultText;
            tb.Width = 200;
            flowLayoutPanel1.Controls.Add(tb);

            var colorButton = new Button();
            colorButton.BackColor = Control.DefaultBackColor;
            colorButton.Text = "Choose background";
            colorButton.Width = 150;
            colorButton.Click += (sender, e) => {
                var colorDialog = new ColorDialog();
                var result = colorDialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    flowLayoutPanel1.BackColor = colorDialog.Color;
                }
            };
            flowLayoutPanel1.Controls.Add(colorButton);
        }
    }
}
