namespace Program1
{
    partial class frmRefinishingFloorCalculator
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
            lblNameAndClassName = new Label();
            txtLength = new TextBox();
            lblInstructions = new Label();
            lblLength = new Label();
            lblWidth = new Label();
            txtWidth = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            lblSquaredFtResult = new Label();
            lblRoomSize = new Label();
            lblStripAndSandCost = new Label();
            lblStripAndSandResult = new Label();
            lblSealingCost = new Label();
            lblSealingResult = new Label();
            lblTotalCost = new Label();
            lblTotalResult = new Label();
            SuspendLayout();
            // 
            // lblNameAndClassName
            // 
            lblNameAndClassName.AutoSize = true;
            lblNameAndClassName.Location = new Point(12, 9);
            lblNameAndClassName.Name = "lblNameAndClassName";
            lblNameAndClassName.Size = new Size(145, 20);
            lblNameAndClassName.TabIndex = 0;
            lblNameAndClassName.Text = "Sara Solace - CIS251";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(12, 94);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(125, 27);
            txtLength.TabIndex = 1;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(12, 51);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(270, 20);
            lblInstructions.TabIndex = 2;
            lblInstructions.Text = "Enter the length and width of the room:";
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(12, 71);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(57, 20);
            lblLength.TabIndex = 3;
            lblLength.Text = "Length:";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(157, 71);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(52, 20);
            lblWidth.TabIndex = 4;
            lblWidth.Text = "Width:";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(157, 94);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 27);
            txtWidth.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 127);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(270, 29);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(240, 322);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(44, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblSquaredFtResult
            // 
            lblSquaredFtResult.BackColor = SystemColors.Control;
            lblSquaredFtResult.BorderStyle = BorderStyle.FixedSingle;
            lblSquaredFtResult.FlatStyle = FlatStyle.System;
            lblSquaredFtResult.Location = new Point(12, 179);
            lblSquaredFtResult.Name = "lblSquaredFtResult";
            lblSquaredFtResult.Size = new Size(270, 20);
            lblSquaredFtResult.TabIndex = 8;
            // 
            // lblRoomSize
            // 
            lblRoomSize.AutoSize = true;
            lblRoomSize.Location = new Point(12, 159);
            lblRoomSize.Name = "lblRoomSize";
            lblRoomSize.Size = new Size(81, 20);
            lblRoomSize.TabIndex = 9;
            lblRoomSize.Text = "Squared ft:";
            // 
            // lblStripAndSandCost
            // 
            lblStripAndSandCost.AutoSize = true;
            lblStripAndSandCost.Location = new Point(12, 199);
            lblStripAndSandCost.Name = "lblStripAndSandCost";
            lblStripAndSandCost.Size = new Size(211, 20);
            lblStripAndSandCost.TabIndex = 10;
            lblStripAndSandCost.Text = "Cost of Stripping and Sanding:";
            // 
            // lblStripAndSandResult
            // 
            lblStripAndSandResult.BackColor = SystemColors.Control;
            lblStripAndSandResult.BorderStyle = BorderStyle.FixedSingle;
            lblStripAndSandResult.FlatStyle = FlatStyle.System;
            lblStripAndSandResult.Location = new Point(12, 219);
            lblStripAndSandResult.Name = "lblStripAndSandResult";
            lblStripAndSandResult.Size = new Size(270, 20);
            lblStripAndSandResult.TabIndex = 11;
            // 
            // lblSealingCost
            // 
            lblSealingCost.AutoSize = true;
            lblSealingCost.Location = new Point(12, 239);
            lblSealingCost.Name = "lblSealingCost";
            lblSealingCost.Size = new Size(112, 20);
            lblSealingCost.TabIndex = 12;
            lblSealingCost.Text = "Cost of Sealing:";
            // 
            // lblSealingResult
            // 
            lblSealingResult.BackColor = SystemColors.Control;
            lblSealingResult.BorderStyle = BorderStyle.FixedSingle;
            lblSealingResult.FlatStyle = FlatStyle.System;
            lblSealingResult.Location = new Point(12, 259);
            lblSealingResult.Name = "lblSealingResult";
            lblSealingResult.Size = new Size(270, 20);
            lblSealingResult.TabIndex = 13;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(12, 279);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(78, 20);
            lblTotalCost.TabIndex = 14;
            lblTotalCost.Text = "Total Cost:";
            // 
            // lblTotalResult
            // 
            lblTotalResult.BackColor = SystemColors.Control;
            lblTotalResult.BorderStyle = BorderStyle.FixedSingle;
            lblTotalResult.FlatStyle = FlatStyle.System;
            lblTotalResult.Location = new Point(12, 299);
            lblTotalResult.Name = "lblTotalResult";
            lblTotalResult.Size = new Size(270, 20);
            lblTotalResult.TabIndex = 15;
            // 
            // frmRefinishingFloorCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 361);
            Controls.Add(lblTotalResult);
            Controls.Add(lblTotalCost);
            Controls.Add(lblSealingResult);
            Controls.Add(lblSealingCost);
            Controls.Add(lblStripAndSandResult);
            Controls.Add(lblStripAndSandCost);
            Controls.Add(lblRoomSize);
            Controls.Add(lblSquaredFtResult);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtWidth);
            Controls.Add(lblWidth);
            Controls.Add(lblLength);
            Controls.Add(lblInstructions);
            Controls.Add(txtLength);
            Controls.Add(lblNameAndClassName);
            Name = "frmRefinishingFloorCalculator";
            Text = "RefinishingFloorCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameAndClassName;
        private TextBox txtLength;
        private Label lblInstructions;
        private Label lblLength;
        private Label lblWidth;
        private TextBox txtWidth;
        private Button btnCalculate;
        private Button btnExit;
        private Label lblSquaredFtResult;
        private Label lblRoomSize;
        private Label lblStripAndSandCost;
        private Label lblStripAndSandResult;
        private Label lblSealingCost;
        private Label lblSealingResult;
        private Label lblTotalCost;
        private Label lblTotalResult;
    }
}
