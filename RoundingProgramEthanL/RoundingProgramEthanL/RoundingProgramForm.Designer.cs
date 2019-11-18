namespace RoundingProgramEthanL
{
    partial class frmRoundingProgram
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.nudRound = new System.Windows.Forms.NumericUpDown();
            this.btnRound = new System.Windows.Forms.Button();
            this.lblSample = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRound)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(78, 47);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(222, 24);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Enter a decimal number: ";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(297, 47);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(193, 29);
            this.txtInput.TabIndex = 1;
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(79, 113);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(443, 24);
            this.lblQuestionText.TabIndex = 2;
            this.lblQuestionText.Text = "How many decimal places do you want to round to?";
            // 
            // nudRound
            // 
            this.nudRound.Location = new System.Drawing.Point(528, 119);
            this.nudRound.Name = "nudRound";
            this.nudRound.Size = new System.Drawing.Size(51, 20);
            this.nudRound.TabIndex = 3;
            // 
            // btnRound
            // 
            this.btnRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRound.Location = new System.Drawing.Point(268, 177);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(122, 40);
            this.btnRound.TabIndex = 4;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.BtnRound_Click);
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Location = new System.Drawing.Point(12, 204);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(0, 13);
            this.lblSample.TabIndex = 5;
            // 
            // frmRoundingProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 248);
            this.Controls.Add(this.lblSample);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.nudRound);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Name = "frmRoundingProgram";
            this.Text = "Rounding Program by Ethan";
            ((System.ComponentModel.ISupportInitialize)(this.nudRound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.NumericUpDown nudRound;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Label lblSample;
    }
}

