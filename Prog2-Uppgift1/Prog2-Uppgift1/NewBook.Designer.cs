namespace Prog2_Uppgift1
{
    partial class NewBook
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.lblRelease = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtBoxGenre = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPages = new System.Windows.Forms.NumericUpDown();
            this.chkBoxPics = new System.Windows.Forms.CheckBox();
            this.dateTimePickerRelease = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtBoxPublisher = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(23, 88);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(97, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Titel";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(226, 88);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(226, 35);
            this.txtBoxTitle.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(23, 141);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(182, 25);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Författare";
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(226, 141);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(226, 35);
            this.txtBoxAuthor.TabIndex = 3;
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Location = new System.Drawing.Point(23, 196);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(182, 25);
            this.lblRelease.TabIndex = 4;
            this.lblRelease.Text = "Släppdatum";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(23, 252);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(97, 25);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre";
            // 
            // txtBoxGenre
            // 
            this.txtBoxGenre.Location = new System.Drawing.Point(226, 249);
            this.txtBoxGenre.Name = "txtBoxGenre";
            this.txtBoxGenre.Size = new System.Drawing.Size(226, 35);
            this.txtBoxGenre.TabIndex = 7;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(478, 142);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(97, 25);
            this.lblPages.TabIndex = 8;
            this.lblPages.Text = "Sidor";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(23, 309);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 25);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Pris";
            // 
            // numUpDownPrice
            // 
            this.numUpDownPrice.Location = new System.Drawing.Point(226, 307);
            this.numUpDownPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDownPrice.Name = "numUpDownPrice";
            this.numUpDownPrice.Size = new System.Drawing.Size(226, 35);
            this.numUpDownPrice.TabIndex = 11;
            // 
            // numUpDownPages
            // 
            this.numUpDownPages.Location = new System.Drawing.Point(649, 140);
            this.numUpDownPages.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownPages.Name = "numUpDownPages";
            this.numUpDownPages.Size = new System.Drawing.Size(226, 35);
            this.numUpDownPages.TabIndex = 12;
            // 
            // chkBoxPics
            // 
            this.chkBoxPics.AutoSize = true;
            this.chkBoxPics.Location = new System.Drawing.Point(478, 192);
            this.chkBoxPics.Name = "chkBoxPics";
            this.chkBoxPics.Size = new System.Drawing.Size(204, 29);
            this.chkBoxPics.TabIndex = 13;
            this.chkBoxPics.Text = "Har bilder";
            this.chkBoxPics.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerRelease
            // 
            this.dateTimePickerRelease.Location = new System.Drawing.Point(226, 196);
            this.dateTimePickerRelease.Name = "dateTimePickerRelease";
            this.dateTimePickerRelease.Size = new System.Drawing.Size(226, 35);
            this.dateTimePickerRelease.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(701, 309);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(186, 85);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(480, 88);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(165, 25);
            this.lblPublisher.TabIndex = 17;
            this.lblPublisher.Text = "Bokförlag";
            // 
            // txtBoxPublisher
            // 
            this.txtBoxPublisher.Location = new System.Drawing.Point(649, 88);
            this.txtBoxPublisher.Name = "txtBoxPublisher";
            this.txtBoxPublisher.Size = new System.Drawing.Size(226, 35);
            this.txtBoxPublisher.TabIndex = 18;
            // 
            // NewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(921, 429);
            this.Controls.Add(this.txtBoxPublisher);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateTimePickerRelease);
            this.Controls.Add(this.chkBoxPics);
            this.Controls.Add(this.numUpDownPages);
            this.Controls.Add(this.numUpDownPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.txtBoxGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblRelease);
            this.Controls.Add(this.txtBoxAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("OCR A Std", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "NewBook";
            this.Text = "Media App";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtBoxGenre;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numUpDownPrice;
        private System.Windows.Forms.NumericUpDown numUpDownPages;
        private System.Windows.Forms.CheckBox chkBoxPics;
        private System.Windows.Forms.DateTimePicker dateTimePickerRelease;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtBoxPublisher;
    }
}