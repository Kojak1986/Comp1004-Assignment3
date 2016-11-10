using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*  Movie Bonanza
 *  Karl Kovacs
 *  200327966
 *  November 10, 2016
 *  This app is a movie selection and streaming app
 */
namespace Comp1004_Assignment3
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        //Form has a 3 second timer, when finished this form will hide and the selection form will show
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Stop();
            SelectionForm select = new SelectionForm();
            select.Show();
            this.Hide();

        }
    }
}
