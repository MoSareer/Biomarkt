namespace Biomarkt_GmbH
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            this.btnProdukt = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProdukt
            // 
            this.btnProdukt.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdukt.ForeColor = System.Drawing.Color.White;
            this.btnProdukt.Image = ((System.Drawing.Image)(resources.GetObject("btnProdukt.Image")));
            this.btnProdukt.Location = new System.Drawing.Point(12, 36);
            this.btnProdukt.Name = "btnProdukt";
            this.btnProdukt.Size = new System.Drawing.Size(275, 125);
            this.btnProdukt.TabIndex = 0;
            this.btnProdukt.Text = "Produkte verwalten";
            this.btnProdukt.UseVisualStyleBackColor = true;
            this.btnProdukt.Click += new System.EventHandler(this.btnProdukt_Click);
            // 
            // btnBill
            // 
            this.btnBill.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.Location = new System.Drawing.Point(371, 36);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(275, 125);
            this.btnBill.TabIndex = 1;
            this.btnBill.Text = "Rechnung erstellen";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(697, 230);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnProdukt);
            this.Name = "MainMenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hauptmenü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdukt;
        private System.Windows.Forms.Button btnBill;
    }
}