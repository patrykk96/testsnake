namespace test
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxGameField = new System.Windows.Forms.PictureBox();
            this.labelScoreString = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameField)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGameField
            // 
            this.pictureBoxGameField.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxGameField.Location = new System.Drawing.Point(46, 23);
            this.pictureBoxGameField.Name = "pictureBoxGameField";
            this.pictureBoxGameField.Size = new System.Drawing.Size(532, 534);
            this.pictureBoxGameField.TabIndex = 0;
            this.pictureBoxGameField.TabStop = false;
            this.pictureBoxGameField.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGameField_Paint);
            // 
            // labelScoreString
            // 
            this.labelScoreString.AutoSize = true;
            this.labelScoreString.Location = new System.Drawing.Point(600, 23);
            this.labelScoreString.Name = "labelScoreString";
            this.labelScoreString.Size = new System.Drawing.Size(50, 17);
            this.labelScoreString.TabIndex = 1;
            this.labelScoreString.Text = "punkty";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(641, 58);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(46, 17);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 569);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelScoreString);
            this.Controls.Add(this.pictureBoxGameField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGameField;
        private System.Windows.Forms.Label labelScoreString;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timer1;
    }
}

