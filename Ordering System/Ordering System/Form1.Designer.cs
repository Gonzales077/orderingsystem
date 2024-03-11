namespace Ordering_System
{
    partial class Form1
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
            panel1 = new Panel();
            lblTotal = new Label();
            lblTax = new Label();
            lblSukli = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            btnConfirm = new Button();
            lblReceipt = new Label();
            panel2 = new Panel();
            txtPay = new TextBox();
            panel3 = new Panel();
            lblHeader = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBox4 = new ComboBox();
            lblFlav = new Label();
            lblCig = new Label();
            comboBox3 = new ComboBox();
            label1 = new Label();
            cboChips = new Label();
            cboDrinks = new Label();
            btnVoid = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblTax);
            panel1.Controls.Add(lblSukli);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(lblReceipt);
            panel1.Location = new Point(402, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 406);
            panel1.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(223, 111);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(22, 15);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "---";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(223, 159);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(22, 15);
            lblTax.TabIndex = 11;
            lblTax.Text = "---";
            // 
            // lblSukli
            // 
            lblSukli.AutoSize = true;
            lblSukli.Location = new Point(223, 268);
            lblSukli.Name = "lblSukli";
            lblSukli.Size = new Size(22, 15);
            lblSukli.TabIndex = 10;
            lblSukli.Text = "---";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 257);
            label7.Name = "label7";
            label7.Size = new Size(79, 26);
            label7.TabIndex = 9;
            label7.Text = "Change";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 149);
            label6.Name = "label6";
            label6.Size = new Size(42, 26);
            label6.TabIndex = 8;
            label6.Text = "TAX";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 101);
            label3.Name = "label3";
            label3.Size = new Size(64, 26);
            label3.TabIndex = 7;
            label3.Text = "TOTAL ";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.DarkGreen;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(78, 327);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(136, 50);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblReceipt
            // 
            lblReceipt.AutoSize = true;
            lblReceipt.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceipt.Location = new Point(87, 17);
            lblReceipt.Name = "lblReceipt";
            lblReceipt.Size = new Size(118, 39);
            lblReceipt.TabIndex = 1;
            lblReceipt.Text = "RECEIPT";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(txtPay);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox4);
            panel2.Controls.Add(lblFlav);
            panel2.Controls.Add(lblCig);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cboChips);
            panel2.Controls.Add(cboDrinks);
            panel2.Controls.Add(btnVoid);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(47, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 452);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txtPay
            // 
            txtPay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPay.Location = new Point(104, 347);
            txtPay.Name = "txtPay";
            txtPay.Size = new Size(154, 35);
            txtPay.TabIndex = 15;
            txtPay.TextChanged += txtPay_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCoral;
            panel3.Controls.Add(lblHeader);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 73);
            panel3.TabIndex = 14;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(38, 17);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(220, 36);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Vending Machine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 255);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 13;
            label2.Text = "FLAVOR ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(209, 89);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 12;
            label5.Text = "PRICE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(21, 89);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 11;
            label4.Text = "ITEMS";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "RED", "BLUE", "LIGHTS", "GREEN", "BLACK" });
            comboBox4.Location = new Point(21, 281);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(169, 23);
            comboBox4.TabIndex = 10;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // lblFlav
            // 
            lblFlav.AutoSize = true;
            lblFlav.BackColor = Color.Transparent;
            lblFlav.Location = new Point(222, 289);
            lblFlav.Name = "lblFlav";
            lblFlav.Size = new Size(22, 15);
            lblFlav.TabIndex = 9;
            lblFlav.Text = "---";
            // 
            // lblCig
            // 
            lblCig.AutoSize = true;
            lblCig.BackColor = Color.Transparent;
            lblCig.Location = new Point(222, 218);
            lblCig.Name = "lblCig";
            lblCig.Size = new Size(22, 15);
            lblCig.TabIndex = 8;
            lblCig.Text = "---";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "MARLBORO ", "FORTUNE", "HOPE", "CAMEL", "MIGHTY" });
            comboBox3.Location = new Point(21, 210);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(169, 23);
            comboBox3.TabIndex = 7;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 355);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 6;
            label1.Text = "PAY HERE";
            // 
            // cboChips
            // 
            cboChips.AutoSize = true;
            cboChips.BackColor = Color.Transparent;
            cboChips.Location = new Point(222, 166);
            cboChips.Name = "cboChips";
            cboChips.Size = new Size(22, 15);
            cboChips.TabIndex = 5;
            cboChips.Text = "---";
            // 
            // cboDrinks
            // 
            cboDrinks.AutoSize = true;
            cboDrinks.BackColor = Color.Transparent;
            cboDrinks.Location = new Point(222, 118);
            cboDrinks.Name = "cboDrinks";
            cboDrinks.Size = new Size(22, 15);
            cboDrinks.TabIndex = 4;
            cboDrinks.Text = "---";
            cboDrinks.Click += cboDrinks_Click;
            // 
            // btnVoid
            // 
            btnVoid.BackColor = Color.Red;
            btnVoid.FlatAppearance.BorderSize = 0;
            btnVoid.FlatStyle = FlatStyle.Flat;
            btnVoid.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoid.ForeColor = Color.White;
            btnVoid.Location = new Point(71, 398);
            btnVoid.Name = "btnVoid";
            btnVoid.Size = new Size(154, 35);
            btnVoid.TabIndex = 3;
            btnVoid.Text = "VOID";
            btnVoid.UseVisualStyleBackColor = false;
            btnVoid.Click += btnVoid_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "PILLOWS", "PIATTOS", "Vcut", "OISHI", "NAGARAYA", "CHEEZY", "NOVA", "CHIPPY" });
            comboBox2.Location = new Point(21, 158);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(169, 23);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "COBRA", "COKE", "SPRITE", "BOTTLED WATER", "PEPSI ", "STING", "ROOT BEER" });
            comboBox1.Location = new Point(21, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(727, 487);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblHeader;
        private Button btnConfirm;
        private Label lblReceipt;
        private Button btnVoid;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label cboChips;
        private Label cboDrinks;
        private Label label5;
        private Label label4;
        private ComboBox comboBox4;
        private Label lblFlav;
        private Label lblCig;
        private ComboBox comboBox3;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Label lblTotal;
        private Label lblTax;
        private Label lblSukli;
        private Label label7;
        private Label label6;
        private Label label3;
        private TextBox txtPay;
    }
}
