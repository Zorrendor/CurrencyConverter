namespace СurrencyConverter
{
    partial class RatesForm
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
            this.dataRates = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataRates)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRates
            // 
            this.dataRates.AllowUserToAddRows = false;
            this.dataRates.AllowUserToDeleteRows = false;
            this.dataRates.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRates.Location = new System.Drawing.Point(12, 12);
            this.dataRates.Name = "dataRates";
            this.dataRates.ReadOnly = true;
            this.dataRates.Size = new System.Drawing.Size(827, 407);
            this.dataRates.TabIndex = 1;
            // 
            // Rates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(854, 432);
            this.Controls.Add(this.dataRates);
            this.Name = "Rates";
            this.Text = "Rates";
            this.Load += new System.EventHandler(this.Rates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataRates;


    }
}