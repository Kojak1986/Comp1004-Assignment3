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

    public partial class OrderForm : Form
    {
        SelectionForm select = new SelectionForm();
        public OrderForm()
        {
            InitializeComponent();
        }

        //Cancel button closes the form
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //X closes the form
        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //When the form loads populate with info saved from the last form
        private void OrderForm_Load(object sender, EventArgs e)
        {


            TitleTextBox.Text = Program.info.Title;
            GenreTextBox.Text = Program.info.Genre;
            CostTextBox.Text = Program.info.Cost;
            OrderPictureBox.Image = Program.info.Picture;

            CalculateTotals();
        }

        //Method will calculate the totals of the movie depending on whether or not the add dvd box is checked
        private void CalculateTotals()
        {
         
            if (OrderDvdCheckBox.Checked == true)
            {
                DvdLabel.Show();
                DvdCostTextBox.Show();
                double TotalTax = Convert.ToDouble((CostTextBox.Text as string).TrimStart('$'));
                double DvdCost = TotalTax + 10;
                
                
                TotalTax = DvdCost * 0.13;
                double Grand = TotalTax + DvdCost;

                
                SubtotalTextBox.Text = DvdCost.ToString("C2");
                SalesTaxTextBox.Text = TotalTax.ToString("C2");
                GrandTotalTextBox.Text = Grand.ToString("C2");
                Program.info.GrandTotal = GrandTotalTextBox.Text;

            }
            else if(OrderDvdCheckBox.Checked == false)
            {
                DvdLabel.Hide();
                DvdCostTextBox.Hide();
                CostTextBox.Text = Program.info.Cost;
                double TotalTax = Convert.ToDouble((CostTextBox.Text as string).TrimStart('$'));
                double Grand = TotalTax * 1.13;
                TotalTax = TotalTax * 0.13;
                


                SubtotalTextBox.Text = CostTextBox.Text;
                SalesTaxTextBox.Text = TotalTax.ToString("C2");
                GrandTotalTextBox.Text = Grand.ToString("C2");
                Program.info.GrandTotal = GrandTotalTextBox.Text;
            }

        }

        //Back button returns you to the previous form.
        private void BackButton_Click(object sender, EventArgs e)
        {
            select.Show();
            this.Hide();
            select.ReturnInfo();


        }

        //When check box is checked run the calculate totals method
        private void OrderDvdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            CalculateTotals();
          
            
            
        }
        // Stream button hides this form and brings up the stream form
        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm stream = new StreamForm();
            stream.Show();
            this.Hide();
        }
        //Shows a print preview for the reciept
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here's a look at your reciept:" + "\r\n" + "Movie Ordered: " + Program.info.Title + "\r\n" +
               "Genre: " + Program.info.Genre + "\r\n" + "Total Cost: " + Program.info.GrandTotal,"Reciept");
        }
        //Menu stream button calls the stream button
        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamButton.PerformClick();
        }
        //Menu cancel button calls the cancel button
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelButton.PerformClick();
        }
        // Shows an about dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer: Karl Kovacs" + "\r\n" + 
                "Version: 3.0" + "\r\n" + "Website: www.moviebonanza.com" + "\r\n" +
                "Phone: 1-800-739-2934 ","About");
        }

       



    }
}