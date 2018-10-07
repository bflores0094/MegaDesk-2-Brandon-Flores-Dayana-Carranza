namespace MegaDesk
{
    partial class AddQuote
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
            this.Back = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.QuoteLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.ft = new System.Windows.Forms.Label();
            this.ft2 = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(168, 369);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(200, 50);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(450, 369);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(200, 50);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // QuoteLabel
            // 
            this.QuoteLabel.AutoSize = true;
            this.QuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteLabel.Location = new System.Drawing.Point(400, 121);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(0, 39);
            this.QuoteLabel.TabIndex = 3;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(165, 100);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(91, 31);
            this.WidthLabel.TabIndex = 4;
            this.WidthLabel.Text = "Width:";
            // 
            // WidthInput
            // 
            this.WidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthInput.Location = new System.Drawing.Point(262, 107);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(46, 26);
            this.WidthInput.TabIndex = 5;
            this.WidthInput.Text = "24 ";
            // 
            // ft
            // 
            this.ft.AutoSize = true;
            this.ft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ft.Location = new System.Drawing.Point(314, 115);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(20, 17);
            this.ft.TabIndex = 7;
            this.ft.Text = "Ft";
            // 
            // ft2
            // 
            this.ft2.AutoSize = true;
            this.ft2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ft2.Location = new System.Drawing.Point(314, 159);
            this.ft2.Name = "ft2";
            this.ft2.Size = new System.Drawing.Size(20, 17);
            this.ft2.TabIndex = 10;
            this.ft2.Text = "Ft";
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInput.Location = new System.Drawing.Point(262, 151);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(46, 26);
            this.HeightInput.TabIndex = 9;
            this.HeightInput.Text = "24 ";
            this.HeightInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Height:";
            // 
            // ValError
            // 
            this.ValError.AutoSize = true;
            this.ValError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValError.ForeColor = System.Drawing.Color.Red;
            this.ValError.Location = new System.Drawing.Point(313, 19);
            this.ValError.Name = "ValError";
            this.ValError.Size = new System.Drawing.Size(0, 20);
            this.ValError.TabIndex = 11;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValError);
            this.Controls.Add(this.ft2);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ft);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.QuoteLabel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label QuoteLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.Label ft;
        private System.Windows.Forms.Label ft2;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ValError;
    }
}