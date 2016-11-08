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
    public partial class GoodByeForm : Form
    {
        public GoodByeForm()
        {
            InitializeComponent();
        }

        private void GoodByeForm_Load(object sender, EventArgs e)
        {
            GoodByeTimer.Start();
        }

        private void GoodByeTimer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
