namespace Prog2_Uppgift1
{
    partial class NewVideoGame
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
            this.txtBoxEngine = new System.Windows.Forms.TextBox();
            this.lblGameEngine = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dateTimePickerRelease = new System.Windows.Forms.DateTimePicker();
            this.numUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRelease = new System.Windows.Forms.Label();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxEngine
            // 
            this.txtBoxEngine.Location = new System.Drawing.Point(654, 61);
            this.txtBoxEngine.Name = "txtBoxEngine";
            this.txtBoxEngine.Size = new System.Drawing.Size(226, 35);
            this.txtBoxEngine.TabIndex = 63;
            // 
            // lblGameEngine
            // 
            this.lblGameEngine.AutoSize = true;
            this.lblGameEngine.Location = new System.Drawing.Point(485, 61);
            this.lblGameEngine.Name = "lblGameEngine";
            this.lblGameEngine.Size = new System.Drawing.Size(165, 25);
            this.lblGameEngine.TabIndex = 62;
            this.lblGameEngine.Text = "Spelmotor";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(706, 282);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(186, 85);
            this.btnSubmit.TabIndex = 61;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dateTimePickerRelease
            // 
            this.dateTimePickerRelease.Location = new System.Drawing.Point(231, 169);
            this.dateTimePickerRelease.Name = "dateTimePickerRelease";
            this.dateTimePickerRelease.Size = new System.Drawing.Size(226, 35);
            this.dateTimePickerRelease.TabIndex = 60;
            // 
            // numUpDownPrice
            // 
            this.numUpDownPrice.Location = new System.Drawing.Point(231, 280);
            this.numUpDownPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDownPrice.Name = "numUpDownPrice";
            this.numUpDownPrice.Size = new System.Drawing.Size(226, 35);
            this.numUpDownPrice.TabIndex = 59;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(28, 282);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 25);
            this.lblPrice.TabIndex = 58;
            this.lblPrice.Text = "Pris";
            // 
            // txtBoxGenre
            // 
            this.txtBoxGenre.Location = new System.Drawing.Point(231, 222);
            this.txtBoxGenre.Name = "txtBoxGenre";
            this.txtBoxGenre.Size = new System.Drawing.Size(226, 35);
            this.txtBoxGenre.TabIndex = 57;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(28, 225);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(97, 25);
            this.lblGenre.TabIndex = 56;
            this.lblGenre.Text = "Genre";
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Location = new System.Drawing.Point(28, 169);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(182, 25);
            this.lblRelease.TabIndex = 55;
            this.lblRelease.Text = "Släppdatum";
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(231, 114);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(226, 35);
            this.txtBoxAuthor.TabIndex = 54;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(28, 114);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(131, 25);
            this.lblAuthor.TabIndex = 53;
            this.lblAuthor.Text = "Skapare";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(231, 61);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(226, 35);
            this.txtBoxTitle.TabIndex = 52;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(28, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 25);
            this.lblTitle.TabIndex = 51;
            this.lblTitle.Text = "Namn";
            // 
            // NewVideoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(921, 429);
            this.Controls.Add(this.txtBoxEngine);
            this.Controls.Add(this.lblGameEngine);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateTimePickerRelease);
            this.Controls.Add(this.numUpDownPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtBoxGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblRelease);
            this.Controls.Add(this.txtBoxAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("OCR A Std", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "NewVideoGame";
            this.Text = "Media App";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxEngine;
        private System.Windows.Forms.Label lblGameEngine;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dateTimePickerRelease;
        private System.Windows.Forms.NumericUpDown numUpDownPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBoxGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}