namespace MegaDesk

{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddQuote = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SearchQuote = new System.Windows.Forms.Button();
            this.ViewQuote = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuote
            // 
            this.AddQuote.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuote.Location = new System.Drawing.Point(80, 67);
            this.AddQuote.Name = "AddQuote";
            this.AddQuote.Size = new System.Drawing.Size(200, 50);
            this.AddQuote.TabIndex = 0;
            this.AddQuote.Text = "Add New Quote";
            this.AddQuote.UseVisualStyleBackColor = true;
            this.AddQuote.Click += new System.EventHandler(this.AddQuote_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(80, 344);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(200, 50);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SearchQuote
            // 
            this.SearchQuote.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuote.Location = new System.Drawing.Point(80, 251);
            this.SearchQuote.Name = "SearchQuote";
            this.SearchQuote.Size = new System.Drawing.Size(200, 50);
            this.SearchQuote.TabIndex = 2;
            this.SearchQuote.Text = "Search Quotes";
            this.SearchQuote.UseVisualStyleBackColor = true;
            this.SearchQuote.Click += new System.EventHandler(this.SearchQuote_Click);
            // 
            // ViewQuote
            // 
            this.ViewQuote.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuote.Location = new System.Drawing.Point(80, 159);
            this.ViewQuote.Name = "ViewQuote";
            this.ViewQuote.Size = new System.Drawing.Size(200, 50);
            this.ViewQuote.TabIndex = 3;
            this.ViewQuote.Text = "View Quote";
            this.ViewQuote.UseVisualStyleBackColor = true;
            this.ViewQuote.Click += new System.EventHandler(this.ViewQuote_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(346, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewQuote);
            this.Controls.Add(this.SearchQuote);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddQuote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Mega Desk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddQuote;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SearchQuote;
        private System.Windows.Forms.Button ViewQuote;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

