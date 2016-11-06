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
            TitleTextBox.Text = Convert.ToString(SelectionListBox.Text);
            SetInfo();
            SaveInfo();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();

            order.Show();
            this.Hide();
        }

        private void SaveInfo()
        {
            
            Program.info.Title = TitleTextBox.Text;
            Program.info.Genre = GenreTextBox.Text;
            Program.info.Cost = CostTextBox.Text;

        }

        private void SetInfo()
        {
            //Checks for comedies
            if (TitleTextBox.Text == "Cedar Rapids" || TitleTextBox.Text == "The Dilemma" ||
                TitleTextBox.Text == "No Strings Attached" || TitleTextBox.Text == "Just Go With It")
            {
                GenreTextBox.Text = "Comedy";
            }

            //Checks for Sci-Fi
            if (TitleTextBox.Text == "Season of the Witch" || TitleTextBox.Text == "I am Number Four")
            {
                GenreTextBox.Text = "Sci-Fi";
            }

            //Checks for Action
            if (TitleTextBox.Text == "The Green Hornet" || TitleTextBox.Text == "Death Race 2" ||
                TitleTextBox.Text == "The Mechanic" || TitleTextBox.Text == "Sanctum" ||
                TitleTextBox.Text == "The Other Woman" || TitleTextBox.Text == "The Eagle")
            {
                GenreTextBox.Text = "Action";
            }

            //Checks for Family
            if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                GenreTextBox.Text = "Family";
            }

            //Check for Drama
            if (TitleTextBox.Text == "Company Men" || TitleTextBox.Text == "The Way Back" ||
                TitleTextBox.Text == "Waiting for Forever")
            {
                GenreTextBox.Text = "Drama";
            }

            //Check for Thriller
            if (TitleTextBox.Text == "The Roommate")
            {
                GenreTextBox.Text = "Thriller";
            }

            //Check for new release
            if (TitleTextBox.Text == "Footloose" || TitleTextBox.Text == "Real Steel")
            {
                GenreTextBox.Text = "New Releases";
            }

            //Set genres
            if(GenreTextBox.Text == "Comedy")
            {
                CostTextBox.Text = "$1.99";
            }
            if (GenreTextBox.Text == "Drama")
            {
                CostTextBox.Text = "$1.99";
            }
            if (GenreTextBox.Text == "Action")
            {
                CostTextBox.Text = "$2.99";
            }
            if (GenreTextBox.Text == "Sci-Fi")
            {
                CostTextBox.Text = "$2.99";
            }
            if (GenreTextBox.Text == "Thriller")
            {
                CostTextBox.Text = "$1.99";
            }
            if (GenreTextBox.Text == "Family")
            {
                CostTextBox.Text = "$0.99";
            }
            if (GenreTextBox.Text == "New Releases")
            {
                CostTextBox.Text = "$4.99";
            }

             

        }

        //When back button is hit and selection form reloads, textboxes and lists are populated with previous selection
         public void ReturnInfo()
        {
            TitleTextBox.Text = Program.info.Title;
            GenreTextBox.Text = Program.info.Genre;
            CostTextBox.Text = Program.info.Cost;

            SelectionListBox.Text = TitleTextBox.Text;
        }
    }
}
