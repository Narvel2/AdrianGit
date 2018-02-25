namespace AdrianPiecyk_Lab2
{
    partial class Game_Details
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
            this.labelGameDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGameDetails
            // 
            this.labelGameDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGameDetails.AutoSize = true;
            this.labelGameDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelGameDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGameDetails.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.labelGameDetails.Location = new System.Drawing.Point(134, 87);
            this.labelGameDetails.Name = "labelGameDetails";
            this.labelGameDetails.Size = new System.Drawing.Size(60, 24);
            this.labelGameDetails.TabIndex = 0;
            this.labelGameDetails.Text = "Tekst";
            this.labelGameDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Game_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.labelGameDetails);
            this.Name = "Game_Details";
            this.Text = "Game_Details";
            this.Load += new System.EventHandler(this.Game_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameDetails;
    }
}