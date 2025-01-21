namespace Program1
{
    public partial class frmRefinishingFloorCalculator : Form
    {
        public frmRefinishingFloorCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtLength.Text, out float length) && float.TryParse(txtWidth.Text, out float width))
            {
                lblSquaredFtResult.Text = (length * width).ToString();
                lblStripAndSandResult.Text = "$" + (length * width * 2.29);
                lblSealingResult.Text = "$" + (length * width * 1.79);
                lblTotalResult.Text = "$" + ((length * width * 2.29) + (length * width * 1.79));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
