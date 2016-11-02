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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();

            order.Show();
            this.Hide();
        }
    }
}
