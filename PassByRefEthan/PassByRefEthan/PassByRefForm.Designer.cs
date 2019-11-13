namespace PassByRefEthan
{
    partial class frmPassByRef
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
            this.picCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // picCard
            // 
            this.picCard.Image = global::PassByRefEthan.Properties.Resources.QS;
            this.picCard.Location = new System.Drawing.Point(49, 12);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(363, 473);
            this.picCard.TabIndex = 0;
            this.picCard.TabStop = false;
            this.picCard.Click += new System.EventHandler(this.PicCard_Click);
            // 
            // frmPassByRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 497);
            this.Controls.Add(this.picCard);
            this.Name = "frmPassByRef";
            this.Text = "Pass By Ref By Ethan";
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCard;
    }
}

