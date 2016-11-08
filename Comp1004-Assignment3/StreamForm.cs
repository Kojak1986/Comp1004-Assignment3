using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Comp1004_Assignment3
{
    public partial class StreamForm : Form
    {

        public StreamForm()
        {
            InitializeComponent();
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void StreamOkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //When the form loads it will grab your selection and show you a receipt
        private void StreamForm_Load(object sender, EventArgs e)
        {
            StreamTextBox.Text = "Thank you for choosing Movie Bananza!" + "\r\n" + "Your movie is: " + Program.info.Title + "\r\n"
                + "Your cost is: " + Program.info.GrandTotal + "\r\n" + "Your movie will begin shortly!";
        }

        private void StreamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
