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
            this.ft = new System.Windows.Forms.Label();
            this.ft2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValError = new System.Windows.Forms.Label();
            this.WidthInput = new System.Windows.Forms.NumericUpDown();
            this.HeightInput = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaterialInput = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.WidthLabel.Location = new System.Drawing.Point(100, 165);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(91, 31);
            this.WidthLabel.TabIndex = 4;
            this.WidthLabel.Text = "Width:";
            // 
            // ft
            // 
            this.ft.AutoSize = true;
            this.ft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ft.Location = new System.Drawing.Point(319, 179);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(20, 17);
            this.ft.TabIndex = 7;
            this.ft.Text = "Ft";
            // 
            // ft2
            // 
            this.ft2.AutoSize = true;
            this.ft2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ft2.Location = new System.Drawing.Point(319, 224);
            this.ft2.Name = "ft2";
            this.ft2.Size = new System.Drawing.Size(20, 17);
            this.ft2.TabIndex = 10;
            this.ft2.Text = "Ft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 210);
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
            // WidthInput
            // 
            this.WidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthInput.Location = new System.Drawing.Point(193, 173);
            this.WidthInput.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.WidthInput.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(120, 26);
            this.WidthInput.TabIndex = 12;
            this.WidthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInput.Location = new System.Drawing.Point(193, 215);
            this.HeightInput.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.HeightInput.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(120, 26);
            this.HeightInput.TabIndex = 13;
            this.HeightInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(186, 79);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(117, 39);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Name:";
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(339, 88);
            this.NameInput.MaxLength = 50;
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(240, 30);
            this.NameInput.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Material:";
            // 
            // MaterialInput
            // 
            this.MaterialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialInput.FormattingEnabled = true;
            this.MaterialInput.Items.AddRange(new object[] {
            "oak",
            "laminate",
            "pine",
            "rosewood",
            "veneer"});
            this.MaterialInput.Location = new System.Drawing.Point(585, 173);
            this.MaterialInput.Name = "MaterialInput";
            this.MaterialInput.Size = new System.Drawing.Size(121, 28);
            this.MaterialInput.TabIndex = 17;
            this.MaterialInput.Text = "oak";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(585, 220);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Drawers:";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaterialInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.ValError);
            this.Controls.Add(this.ft2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ft);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.QuoteLabel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label QuoteLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label ft;
        private System.Windows.Forms.Label ft2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ValError;
        private System.Windows.Forms.NumericUpDown WidthInput;
        private System.Windows.Forms.NumericUpDown HeightInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MaterialInput;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
    }
}