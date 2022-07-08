namespace Automobile_Costs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private decimal getAllValues()
        {
            try
            {
                decimal loan = Decimal.Parse(textBoxLoanPayment.Text);
                decimal insurance = Decimal.Parse(textBoxInsurance.Text);
                decimal gas = Decimal.Parse(textBoxGas.Text);
                decimal oil = Decimal.Parse(textBoxOil.Text);
                decimal tires = Decimal.Parse(textBoxTires.Text);
                decimal maintenance = Decimal.Parse(textBoxMaintenance.Text);

                return loan + insurance + gas + oil + tires + maintenance;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void buttonCalculateMonthly_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monthlyTotal = getAllValues();

                labelTotal.Text = monthlyTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCalculateAnnual_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monthlyTotal = getAllValues();
                decimal yearlyTotal = monthlyTotal * 12;

                labelTotal.Text = yearlyTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}