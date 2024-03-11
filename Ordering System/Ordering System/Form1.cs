using System.Security.Policy;

namespace Ordering_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double total;
        private double pay;
        private void amount()
        {  
            double chipsPrice = 0;
            double drinksPrice = 0;
            double cigaPrice = 0;

                try
                {
                    drinksPrice = double.Parse(cboDrinks.Text);
                }
                catch { }

                try
                {
                    chipsPrice = double.Parse(cboChips.Text);
                }
                catch { }

                try
                {
                    cigaPrice = double.Parse(lblCig.Text);
                }
                catch { }

                total = chipsPrice + drinksPrice + cigaPrice;
                double tax = total * 0.12;
                lblTax.Text = tax.ToString("F2");
                lblTotal.Text = total.ToString();
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "COBRA":
                    cboDrinks.Text = "20";
                    break;
                case "COKE":
                    cboDrinks.Text = "25";
                    break;
                case "SPRITE":
                    cboDrinks.Text = "23";
                    break;
                case "BOTTLED WATER":
                    cboDrinks.Text = "15";
                    break;
                case "PEPSI ":
                    cboDrinks.Text = "18";
                    break;
                case "STING":
                    cboDrinks.Text = "21";
                    break;
                case "ROOT BEER":
                    cboDrinks.Text = "30";
                    break;
            }
            amount();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "PILLOWS":
                    cboChips.Text = "15";
                    break;
                case "PIATTOS":
                    cboChips.Text = "45";
                    break;
                case "Vcut":
                    cboChips.Text = "41";
                    break;
                case "OISHI":
                    cboChips.Text = "35";
                    break;
                case "NAGARAYA":
                    cboChips.Text = "20";
                    break;
                case "CHEEZY":
                    cboChips.Text = "50";
                    break;
                case "NOVA":
                    cboChips.Text = "25";
                    break;
                case "CHIPPY":
                    cboChips.Text = "30";
                    break;
            }
            amount();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.Text)
            {
                case "MARLBORO ":
                    lblCig.Text = "10";
                    break;
                case "FORTUNE":
                    lblCig.Text = "7";
                    break;
                case "HOPE":
                    lblCig.Text = "6";
                    break;
                case "CAMEL":
                    lblCig.Text = "5";
                    break;
                case "MIGHTY":
                    lblCig.Text = "9";
                    break;

            }
            amount();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.Text)
            {
                case "RED":
                    lblFlav.Text = "RED";
                    break;
                case "BLUE":
                    lblFlav.Text = "BLUE";
                    break;
                case "LIGHTS":
                    lblFlav.Text = "LIGHTS";
                    break;
                case "GREEN":
                    lblFlav.Text = "GREEN";
                    break;
                case "BLACK":
                    lblFlav.Text = "BLACK";
                    break;
            }
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pay = double.Parse(txtPay.Text);
            }
            catch
            {
                pay = 0;
            }

            if (pay >= total)
            {
                btnConfirm.Enabled = true;
            }
            else
            {
                btnConfirm.Enabled = false;
            }
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            lblCig.Text = null;
            lblFlav.Text = null;
            cboChips.Text = null;
            cboDrinks.Text = null;
            txtPay.Text = null;
            btnConfirm.Enabled = false;
            lblSukli.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            double change = pay - total;
            lblSukli.Text = change.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboDrinks_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}


