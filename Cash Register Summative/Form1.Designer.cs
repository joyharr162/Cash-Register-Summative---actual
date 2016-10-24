namespace Cash_Register_Summative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.carrotMuffinLabel = new System.Windows.Forms.Label();
            this.chocChipMuffinLabel = new System.Windows.Forms.Label();
            this.blueberryMuffinLabel = new System.Windows.Forms.Label();
            this.carrotMuffinBox = new System.Windows.Forms.TextBox();
            this.chocChipMuffinBox = new System.Windows.Forms.TextBox();
            this.blueberryMuffinBox = new System.Windows.Forms.TextBox();
            this.subtotalButton = new System.Windows.Forms.Button();
            this.taxButton = new System.Windows.Forms.Button();
            this.grandTotalButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.tenderLabel = new System.Windows.Forms.Label();
            this.tenderBox = new System.Windows.Forms.TextBox();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tryCatchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carrotMuffinLabel
            // 
            this.carrotMuffinLabel.AutoSize = true;
            this.carrotMuffinLabel.Location = new System.Drawing.Point(15, 72);
            this.carrotMuffinLabel.Name = "carrotMuffinLabel";
            this.carrotMuffinLabel.Size = new System.Drawing.Size(102, 13);
            this.carrotMuffinLabel.TabIndex = 0;
            this.carrotMuffinLabel.Text = "Carrot Muffins $3.25";
            // 
            // chocChipMuffinLabel
            // 
            this.chocChipMuffinLabel.AutoSize = true;
            this.chocChipMuffinLabel.Location = new System.Drawing.Point(15, 103);
            this.chocChipMuffinLabel.Name = "chocChipMuffinLabel";
            this.chocChipMuffinLabel.Size = new System.Drawing.Size(146, 13);
            this.chocChipMuffinLabel.TabIndex = 1;
            this.chocChipMuffinLabel.Text = "Chocolate Chip Muffins $3.50";
            // 
            // blueberryMuffinLabel
            // 
            this.blueberryMuffinLabel.AutoSize = true;
            this.blueberryMuffinLabel.Location = new System.Drawing.Point(15, 133);
            this.blueberryMuffinLabel.Name = "blueberryMuffinLabel";
            this.blueberryMuffinLabel.Size = new System.Drawing.Size(118, 13);
            this.blueberryMuffinLabel.TabIndex = 2;
            this.blueberryMuffinLabel.Text = "Blueberry Muffins $2.90";
            // 
            // carrotMuffinBox
            // 
            this.carrotMuffinBox.Location = new System.Drawing.Point(173, 65);
            this.carrotMuffinBox.Name = "carrotMuffinBox";
            this.carrotMuffinBox.Size = new System.Drawing.Size(27, 20);
            this.carrotMuffinBox.TabIndex = 3;
            // 
            // chocChipMuffinBox
            // 
            this.chocChipMuffinBox.Location = new System.Drawing.Point(173, 100);
            this.chocChipMuffinBox.Name = "chocChipMuffinBox";
            this.chocChipMuffinBox.Size = new System.Drawing.Size(27, 20);
            this.chocChipMuffinBox.TabIndex = 4;
            // 
            // blueberryMuffinBox
            // 
            this.blueberryMuffinBox.Location = new System.Drawing.Point(173, 133);
            this.blueberryMuffinBox.Name = "blueberryMuffinBox";
            this.blueberryMuffinBox.Size = new System.Drawing.Size(27, 20);
            this.blueberryMuffinBox.TabIndex = 5;
            // 
            // subtotalButton
            // 
            this.subtotalButton.BackColor = System.Drawing.Color.Salmon;
            this.subtotalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtotalButton.Location = new System.Drawing.Point(18, 158);
            this.subtotalButton.Name = "subtotalButton";
            this.subtotalButton.Size = new System.Drawing.Size(75, 23);
            this.subtotalButton.TabIndex = 6;
            this.subtotalButton.Text = "Subtotal";
            this.subtotalButton.UseVisualStyleBackColor = false;
            this.subtotalButton.Click += new System.EventHandler(this.subtotalButton_Click);
            // 
            // taxButton
            // 
            this.taxButton.BackColor = System.Drawing.Color.Salmon;
            this.taxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taxButton.Location = new System.Drawing.Point(18, 196);
            this.taxButton.Name = "taxButton";
            this.taxButton.Size = new System.Drawing.Size(75, 23);
            this.taxButton.TabIndex = 7;
            this.taxButton.Text = "Tax";
            this.taxButton.UseVisualStyleBackColor = false;
            this.taxButton.Click += new System.EventHandler(this.taxButton_Click);
            // 
            // grandTotalButton
            // 
            this.grandTotalButton.BackColor = System.Drawing.Color.Salmon;
            this.grandTotalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grandTotalButton.Location = new System.Drawing.Point(18, 234);
            this.grandTotalButton.Name = "grandTotalButton";
            this.grandTotalButton.Size = new System.Drawing.Size(75, 23);
            this.grandTotalButton.TabIndex = 8;
            this.grandTotalButton.Text = "Grand Total";
            this.grandTotalButton.UseVisualStyleBackColor = false;
            this.grandTotalButton.Click += new System.EventHandler(this.grandTotalButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(123, 158);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(0, 13);
            this.subtotalLabel.TabIndex = 9;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(123, 187);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(0, 13);
            this.taxLabel.TabIndex = 10;
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Location = new System.Drawing.Point(123, 221);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.grandTotalLabel.TabIndex = 11;
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.Salmon;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Location = new System.Drawing.Point(242, 32);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(118, 23);
            this.receiptButton.TabIndex = 12;
            this.receiptButton.Text = "Print My Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // tenderLabel
            // 
            this.tenderLabel.AutoSize = true;
            this.tenderLabel.Location = new System.Drawing.Point(21, 271);
            this.tenderLabel.Name = "tenderLabel";
            this.tenderLabel.Size = new System.Drawing.Size(123, 13);
            this.tenderLabel.TabIndex = 14;
            this.tenderLabel.Text = "Enter Amount Tendered:";
            // 
            // tenderBox
            // 
            this.tenderBox.Location = new System.Drawing.Point(173, 271);
            this.tenderBox.Name = "tenderBox";
            this.tenderBox.Size = new System.Drawing.Size(28, 20);
            this.tenderBox.TabIndex = 15;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.Salmon;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Location = new System.Drawing.Point(242, 3);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(118, 23);
            this.newOrderButton.TabIndex = 16;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Giddyup Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(182, 39);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Best Muffins Ever!";
            // 
            // tryCatchLabel
            // 
            this.tryCatchLabel.AutoSize = true;
            this.tryCatchLabel.Location = new System.Drawing.Point(15, 42);
            this.tryCatchLabel.Name = "tryCatchLabel";
            this.tryCatchLabel.Size = new System.Drawing.Size(0, 13);
            this.tryCatchLabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(404, 303);
            this.Controls.Add(this.tryCatchLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.tenderBox);
            this.Controls.Add(this.tenderLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.grandTotalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.grandTotalButton);
            this.Controls.Add(this.taxButton);
            this.Controls.Add(this.subtotalButton);
            this.Controls.Add(this.blueberryMuffinBox);
            this.Controls.Add(this.chocChipMuffinBox);
            this.Controls.Add(this.carrotMuffinBox);
            this.Controls.Add(this.blueberryMuffinLabel);
            this.Controls.Add(this.chocChipMuffinLabel);
            this.Controls.Add(this.carrotMuffinLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Best Muffins Ever";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carrotMuffinLabel;
        private System.Windows.Forms.Label chocChipMuffinLabel;
        private System.Windows.Forms.Label blueberryMuffinLabel;
        private System.Windows.Forms.TextBox carrotMuffinBox;
        private System.Windows.Forms.TextBox chocChipMuffinBox;
        private System.Windows.Forms.TextBox blueberryMuffinBox;
        private System.Windows.Forms.Button subtotalButton;
        private System.Windows.Forms.Button taxButton;
        private System.Windows.Forms.Button grandTotalButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label tenderLabel;
        private System.Windows.Forms.TextBox tenderBox;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label tryCatchLabel;
    }
}

