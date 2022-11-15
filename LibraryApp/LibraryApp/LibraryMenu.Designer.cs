
namespace LibraryApp
{
    partial class LibraryMenu
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
            this.BtnReplaceBooks = new System.Windows.Forms.Button();
            this.BtnIdentifyAreas = new System.Windows.Forms.Button();
            this.BtnCallNumbers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDisabledIA = new System.Windows.Forms.Label();
            this.txtDisabledFCN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnReplaceBooks
            // 
            this.BtnReplaceBooks.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReplaceBooks.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReplaceBooks.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnReplaceBooks.Location = new System.Drawing.Point(216, 132);
            this.BtnReplaceBooks.Name = "BtnReplaceBooks";
            this.BtnReplaceBooks.Size = new System.Drawing.Size(249, 52);
            this.BtnReplaceBooks.TabIndex = 0;
            this.BtnReplaceBooks.Text = "Replacing Books";
            this.BtnReplaceBooks.UseVisualStyleBackColor = false;
            this.BtnReplaceBooks.Click += new System.EventHandler(this.BtnReplaceBooks_Click);
            // 
            // BtnIdentifyAreas
            // 
            this.BtnIdentifyAreas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnIdentifyAreas.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIdentifyAreas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnIdentifyAreas.Location = new System.Drawing.Point(216, 218);
            this.BtnIdentifyAreas.Name = "BtnIdentifyAreas";
            this.BtnIdentifyAreas.Size = new System.Drawing.Size(249, 52);
            this.BtnIdentifyAreas.TabIndex = 1;
            this.BtnIdentifyAreas.Text = "Identifying Areas";
            this.BtnIdentifyAreas.UseVisualStyleBackColor = false;
            this.BtnIdentifyAreas.Click += new System.EventHandler(this.BtnIdentifyAreas_Click);
            // 
            // BtnCallNumbers
            // 
            this.BtnCallNumbers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCallNumbers.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCallNumbers.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnCallNumbers.Location = new System.Drawing.Point(216, 313);
            this.BtnCallNumbers.Name = "BtnCallNumbers";
            this.BtnCallNumbers.Size = new System.Drawing.Size(249, 80);
            this.BtnCallNumbers.TabIndex = 2;
            this.BtnCallNumbers.Text = "Finding Call Numbers";
            this.BtnCallNumbers.UseVisualStyleBackColor = false;
            this.BtnCallNumbers.Click += new System.EventHandler(this.BtnCallNumbers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Library Menu";
            // 
            // txtDisabledIA
            // 
            this.txtDisabledIA.AutoSize = true;
            this.txtDisabledIA.Enabled = false;
            this.txtDisabledIA.ForeColor = System.Drawing.Color.Red;
            this.txtDisabledIA.Location = new System.Drawing.Point(249, 273);
            this.txtDisabledIA.Name = "txtDisabledIA";
            this.txtDisabledIA.Size = new System.Drawing.Size(0, 23);
            this.txtDisabledIA.TabIndex = 4;
            // 
            // txtDisabledFCN
            // 
            this.txtDisabledFCN.AutoSize = true;
            this.txtDisabledFCN.Enabled = false;
            this.txtDisabledFCN.ForeColor = System.Drawing.Color.Red;
            this.txtDisabledFCN.Location = new System.Drawing.Point(249, 396);
            this.txtDisabledFCN.Name = "txtDisabledFCN";
            this.txtDisabledFCN.Size = new System.Drawing.Size(0, 23);
            this.txtDisabledFCN.TabIndex = 5;
            // 
            // LibraryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 461);
            this.Controls.Add(this.txtDisabledFCN);
            this.Controls.Add(this.txtDisabledIA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCallNumbers);
            this.Controls.Add(this.BtnIdentifyAreas);
            this.Controls.Add(this.BtnReplaceBooks);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LibraryMenu";
            this.Text = "LibraryMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReplaceBooks;
        private System.Windows.Forms.Button BtnIdentifyAreas;
        private System.Windows.Forms.Button BtnCallNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtDisabledIA;
        private System.Windows.Forms.Label txtDisabledFCN;
    }
}

