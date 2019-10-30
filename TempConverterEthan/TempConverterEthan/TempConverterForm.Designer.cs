namespace TempConverterEthan
{
    partial class frmTempConverter
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
            this.lblInputText = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnConvertToFah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputText
            // 
            this.lblInputText.AutoSize = true;
            this.lblInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputText.Location = new System.Drawing.Point(24, 34);
            this.lblInputText.Name = "lblInputText";
            this.lblInputText.Size = new System.Drawing.Size(410, 25);
            this.lblInputText.TabIndex = 0;
            this.lblInputText.Text = "Enter the temperature in degrees Celcius:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(440, 40);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // btnConvertToFah
            // 
            this.btnConvertToFah.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToFah.Location = new System.Drawing.Point(223, 93);
            this.btnConvertToFah.Name = "btnConvertToFah";
            this.btnConvertToFah.Size = new System.Drawing.Size(167, 63);
            this.btnConvertToFah.TabIndex = 2;
            this.btnConvertToFah.Text = "Convert to Fahrenheit";
            this.btnConvertToFah.UseVisualStyleBackColor = true;
            this.btnConvertToFah.Click += new System.EventHandler(this.BtnConvertToFah_Click);
            // 
            // frmTempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvertToFah);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInputText);
            this.Name = "frmTempConverter";
            this.Text = "Celcius to Fahrenheit by Ethan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputText;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnConvertToFah;
    }
}

