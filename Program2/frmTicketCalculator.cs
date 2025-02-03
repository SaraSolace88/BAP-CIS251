namespace Program2
{
    public partial class frmTicketCalculator : Form
    {
        public frmTicketCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtChildAmt.Text, out int childAmt) && int.TryParse(txtAdultAmt.Text, out int adultAmt) && int.TryParse(txtSeniorAmt.Text, out int seniorAmt))
            {
                //child ticket cost
                float childCost = childAmt * 6.00f;
                txtChildTotal.Text = $"${childCost:F2}";
                //adult ticket cost
                float adultCost = adultAmt * 9.00f;
                txtAdultTotal.Text = $"${adultCost:F2}";
                //senior ticket cost
                float seniorCost = seniorAmt * 7.00f;
                txtSeniorTotal.Text = $"${seniorCost:F2}";
                //total cost
                txtTotalCost.Text = $"${childCost + adultCost + seniorCost:F2}";
                //total tickets
                txtTotalTickets.Text = $"{childAmt + adultAmt + seniorAmt}";
            }
        }
    }
}