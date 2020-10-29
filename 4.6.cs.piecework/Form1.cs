using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Project: Piecework
 * Programmer: Brendan Hawk
 * Date:10/19/2020
 * Description: User puts in their name and the amount of pieces that they made and depending on their amount they get paid more per piece. 
 */
namespace _4._6.cs.piecework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            int pieces1;
            int pieces2;
            decimal earned1;
            decimal earned2;
            decimal totalPieces;
            decimal totalPay;
            decimal averagePay;
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Declare the variables and set them equal to the correct textboxes

           

            pieces1 = int.Parse(piecesCompleted1TextBox.Text);
            pieces2 = int.Parse(piecesCompleted2TextBox.Text);


            // Calculate the earned amount for first person

            if (pieces1 <= 199) {
                earned1 = (decimal)(pieces1 * 0.5);
            }
            if (pieces1 >= 200 || pieces1 <= 399) {
                earned1 = (decimal)(pieces1 * 0.55);
            }
            if (pieces1 >= 400 || pieces1 <= 599) {
                earned1 = (decimal)(pieces1 * 0.6);
            }
            if (pieces1 <= 600)
            {
                earned1 = (decimal)(pieces1 * 0.65);
            }

            // Calculate the earned amount for second person

            if (pieces2 <= 199)
            {
                earned2 = (decimal)(pieces2 * 0.5);
            }
            if (pieces2 >= 200 || pieces2 <= 399)
            {
                earned2 = (decimal)(pieces2 * 0.55);
            }
            if (pieces2 >= 400 || pieces2 <= 599)
            {
                earned2 = (decimal)(pieces2 * 0.6);
            }
            if (pieces2 <= 600)
            {
                earned2 = (decimal)(pieces2 * 0.65);
            }
            piecesCompleted1TextBox.Text = pieces1.ToString();
            piecesCompleted2TextBox.Text = pieces2.ToString();
            amountEarned1TextBox.Text = earned1.ToString("C");
            amountEarned2TextBox.Text = earned2.ToString("C");
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            // Calculate the total pieces, total pay, and average pay per person

            totalPieces = pieces1 + pieces2;
            totalPay = earned1 + earned2;
            averagePay = totalPay / 2;

            totalPiecesTextBox.Text = totalPieces.ToString();
            totalPayTextBox.Text = totalPay.ToString("C");
            averagePayTextBox.Text = averagePay.ToString("C");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the name and number of pieces for the current employee

            name1TextBox.Clear();
            name2TextBox.Clear();
            piecesCompleted1TextBox.Clear();
            piecesCompleted2TextBox.Clear();

        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            //Clear the summary totals after confirming the operation with the user

            totalPiecesTextBox.Clear();
            totalPayTextBox.Clear();
            averagePayTextBox.Clear();

        }
    }
}
