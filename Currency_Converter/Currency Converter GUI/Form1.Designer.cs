namespace Currency_Converter_GUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxReset = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.comboBoxCurrencyOld = new System.Windows.Forms.ComboBox();
            this.comboBoxCurrencyNew = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOldCurrency = new System.Windows.Forms.Label();
            this.labelNewCurrency = new System.Windows.Forms.Label();
            this.textBoxCurrentAmount = new System.Windows.Forms.TextBox();
            this.textBoxConverted = new System.Windows.Forms.TextBox();
            this.groupBoxReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Enabled = false;
            this.buttonCalculate.Location = new System.Drawing.Point(202, 126);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(71, 58);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Equals";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBoxReset
            // 
            this.groupBoxReset.Controls.Add(this.radioButtonNo);
            this.groupBoxReset.Controls.Add(this.radioButtonYes);
            this.groupBoxReset.Enabled = false;
            this.groupBoxReset.Location = new System.Drawing.Point(102, 253);
            this.groupBoxReset.Name = "groupBoxReset";
            this.groupBoxReset.Size = new System.Drawing.Size(253, 91);
            this.groupBoxReset.TabIndex = 1;
            this.groupBoxReset.TabStop = false;
            this.groupBoxReset.Text = "Another Conversion?";
            this.groupBoxReset.Visible = false;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(40, 54);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(40, 30);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.radioButtonYes_CheckedChanged);
            // 
            // comboBoxCurrencyOld
            // 
            this.comboBoxCurrencyOld.FormattingEnabled = true;
            this.comboBoxCurrencyOld.Location = new System.Drawing.Point(32, 52);
            this.comboBoxCurrencyOld.Name = "comboBoxCurrencyOld";
            this.comboBoxCurrencyOld.Size = new System.Drawing.Size(165, 21);
            this.comboBoxCurrencyOld.TabIndex = 2;
            this.comboBoxCurrencyOld.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrencyOld_SelectedIndexChanged);
            // 
            // comboBoxCurrencyNew
            // 
            this.comboBoxCurrencyNew.Enabled = false;
            this.comboBoxCurrencyNew.FormattingEnabled = true;
            this.comboBoxCurrencyNew.Location = new System.Drawing.Point(300, 52);
            this.comboBoxCurrencyNew.Name = "comboBoxCurrencyNew";
            this.comboBoxCurrencyNew.Size = new System.Drawing.Size(160, 21);
            this.comboBoxCurrencyNew.TabIndex = 3;
            this.comboBoxCurrencyNew.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrencyNew_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Currency I Have";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Currency I Want";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount I Have";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount I Will Have";
            // 
            // labelOldCurrency
            // 
            this.labelOldCurrency.AutoSize = true;
            this.labelOldCurrency.Location = new System.Drawing.Point(13, 149);
            this.labelOldCurrency.Name = "labelOldCurrency";
            this.labelOldCurrency.Size = new System.Drawing.Size(35, 13);
            this.labelOldCurrency.TabIndex = 8;
            this.labelOldCurrency.Text = "label5";
            this.labelOldCurrency.Visible = false;
            // 
            // labelNewCurrency
            // 
            this.labelNewCurrency.AutoSize = true;
            this.labelNewCurrency.Location = new System.Drawing.Point(279, 145);
            this.labelNewCurrency.Name = "labelNewCurrency";
            this.labelNewCurrency.Size = new System.Drawing.Size(35, 13);
            this.labelNewCurrency.TabIndex = 9;
            this.labelNewCurrency.Text = "label6";
            this.labelNewCurrency.Visible = false;
            // 
            // textBoxCurrentAmount
            // 
            this.textBoxCurrentAmount.Enabled = false;
            this.textBoxCurrentAmount.Location = new System.Drawing.Point(57, 141);
            this.textBoxCurrentAmount.Name = "textBoxCurrentAmount";
            this.textBoxCurrentAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentAmount.TabIndex = 10;
            this.textBoxCurrentAmount.TextChanged += new System.EventHandler(this.textBoxCurrentAmount_TextChanged);
            // 
            // textBoxConverted
            // 
            this.textBoxConverted.Enabled = false;
            this.textBoxConverted.Location = new System.Drawing.Point(320, 145);
            this.textBoxConverted.Name = "textBoxConverted";
            this.textBoxConverted.Size = new System.Drawing.Size(100, 20);
            this.textBoxConverted.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 356);
            this.Controls.Add(this.textBoxConverted);
            this.Controls.Add(this.textBoxCurrentAmount);
            this.Controls.Add(this.labelNewCurrency);
            this.Controls.Add(this.labelOldCurrency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCurrencyNew);
            this.Controls.Add(this.comboBoxCurrencyOld);
            this.Controls.Add(this.groupBoxReset);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxReset.ResumeLayout(false);
            this.groupBoxReset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBoxReset;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.ComboBox comboBoxCurrencyOld;
        private System.Windows.Forms.ComboBox comboBoxCurrencyNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOldCurrency;
        private System.Windows.Forms.Label labelNewCurrency;
        private System.Windows.Forms.TextBox textBoxCurrentAmount;
        private System.Windows.Forms.TextBox textBoxConverted;
    }
}

