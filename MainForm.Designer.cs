namespace СurrencyConverter
{
    partial class MainForm
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
            this.fromDate = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.export = new System.Windows.Forms.Button();
            this.showRates = new System.Windows.Forms.Button();
            this.toDate = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.convertDate = new System.Windows.Forms.ComboBox();
            this.convertTo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currencyB = new System.Windows.Forms.ComboBox();
            this.currencyA = new System.Windows.Forms.ComboBox();
            this.countB = new System.Windows.Forms.TextBox();
            this.countA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputFormat = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromDate
            // 
            this.fromDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromDate.FormattingEnabled = true;
            this.fromDate.Location = new System.Drawing.Point(84, 63);
            this.fromDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(104, 24);
            this.fromDate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.currency);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.export);
            this.panel1.Controls.Add(this.showRates);
            this.panel1.Controls.Add(this.toDate);
            this.panel1.Controls.Add(this.fromDate);
            this.panel1.Location = new System.Drawing.Point(31, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 329);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "to";
            // 
            // currency
            // 
            this.currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currency.FormattingEnabled = true;
            this.currency.Location = new System.Drawing.Point(183, 108);
            this.currency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(79, 24);
            this.currency.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose currency:";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(31, 257);
            this.export.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(339, 52);
            this.export.TabIndex = 3;
            this.export.Text = "Export to CSV-file";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // showRates
            // 
            this.showRates.Location = new System.Drawing.Point(31, 175);
            this.showRates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showRates.Name = "showRates";
            this.showRates.Size = new System.Drawing.Size(340, 50);
            this.showRates.TabIndex = 2;
            this.showRates.Text = "Show rates";
            this.showRates.UseVisualStyleBackColor = true;
            this.showRates.Click += new System.EventHandler(this.showRates_Click);
            // 
            // toDate
            // 
            this.toDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toDate.FormattingEnabled = true;
            this.toDate.Location = new System.Drawing.Point(267, 63);
            this.toDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(103, 24);
            this.toDate.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.inputFormat);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.convertDate);
            this.panel2.Controls.Add(this.convertTo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.currencyB);
            this.panel2.Controls.Add(this.currencyA);
            this.panel2.Controls.Add(this.countB);
            this.panel2.Controls.Add(this.countA);
            this.panel2.Location = new System.Drawing.Point(31, 352);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 289);
            this.panel2.TabIndex = 2;
            // 
            // convertDate
            // 
            this.convertDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.convertDate.FormattingEnabled = true;
            this.convertDate.Location = new System.Drawing.Point(180, 32);
            this.convertDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convertDate.Name = "convertDate";
            this.convertDate.Size = new System.Drawing.Size(143, 24);
            this.convertDate.TabIndex = 7;
            // 
            // convertTo
            // 
            this.convertTo.Location = new System.Drawing.Point(125, 158);
            this.convertTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convertTo.Name = "convertTo";
            this.convertTo.Size = new System.Drawing.Size(137, 30);
            this.convertTo.TabIndex = 6;
            this.convertTo.Text = "Convert to";
            this.convertTo.UseVisualStyleBackColor = true;
            this.convertTo.Click += new System.EventHandler(this.convertTo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Convert currency";
            // 
            // currencyB
            // 
            this.currencyB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyB.FormattingEnabled = true;
            this.currencyB.Location = new System.Drawing.Point(244, 200);
            this.currencyB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currencyB.Name = "currencyB";
            this.currencyB.Size = new System.Drawing.Size(79, 24);
            this.currencyB.TabIndex = 3;
            // 
            // currencyA
            // 
            this.currencyA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyA.FormattingEnabled = true;
            this.currencyA.Location = new System.Drawing.Point(244, 125);
            this.currencyA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currencyA.Name = "currencyA";
            this.currencyA.Size = new System.Drawing.Size(79, 24);
            this.currencyA.TabIndex = 2;
            // 
            // countB
            // 
            this.countB.BackColor = System.Drawing.SystemColors.Window;
            this.countB.Location = new System.Drawing.Point(33, 201);
            this.countB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countB.Name = "countB";
            this.countB.ReadOnly = true;
            this.countB.Size = new System.Drawing.Size(163, 22);
            this.countB.TabIndex = 1;
            // 
            // countA
            // 
            this.countA.Location = new System.Drawing.Point(33, 125);
            this.countA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countA.Name = "countA";
            this.countA.Size = new System.Drawing.Size(163, 22);
            this.countA.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "The input format";
            // 
            // inputFormat
            // 
            this.inputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputFormat.FormattingEnabled = true;
            this.inputFormat.Items.AddRange(new object[] {
            "100.00",
            "100,00"});
            this.inputFormat.Location = new System.Drawing.Point(180, 70);
            this.inputFormat.Margin = new System.Windows.Forms.Padding(4);
            this.inputFormat.Name = "inputFormat";
            this.inputFormat.Size = new System.Drawing.Size(143, 24);
            this.inputFormat.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(476, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Currency converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox fromDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button showRates;
        private System.Windows.Forms.ComboBox toDate;
        private System.Windows.Forms.ComboBox currency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox currencyB;
        private System.Windows.Forms.ComboBox currencyA;
        private System.Windows.Forms.TextBox countB;
        private System.Windows.Forms.TextBox countA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button convertTo;
        private System.Windows.Forms.ComboBox convertDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inputFormat;
        private System.Windows.Forms.Label label6;

    }
}

