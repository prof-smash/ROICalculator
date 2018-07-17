using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void itemCostBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal totalCost = sellPriceBox.Value - feeBox.Value - shippingBox.Value - itemCostBox.Value;
            totalText.Text = "Profit: $" + totalCost;
            decimal roi = totalCost / itemCostBox.Value;
            roi *= 100;
            roiText.Text = "Return On Investment: " + roi + "%";
        }
    }
}
