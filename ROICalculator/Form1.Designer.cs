namespace ROICalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sellPriceBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.feeBox = new System.Windows.Forms.NumericUpDown();
            this.shippingBox = new System.Windows.Forms.NumericUpDown();
            this.itemCostBox = new System.Windows.Forms.NumericUpDown();
            this.totalText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roiText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellPriceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCostBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sellPriceBox
            // 
            this.sellPriceBox.DecimalPlaces = 2;
            this.sellPriceBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.sellPriceBox.Location = new System.Drawing.Point(433, 60);
            this.sellPriceBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sellPriceBox.Name = "sellPriceBox";
            this.sellPriceBox.Size = new System.Drawing.Size(120, 20);
            this.sellPriceBox.TabIndex = 0;
            this.sellPriceBox.ValueChanged += new System.EventHandler(this.itemCostBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "$";
            // 
            // feeBox
            // 
            this.feeBox.DecimalPlaces = 2;
            this.feeBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.feeBox.Location = new System.Drawing.Point(433, 108);
            this.feeBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.feeBox.Name = "feeBox";
            this.feeBox.Size = new System.Drawing.Size(120, 20);
            this.feeBox.TabIndex = 2;
            // 
            // shippingBox
            // 
            this.shippingBox.DecimalPlaces = 2;
            this.shippingBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.shippingBox.Location = new System.Drawing.Point(433, 165);
            this.shippingBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shippingBox.Name = "shippingBox";
            this.shippingBox.Size = new System.Drawing.Size(120, 20);
            this.shippingBox.TabIndex = 3;
            // 
            // itemCostBox
            // 
            this.itemCostBox.DecimalPlaces = 2;
            this.itemCostBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.itemCostBox.Location = new System.Drawing.Point(433, 221);
            this.itemCostBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.itemCostBox.Name = "itemCostBox";
            this.itemCostBox.Size = new System.Drawing.Size(120, 20);
            this.itemCostBox.TabIndex = 4;
            // 
            // totalText
            // 
            this.totalText.AutoSize = true;
            this.totalText.Location = new System.Drawing.Point(364, 352);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(55, 13);
            this.totalText.TabIndex = 5;
            this.totalText.Text = "Total Cost";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "$";
            // 
            // roiText
            // 
            this.roiText.AutoSize = true;
            this.roiText.Location = new System.Drawing.Point(329, 387);
            this.roiText.Name = "roiText";
            this.roiText.Size = new System.Drawing.Size(109, 13);
            this.roiText.TabIndex = 10;
            this.roiText.Text = "Return on Investment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Selling Price (Gross Revenue):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seller Fees:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Shipping Fees:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cost of Item (for you): ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roiText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.itemCostBox);
            this.Controls.Add(this.shippingBox);
            this.Controls.Add(this.feeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sellPriceBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sellPriceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCostBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sellPriceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown feeBox;
        private System.Windows.Forms.NumericUpDown shippingBox;
        private System.Windows.Forms.NumericUpDown itemCostBox;
        private System.Windows.Forms.Label totalText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label roiText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

