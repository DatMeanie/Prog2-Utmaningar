namespace P2_U2_AlbinFyhr_TE16
{
    partial class Form1
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxNote = new System.Windows.Forms.TextBox();
            this.lstBoxShow = new System.Windows.Forms.ListBox();
            this.title = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxAddNote = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxAddTitle = new System.Windows.Forms.TextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExplorer = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnUpdateBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(434, 550);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 32);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.Location = new System.Drawing.Point(874, 180);
            this.txtBoxNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNote.Multiline = true;
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.ReadOnly = true;
            this.txtBoxNote.Size = new System.Drawing.Size(393, 338);
            this.txtBoxNote.TabIndex = 13;
            this.txtBoxNote.Text = "Template";
            // 
            // lstBoxShow
            // 
            this.lstBoxShow.FormattingEnabled = true;
            this.lstBoxShow.ItemHeight = 22;
            this.lstBoxShow.Location = new System.Drawing.Point(417, 118);
            this.lstBoxShow.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxShow.Name = "lstBoxShow";
            this.lstBoxShow.Size = new System.Drawing.Size(433, 400);
            this.lstBoxShow.TabIndex = 12;
            this.lstBoxShow.SelectedIndexChanged += new System.EventHandler(this.lstBoxShow_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(-194, 38);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(141, 36);
            this.title.TabIndex = 10;
            this.title.Text = "Note App";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 550);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxAddNote
            // 
            this.txtBoxAddNote.Location = new System.Drawing.Point(15, 180);
            this.txtBoxAddNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAddNote.Multiline = true;
            this.txtBoxAddNote.Name = "txtBoxAddNote";
            this.txtBoxAddNote.Size = new System.Drawing.Size(382, 345);
            this.txtBoxAddNote.TabIndex = 8;
            this.txtBoxAddNote.Text = "Write your note";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 43);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 38);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Note App";
            // 
            // txtBoxAddTitle
            // 
            this.txtBoxAddTitle.Location = new System.Drawing.Point(15, 118);
            this.txtBoxAddTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAddTitle.Multiline = true;
            this.txtBoxAddTitle.Name = "txtBoxAddTitle";
            this.txtBoxAddTitle.Size = new System.Drawing.Size(382, 52);
            this.txtBoxAddTitle.TabIndex = 16;
            this.txtBoxAddTitle.Text = "Write your title";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(874, 118);
            this.txtBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTitle.Multiline = true;
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.ReadOnly = true;
            this.txtBoxTitle.Size = new System.Drawing.Size(393, 52);
            this.txtBoxTitle.TabIndex = 17;
            this.txtBoxTitle.Text = "Template";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(632, 550);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(190, 32);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExplorer
            // 
            this.btnExplorer.Location = new System.Drawing.Point(434, 591);
            this.btnExplorer.Margin = new System.Windows.Forms.Padding(4);
            this.btnExplorer.Name = "btnExplorer";
            this.btnExplorer.Size = new System.Drawing.Size(190, 33);
            this.btnExplorer.TabIndex = 19;
            this.btnExplorer.Text = "Open in Explorer";
            this.btnExplorer.UseVisualStyleBackColor = true;
            this.btnExplorer.Click += new System.EventHandler(this.btnExplorer_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(98, 591);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(172, 32);
            this.btnTransfer.TabIndex = 20;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnUpdateBox
            // 
            this.btnUpdateBox.Location = new System.Drawing.Point(632, 591);
            this.btnUpdateBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateBox.Name = "btnUpdateBox";
            this.btnUpdateBox.Size = new System.Drawing.Size(190, 33);
            this.btnUpdateBox.TabIndex = 21;
            this.btnUpdateBox.Text = "Update Box";
            this.btnUpdateBox.UseVisualStyleBackColor = true;
            this.btnUpdateBox.Click += new System.EventHandler(this.btnUpdateBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 667);
            this.Controls.Add(this.btnUpdateBox);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnExplorer);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.txtBoxAddTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBoxNote);
            this.Controls.Add(this.lstBoxShow);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxAddNote);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBoxNote;
        private System.Windows.Forms.ListBox lstBoxShow;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxAddNote;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxAddTitle;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExplorer;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnUpdateBox;
    }
}

