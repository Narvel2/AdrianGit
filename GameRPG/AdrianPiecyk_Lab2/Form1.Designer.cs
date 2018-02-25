namespace AdrianPiecyk_Lab2
{
    partial class FormWindow
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGameDetails = new System.Windows.Forms.Button();
            this.progressBarLoader = new System.Windows.Forms.ProgressBar();
            this.timerLoader = new System.Windows.Forms.Timer(this.components);
            this.labelNameOfGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(42, 234);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(156, 55);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Nowa Gra";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(270, 234);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(145, 55);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Wyjście";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonGameDetails
            // 
            this.buttonGameDetails.Location = new System.Drawing.Point(489, 234);
            this.buttonGameDetails.Name = "buttonGameDetails";
            this.buttonGameDetails.Size = new System.Drawing.Size(145, 55);
            this.buttonGameDetails.TabIndex = 2;
            this.buttonGameDetails.Text = "Szczegóły Gry";
            this.buttonGameDetails.UseVisualStyleBackColor = true;
            this.buttonGameDetails.Click += new System.EventHandler(this.buttonGameDetails_Click);
            // 
            // progressBarLoader
            // 
            this.progressBarLoader.Location = new System.Drawing.Point(270, 121);
            this.progressBarLoader.Name = "progressBarLoader";
            this.progressBarLoader.Size = new System.Drawing.Size(145, 27);
            this.progressBarLoader.TabIndex = 3;
            this.progressBarLoader.Click += new System.EventHandler(this.progressBarLoader_Click);
            // 
            // timerLoader
            // 
            this.timerLoader.Interval = 10;
            this.timerLoader.Tick += new System.EventHandler(this.timerLoader_Tick);
            // 
            // labelNameOfGame
            // 
            this.labelNameOfGame.AutoSize = true;
            this.labelNameOfGame.BackColor = System.Drawing.Color.Transparent;
            this.labelNameOfGame.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOfGame.Location = new System.Drawing.Point(208, 36);
            this.labelNameOfGame.Name = "labelNameOfGame";
            this.labelNameOfGame.Size = new System.Drawing.Size(267, 36);
            this.labelNameOfGame.TabIndex = 4;
            this.labelNameOfGame.Text = "Never Die Again";
            // 
            // FormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 346);
            this.Controls.Add(this.labelNameOfGame);
            this.Controls.Add(this.progressBarLoader);
            this.Controls.Add(this.buttonGameDetails);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNewGame);
            this.Name = "FormWindow";
            this.Text = "Game Window";
            this.Load += new System.EventHandler(this.FormWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonGameDetails;
        private System.Windows.Forms.ProgressBar progressBarLoader;
        private System.Windows.Forms.Timer timerLoader;
        private System.Windows.Forms.Label labelNameOfGame;
    }
}

