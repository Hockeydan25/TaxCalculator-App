using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtTaxIncome.Text);
            decimal taxowed = .0m;           // sets tax[percent variable and decimal value
            decimal taxpercent = .0m;        // sets tax[percent variable and decimal value
            decimal incometax = .0m;         // sets tax[percent variable and decimal value
            decimal over = .0m;
            decimal overtax = .0m;

            if (income > 0 && income <= 9875) // begigning nested else if clause
                taxpercent = .10m;
                 
            else if (income > 9876 && income <= 40125)      //income range to setup taxpercent,taxowed and over.
            {   taxpercent = .12m;                          // tax percent for range setup by the income input.
                taxowed = 987.50m;                          // taxowed is a static value. 
                over = 9875m;}
            else if (income > 40126 && income <= 85525)
            {   taxpercent = .22m;                          // tax percent for range setup by the income input.
                taxowed = 4617.50m;                         // taxowed is a static value. 
                over = 40125;}                              // over is a static value.
            else if(income > 85526 && income <= 163300)
            {   taxpercent = .24m;                          // tax percent for range setup by the income input.
                taxowed = 14605.50m;                        // taxowed is a static value.
                over = 85525;}                             // over is a static value.
            else if (income > 163301 && income <= 207350)
            {   taxpercent = .32m;                          // tax percent for range setup by the income input.
                taxowed = 33271.50m;                        // taxowed is a static value.
                over = 163300;}                             // over is a static value.
            else if (income > 207351 && income <= 518400)
            {   taxpercent = .35m;                          // tax percent for range setup by the income input.
                taxowed = 47367.50m;                        // taxowed is a static value.
                over = 207350;}                             // taxowed is a static value.
            else                                            // end nested else if clause 
            {   taxpercent = .37m;                          // tax percent for range setup by the income input.
                taxowed = 156235m;                          // taxowed is a static value.
                over = 518400;}                             // over is a static value.

            overtax = (taxpercent * income) - (taxpercent * over); // calcutale and assign value for the varibles
            incometax = taxowed + overtax;  // calcutale and assign value for the varibles 

            txtTaxOwed.Text = incometax.ToString("c");  // text box will have a curency value output.
                    
            txtTaxIncome.Focus();          //returns control to the  tax income TextBox.  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();                                     // closes the propgram to exit.
        }
    }

}
