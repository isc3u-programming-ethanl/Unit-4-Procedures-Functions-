namespace PythagoreanTheoremEthanL
{
    partial class frmPythagoreanTheorem
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
            this.txtOpp = new System.Windows.Forms.TextBox();
            this.txtAdj = new System.Windows.Forms.TextBox();
            this.lblOpp = new System.Windows.Forms.Label();
            this.lblAdj = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOpp
            // 
            this.txtOpp.Location = new System.Drawing.Point(205, 52);
            this.txtOpp.Name = "txtOpp";
            this.txtOpp.Size = new System.Drawing.Size(100, 20);
            this.txtOpp.TabIndex = 0;
            // 
            // txtAdj
            // 
            this.txtAdj.Location = new System.Drawing.Point(205, 128);
            this.txtAdj.Name = "txtAdj";
            this.txtAdj.Size = new System.Drawing.Size(100, 20);
            this.txtAdj.TabIndex = 1;
            // 
            // lblOpp
            // 
            this.lblOpp.AutoSize = true;
            this.lblOpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpp.Location = new System.Drawing.Point(108, 48);
            this.lblOpp.Name = "lblOpp";
            this.lblOpp.Size = new System.Drawing.Size(91, 24);
            this.lblOpp.TabIndex = 2;
            this.lblOpp.Text = "Opposite:";
            // 
            // lblAdj
            // 
            this.lblAdj.AutoSize = true;
            this.lblAdj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdj.Location = new System.Drawing.Point(110, 123);
            this.lblAdj.Name = "lblAdj";
            this.lblAdj.Size = new System.Drawing.Size(89, 24);
            this.lblAdj.TabIndex = 3;
            this.lblAdj.Text = "Adjacent:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(108, 201);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 24);
            this.lblAnswer.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(358, 75);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(139, 48);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // frmPythagoreanTheorem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 331);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblAdj);
            this.Controls.Add(this.lblOpp);
            this.Controls.Add(this.txtAdj);
            this.Controls.Add(this.txtOpp);
            this.Name = "frmPythagoreanTheorem";
            this.Text = "Hypotenuse Calculator by Ethan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpp;
        private System.Windows.Forms.TextBox txtAdj;
        private System.Windows.Forms.Label lblOpp;
        private System.Windows.Forms.Label lblAdj;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCalculate;
    }
}

