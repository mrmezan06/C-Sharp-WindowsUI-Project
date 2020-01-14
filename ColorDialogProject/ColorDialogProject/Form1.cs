using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorDialogProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
          //  cd.AllowFullOpen = false;
            cd.FullOpen = true;
            //show help option
            cd.ShowHelp = true;
            //help request handler
            cd.HelpRequest += new EventHandler(cd_HelpRequest);
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
               // btn.BackColor = cd.Color;
                Color c = cd.Color;
               
               //ARGB Format 
               // MessageBox.Show(c.ToArgb().ToString("X"));
               //Hash Code Format
                MessageBox.Show(c.GetHashCode().ToString("X"));
                //ARGB To Color Format
                Color b = Color.FromArgb(c.ToArgb());
                btn.BackColor = b;

            }
        }

        //handler method
        private void cd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a color for Button Background");
        }
    }
}
