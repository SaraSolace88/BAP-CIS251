namespace Program2
{
    partial class frmTicketCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicketCalculator));
            lblName = new Label();
            lblClassName = new Label();
            lblNumOfChildren = new Label();
            txtChildAmt = new TextBox();
            txtAdultAmt = new TextBox();
            lblNumOfAdults = new Label();
            txtSeniorAmt = new TextBox();
            lblNumOfSenior = new Label();
            btnExit = new Button();
            btnCalculate = new Button();
            lblSeniorTotal = new Label();
            lblAdultTotal = new Label();
            LblChildTotal = new Label();
            lblTotalMoney = new Label();
            lblTotalTickets = new Label();
            txtChildTotal = new TextBox();
            txtAdultTotal = new TextBox();
            txtSeniorTotal = new TextBox();
            txtTotalCost = new TextBox();
            txtTotalTickets = new TextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(86, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Sara Solace";
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Location = new Point(104, 9);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(54, 20);
            lblClassName.TabIndex = 1;
            lblClassName.Text = "CIS251";
            // 
            // lblNumOfChildren
            // 
            lblNumOfChildren.AutoSize = true;
            lblNumOfChildren.Location = new Point(12, 38);
            lblNumOfChildren.Name = "lblNumOfChildren";
            lblNumOfChildren.Size = new Size(191, 20);
            lblNumOfChildren.TabIndex = 2;
            lblNumOfChildren.Text = "Amount of Children Tickets:";
            // 
            // txtChildAmt
            // 
            txtChildAmt.Location = new Point(12, 61);
            txtChildAmt.Name = "txtChildAmt";
            txtChildAmt.Size = new Size(191, 27);
            txtChildAmt.TabIndex = 3;
            // 
            // txtAdultAmt
            // 
            txtAdultAmt.Location = new Point(12, 114);
            txtAdultAmt.Name = "txtAdultAmt";
            txtAdultAmt.Size = new Size(191, 27);
            txtAdultAmt.TabIndex = 5;
            // 
            // lblNumOfAdults
            // 
            lblNumOfAdults.AutoSize = true;
            lblNumOfAdults.Location = new Point(12, 91);
            lblNumOfAdults.Name = "lblNumOfAdults";
            lblNumOfAdults.Size = new Size(172, 20);
            lblNumOfAdults.TabIndex = 4;
            lblNumOfAdults.Text = "Amount of Adult Tickets:";
            // 
            // txtSeniorAmt
            // 
            txtSeniorAmt.Location = new Point(12, 167);
            txtSeniorAmt.Name = "txtSeniorAmt";
            txtSeniorAmt.Size = new Size(191, 27);
            txtSeniorAmt.TabIndex = 7;
            // 
            // lblNumOfSenior
            // 
            lblNumOfSenior.AutoSize = true;
            lblNumOfSenior.Location = new Point(12, 144);
            lblNumOfSenior.Name = "lblNumOfSenior";
            lblNumOfSenior.Size = new Size(178, 20);
            lblNumOfSenior.TabIndex = 6;
            lblNumOfSenior.Text = "Amount of Senior Tickets:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 235);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(191, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 200);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(191, 29);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblSeniorTotal
            // 
            lblSeniorTotal.AutoSize = true;
            lblSeniorTotal.Location = new Point(216, 144);
            lblSeniorTotal.Name = "lblSeniorTotal";
            lblSeniorTotal.Size = new Size(103, 20);
            lblSeniorTotal.TabIndex = 14;
            lblSeniorTotal.Text = "Senior Tickets:";
            // 
            // lblAdultTotal
            // 
            lblAdultTotal.AutoSize = true;
            lblAdultTotal.Location = new Point(216, 91);
            lblAdultTotal.Name = "lblAdultTotal";
            lblAdultTotal.Size = new Size(97, 20);
            lblAdultTotal.TabIndex = 12;
            lblAdultTotal.Text = "Adult Tickets:";
            // 
            // LblChildTotal
            // 
            LblChildTotal.AutoSize = true;
            LblChildTotal.Location = new Point(216, 38);
            LblChildTotal.Name = "LblChildTotal";
            LblChildTotal.Size = new Size(116, 20);
            LblChildTotal.TabIndex = 10;
            LblChildTotal.Text = "Children Tickets:";
            // 
            // lblTotalMoney
            // 
            lblTotalMoney.AutoSize = true;
            lblTotalMoney.Location = new Point(216, 200);
            lblTotalMoney.Name = "lblTotalMoney";
            lblTotalMoney.Size = new Size(82, 20);
            lblTotalMoney.TabIndex = 16;
            lblTotalMoney.Text = "Total Cost: ";
            // 
            // lblTotalTickets
            // 
            lblTotalTickets.AutoSize = true;
            lblTotalTickets.Location = new Point(221, 235);
            lblTotalTickets.Name = "lblTotalTickets";
            lblTotalTickets.Size = new Size(98, 20);
            lblTotalTickets.TabIndex = 17;
            lblTotalTickets.Text = "Total Tickets: ";
            // 
            // txtChildTotal
            // 
            txtChildTotal.Enabled = false;
            txtChildTotal.Location = new Point(338, 38);
            txtChildTotal.Name = "txtChildTotal";
            txtChildTotal.Size = new Size(121, 27);
            txtChildTotal.TabIndex = 23;
            txtChildTotal.Text = "$0.00";
            // 
            // txtAdultTotal
            // 
            txtAdultTotal.Enabled = false;
            txtAdultTotal.Location = new Point(338, 91);
            txtAdultTotal.Name = "txtAdultTotal";
            txtAdultTotal.Size = new Size(121, 27);
            txtAdultTotal.TabIndex = 24;
            txtAdultTotal.Text = "$0.00";
            // 
            // txtSeniorTotal
            // 
            txtSeniorTotal.Enabled = false;
            txtSeniorTotal.Location = new Point(338, 141);
            txtSeniorTotal.Name = "txtSeniorTotal";
            txtSeniorTotal.Size = new Size(121, 27);
            txtSeniorTotal.TabIndex = 25;
            txtSeniorTotal.Text = "$0.00";
            // 
            // txtTotalCost
            // 
            txtTotalCost.Enabled = false;
            txtTotalCost.Location = new Point(338, 200);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.Size = new Size(121, 27);
            txtTotalCost.TabIndex = 26;
            txtTotalCost.Text = "$0.00";
            // 
            // txtTotalTickets
            // 
            txtTotalTickets.Enabled = false;
            txtTotalTickets.Location = new Point(338, 235);
            txtTotalTickets.Name = "txtTotalTickets";
            txtTotalTickets.Size = new Size(121, 27);
            txtTotalTickets.TabIndex = 27;
            txtTotalTickets.Text = "$0.00";
            // 
            // frmTicketCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 277);
            Controls.Add(txtTotalTickets);
            Controls.Add(txtTotalCost);
            Controls.Add(txtSeniorTotal);
            Controls.Add(txtAdultTotal);
            Controls.Add(txtChildTotal);
            Controls.Add(lblTotalTickets);
            Controls.Add(lblTotalMoney);
            Controls.Add(lblSeniorTotal);
            Controls.Add(lblAdultTotal);
            Controls.Add(LblChildTotal);
            Controls.Add(btnCalculate);
            Controls.Add(btnExit);
            Controls.Add(txtSeniorAmt);
            Controls.Add(lblNumOfSenior);
            Controls.Add(txtAdultAmt);
            Controls.Add(lblNumOfAdults);
            Controls.Add(txtChildAmt);
            Controls.Add(lblNumOfChildren);
            Controls.Add(lblClassName);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTicketCalculator";
            Text = "Ticket Calculator - Sara Solace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblClassName;
        private Label lblNumOfChildren;
        private TextBox txtChildAmt;
        private TextBox txtAdultAmt;
        private Label lblNumOfAdults;
        private TextBox txtSeniorAmt;
        private Label lblNumOfSenior;
        private Button btnExit;
        private Button btnCalculate;
        private Label lblSeniorTotal;
        private Label lblAdultTotal;
        private Label LblChildTotal;
        private Label lblTotalMoney;
        private Label lblTotalTickets;
        private TextBox txtChildTotal;
        private TextBox txtAdultTotal;
        private TextBox txtSeniorTotal;
        private TextBox txtTotalCost;
        private TextBox txtTotalTickets;
    }
}
