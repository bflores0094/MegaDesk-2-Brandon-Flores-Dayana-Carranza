namespace MegaDesk
{
    partial class SearchQuotes
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
            this.SuspendLayout();
            // 
            // viewBack
            // 
            this.viewBack.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBack.Location = new System.Drawing.Point(303, 346);
            this.viewBack.Name = "viewBack";
            this.viewBack.Size = new System.Drawing.Size(200, 50);
            this.viewBack.TabIndex = 1;
            this.viewBack.Text = "Back";
            this.viewBack.UseVisualStyleBackColor = true;
            this.viewBack.Click += new System.EventHandler(this.viewBack_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewBack);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewBack;
    }
}