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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.filterLabel = new System.Windows.Forms.Label();
            this.matBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // viewBack
            // 
            this.viewBack.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBack.Location = new System.Drawing.Point(304, 388);
            this.viewBack.Name = "viewBack";
            this.viewBack.Size = new System.Drawing.Size(200, 50);
            this.viewBack.TabIndex = 1;
            this.viewBack.Text = "Back";
            this.viewBack.UseVisualStyleBackColor = true;
            this.viewBack.Click += new System.EventHandler(this.viewBack_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(78, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 305);
            this.dataGridView2.TabIndex = 2;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Location = new System.Drawing.Point(111, 22);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(147, 29);
            this.filterLabel.TabIndex = 3;
            this.filterLabel.Text = "Filter by Material:";
            // 
            // matBox
            // 
            this.matBox.FormattingEnabled = true;
            this.matBox.Location = new System.Drawing.Point(264, 25);
            this.matBox.Name = "matBox";
            this.matBox.Size = new System.Drawing.Size(121, 21);
            this.matBox.TabIndex = 4;
            this.matBox.SelectedIndexChanged += new System.EventHandler(this.FilterMat);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.matBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.viewBack);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewBack;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox matBox;
    }
}