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
   
    public partial class OrderForm : Form
    {
        
        public OrderForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            
            TitleTextBox.Text = Program.info.Title;
            GenreTextBox.Text = Program.info.Genre;
            CostTextBox.Text = Program.info.Cost;

            CalculateTotals();

            
            
        }

        private void CalculateTotals()
        {
            double TotalTax = Convert.ToDouble((CostTextBox.Text as string).TrimStart('$'));
            double Grand = TotalTax * 1.13;

            TotalTax = TotalTax * 0.13;

            SubtotalTextBox.Text = CostTextBox.Text;
            SalesTaxTextBox.Text = TotalTax.ToString("C2");
            GrandTotalTextBox.Text = Grand.ToString("C2");

        }
    }
}
