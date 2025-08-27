namespace QueuingForm
{
    partial class Queui
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
            this.bntCashier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntCashier
            // 
            this.bntCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCashier.Location = new System.Drawing.Point(90, 130);
            this.bntCashier.Name = "bntCashier";
            this.bntCashier.Size = new System.Drawing.Size(170, 152);
            this.bntCashier.TabIndex = 0;
            this.bntCashier.Text = "Cashier";
            this.bntCashier.UseVisualStyleBackColor = true;
            this.bntCashier.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(329, 189);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(310, 73);
            this.lblQueue.TabIndex = 2;
            this.lblQueue.Text = "P - 10001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(97, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "*Click to get a number";
            // 
            // Queui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntCashier);
            this.Name = "Queui";
            this.Text = "QueuingForm";
            this.Load += new System.EventHandler(this.Queui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCashier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label label3;
    }
}

