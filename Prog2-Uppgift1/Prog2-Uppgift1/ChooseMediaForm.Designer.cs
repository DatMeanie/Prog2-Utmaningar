namespace Prog2_Uppgift1
{
    partial class ChooseMediaForm
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
            this.radBtnBook = new System.Windows.Forms.RadioButton();
            this.radBtnNewsArticle = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radBtnWebsite = new System.Windows.Forms.RadioButton();
            this.radBtnGame = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radBtnBook
            // 
            this.radBtnBook.AutoSize = true;
            this.radBtnBook.Location = new System.Drawing.Point(102, 87);
            this.radBtnBook.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.radBtnBook.Name = "radBtnBook";
            this.radBtnBook.Size = new System.Drawing.Size(101, 29);
            this.radBtnBook.TabIndex = 0;
            this.radBtnBook.Text = "Book";
            this.radBtnBook.UseVisualStyleBackColor = true;
            // 
            // radBtnNewsArticle
            // 
            this.radBtnNewsArticle.AutoSize = true;
            this.radBtnNewsArticle.Location = new System.Drawing.Point(102, 127);
            this.radBtnNewsArticle.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.radBtnNewsArticle.Name = "radBtnNewsArticle";
            this.radBtnNewsArticle.Size = new System.Drawing.Size(237, 29);
            this.radBtnNewsArticle.TabIndex = 1;
            this.radBtnNewsArticle.TabStop = true;
            this.radBtnNewsArticle.Text = "News Article";
            this.radBtnNewsArticle.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radBtnWebsite
            // 
            this.radBtnWebsite.AutoSize = true;
            this.radBtnWebsite.Location = new System.Drawing.Point(102, 201);
            this.radBtnWebsite.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.radBtnWebsite.Name = "radBtnWebsite";
            this.radBtnWebsite.Size = new System.Drawing.Size(152, 29);
            this.radBtnWebsite.TabIndex = 3;
            this.radBtnWebsite.TabStop = true;
            this.radBtnWebsite.Text = "Website";
            this.radBtnWebsite.UseVisualStyleBackColor = true;
            // 
            // radBtnGame
            // 
            this.radBtnGame.AutoSize = true;
            this.radBtnGame.Location = new System.Drawing.Point(102, 164);
            this.radBtnGame.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.radBtnGame.Name = "radBtnGame";
            this.radBtnGame.Size = new System.Drawing.Size(203, 29);
            this.radBtnGame.TabIndex = 4;
            this.radBtnGame.Text = "Video Game";
            this.radBtnGame.UseVisualStyleBackColor = true;
            // 
            // ChooseMediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(469, 437);
            this.Controls.Add(this.radBtnGame);
            this.Controls.Add(this.radBtnWebsite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radBtnNewsArticle);
            this.Controls.Add(this.radBtnBook);
            this.Font = new System.Drawing.Font("OCR A Std", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "ChooseMediaForm";
            this.Text = "Submit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtnBook;
        private System.Windows.Forms.RadioButton radBtnNewsArticle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radBtnWebsite;
        private System.Windows.Forms.RadioButton radBtnGame;
    }
}