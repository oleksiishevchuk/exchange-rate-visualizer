namespace ExchangeRateVisualizer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUsdPurchase = new System.Windows.Forms.Label();
            this.lblUsdSell = new System.Windows.Forms.Label();
            this.lblEurSell = new System.Windows.Forms.Label();
            this.lblEurPurchase = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "USD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "EUR";
            // 
            // lblUsdPurchase
            // 
            this.lblUsdPurchase.AutoSize = true;
            this.lblUsdPurchase.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsdPurchase.Location = new System.Drawing.Point(100, 41);
            this.lblUsdPurchase.Name = "lblUsdPurchase";
            this.lblUsdPurchase.Size = new System.Drawing.Size(51, 21);
            this.lblUsdPurchase.TabIndex = 4;
            this.lblUsdPurchase.Text = "26.18";
            // 
            // lblUsdSell
            // 
            this.lblUsdSell.AutoSize = true;
            this.lblUsdSell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsdSell.Location = new System.Drawing.Point(100, 69);
            this.lblUsdSell.Name = "lblUsdSell";
            this.lblUsdSell.Size = new System.Drawing.Size(51, 21);
            this.lblUsdSell.TabIndex = 5;
            this.lblUsdSell.Text = "26.28";
            // 
            // lblEurSell
            // 
            this.lblEurSell.AutoSize = true;
            this.lblEurSell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEurSell.Location = new System.Drawing.Point(186, 69);
            this.lblEurSell.Name = "lblEurSell";
            this.lblEurSell.Size = new System.Drawing.Size(51, 21);
            this.lblEurSell.TabIndex = 7;
            this.lblEurSell.Text = "26.28";
            // 
            // lblEurPurchase
            // 
            this.lblEurPurchase.AutoSize = true;
            this.lblEurPurchase.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEurPurchase.Location = new System.Drawing.Point(186, 41);
            this.lblEurPurchase.Name = "lblEurPurchase";
            this.lblEurPurchase.Size = new System.Drawing.Size(51, 21);
            this.lblEurPurchase.TabIndex = 6;
            this.lblEurPurchase.Text = "26.18";
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 110);
            this.Controls.Add(this.lblEurSell);
            this.Controls.Add(this.lblEurPurchase);
            this.Controls.Add(this.lblUsdSell);
            this.Controls.Add(this.lblUsdPurchase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ExchangeRateVisualizer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsdPurchase;
        private System.Windows.Forms.Label lblUsdSell;
        private System.Windows.Forms.Label lblEurSell;
        private System.Windows.Forms.Label lblEurPurchase;
        private System.Windows.Forms.NotifyIcon trayIcon;
    }
}

