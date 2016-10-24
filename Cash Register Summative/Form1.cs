///Created by Joy Harris
///October 14  2016
///for the purpose of simulating a store cash register
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cash_Register_Summative
{
    public partial class Form1 : Form
    {
        //declare variables and constants
        int ccmQuantity;
        int cmQuantity;
        int bmQuantity;
        double change;
        double subtotal;
        double taxPrice;
        double carrotPrice;
        double chocolatePrice;
        double blueberryPrice;
        double tender;
        const double CARROTCOST = 3.25;
        const double CHOCCHIPCOST = 3.5;
        const double BLUEBERRYCOST = 2.9;
        const double TAX = .13;
        const int ORDERNUMBER = 1;

        public Form1()
        {
            InitializeComponent();

            //assign number of each muffin to the appropriate variable
            try
            {
              ccmQuantity = Convert.ToInt16(chocChipMuffinBox.Text);
              cmQuantity = Convert.ToInt16(carrotMuffinBox.Text);
              bmQuantity = Convert.ToInt16(blueberryMuffinBox.Text);
            }
            catch
            {
                //if letters are used, tell user to input integers only
                tryCatchLabel.Text = "Please input integrs only";
            }
        }

        private void subtotalButton_Click(object sender, EventArgs e)
        {
            //calculate the total before tax
            carrotPrice = cmQuantity * CARROTCOST;
            chocolatePrice = ccmQuantity * CHOCCHIPCOST;
            blueberryPrice = bmQuantity * BLUEBERRYCOST;
            subtotal = carrotPrice + blueberryPrice + chocolatePrice;
            subtotalLabel.Text = Convert.ToString(subtotal);
        }

        private void taxButton_Click(object sender, EventArgs e)
        {
            //calculate tax
            taxLabel.Text = Convert.ToString(TAX * subtotal);
        }

        private void grandTotalButton_Click(object sender, EventArgs e)
        {
            //calculate the total after tax
            taxPrice = Convert.ToInt16(taxLabel.Text);
            grandTotalLabel.Text = Convert.ToString(subtotal + taxPrice);
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //make pens, fonts, etc.
            Font drawFont = new Font("Consolas", 8, FontStyle.Bold);
            Pen receiptPen = new Pen(Color.LightPink, 5);
            SolidBrush fontBrush = new SolidBrush(Color.Black);
            SolidBrush receiptBrush = new SolidBrush(Color.LightPink);
            Graphics formGraphics = this.CreateGraphics();

            //draw receipt
            formGraphics.FillRectangle(receiptBrush, 200, 55, 260, 200);
            Thread.Sleep(500);
            formGraphics.DrawString("Best Muffins Ever\nOrder Nuumber " + ORDERNUMBER + " October 2016", drawFont, fontBrush, 200, 60);
            Thread.Sleep(1000);
            formGraphics.DrawString("Chocolate Chip Muffins  " + ccmQuantity + " @ $" + CHOCCHIPCOST, drawFont, fontBrush, 200, 90);
            Thread.Sleep(1000);
            formGraphics.DrawString("Carrot Muffins          " + cmQuantity + " @ $" + CARROTCOST, drawFont, fontBrush, 200, 110);
            Thread.Sleep(1000);
            formGraphics.DrawString("Blueberry Muffins       " + bmQuantity + " @ $" + BLUEBERRYCOST, drawFont, fontBrush, 200, 130);
            Thread.Sleep(1000);
            formGraphics.DrawString("Subtotal                " + ccmQuantity*CHOCCHIPCOST +cmQuantity*CARROTCOST +bmQuantity*BLUEBERRYCOST, drawFont, fontBrush, 200, 150);
            Thread.Sleep(1000);
            formGraphics.DrawString("Tax @ 13%               " + TAX*ccmQuantity *CHOCCHIPCOST + TAX*cmQuantity * CARROTCOST + TAX*bmQuantity * BLUEBERRYCOST, drawFont, fontBrush, 200, 170);
            Thread.Sleep(1000);
            formGraphics.DrawString("Grand Total             " + taxLabel.Text + subtotalLabel.Text ,drawFont, fontBrush, 200, 190);
            Thread.Sleep(1000);
            formGraphics.DrawString("Tendered                " + tenderBox.Text, drawFont, fontBrush, 200, 210);
            Thread.Sleep(1000);

            try
            { 
                tender = Convert.ToInt16(tenderBox.Text);
                change = tender - Convert.ToInt16(grandTotalLabel.Text);
            }
            catch
            {
                tryCatchLabel.Text = "Please input numbers only";
            }

            formGraphics.DrawString("Change                     " + change, drawFont, fontBrush, 200, 230);

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //clear input and output areas
            Graphics formGraphics = this.CreateGraphics();
            carrotMuffinBox.Text = "";
            chocChipMuffinBox.Text = "";
            blueberryMuffinBox.Text = "";
            subtotalLabel.Text = "";
            grandTotalLabel.Text = "";
            taxLabel.Text = "";
            tenderBox.Text = "";
            formGraphics.Clear(Color.PeachPuff);

        }
    }
}
