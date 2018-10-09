namespace MegaDesk
{
    partial class DisplayQuote
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
            this.viewBack = new System.Windows.Forms.Button();
            this.label1Quote = new System.Windows.Forms.Label();
            this.finalQuote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewBack
            // 
            this.viewBack.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBack.Location = new System.Drawing.Point(300, 352);
            this.viewBack.Name = "viewBack";
            this.viewBack.Size = new System.Drawing.Size(200, 50);
            this.viewBack.TabIndex = 1;
            this.viewBack.Text = "Back";
            this.viewBack.UseVisualStyleBackColor = true;
            this.viewBack.Click += new System.EventHandler(this.viewBack_Click);
            // 
            // label1Quote
            // 
            this.label1Quote.AutoSize = true;
            this.label1Quote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Quote.Location = new System.Drawing.Point(253, 123);
            this.label1Quote.Name = "label1Quote";
            this.label1Quote.Size = new System.Drawing.Size(160, 31);
            this.label1Quote.TabIndex = 2;
            this.label1Quote.Text = "Your Quote:";
            // 
            // finalQuote
            // 
            this.finalQuote.AutoSize = true;
            this.finalQuote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalQuote.Location = new System.Drawing.Point(419, 123);
            this.finalQuote.Name = "finalQuote";
            this.finalQuote.Size = new System.Drawing.Size(84, 33);
            this.finalQuote.TabIndex = 3;
            this.finalQuote.Text = "$0.00";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalQuote);
            this.Controls.Add(this.label1Quote);
            this.Controls.Add(this.viewBack);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewBack;
        private System.Windows.Forms.Label label1Quote;
        private System.Windows.Forms.Label finalQuote;
    }
}