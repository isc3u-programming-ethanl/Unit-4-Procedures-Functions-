namespace OptionalParametersEthan
{
    partial class frmOptionalParameters
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
            this.lblTitleText = new System.Windows.Forms.Label();
            this.lblAddressText = new System.Windows.Forms.Label();
            this.lblCityText = new System.Windows.Forms.Label();
            this.lblPostalCodeText = new System.Windows.Forms.Label();
            this.lblUnitText = new System.Windows.Forms.Label();
            this.lblProvinceText = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleText.Location = new System.Drawing.Point(161, 32);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(412, 25);
            this.lblTitleText.TabIndex = 0;
            this.lblTitleText.Text = "Enter your full address in the fields below:";
            // 
            // lblAddressText
            // 
            this.lblAddressText.AutoSize = true;
            this.lblAddressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressText.Location = new System.Drawing.Point(75, 134);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(85, 24);
            this.lblAddressText.TabIndex = 1;
            this.lblAddressText.Text = "Address:";
            // 
            // lblCityText
            // 
            this.lblCityText.AutoSize = true;
            this.lblCityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityText.Location = new System.Drawing.Point(75, 208);
            this.lblCityText.Name = "lblCityText";
            this.lblCityText.Size = new System.Drawing.Size(45, 24);
            this.lblCityText.TabIndex = 2;
            this.lblCityText.Text = "City:";
            // 
            // lblPostalCodeText
            // 
            this.lblPostalCodeText.AutoSize = true;
            this.lblPostalCodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCodeText.Location = new System.Drawing.Point(75, 276);
            this.lblPostalCodeText.Name = "lblPostalCodeText";
            this.lblPostalCodeText.Size = new System.Drawing.Size(116, 24);
            this.lblPostalCodeText.TabIndex = 3;
            this.lblPostalCodeText.Text = "Postal Code:";
            // 
            // lblUnitText
            // 
            this.lblUnitText.AutoSize = true;
            this.lblUnitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitText.Location = new System.Drawing.Point(473, 134);
            this.lblUnitText.Name = "lblUnitText";
            this.lblUnitText.Size = new System.Drawing.Size(47, 24);
            this.lblUnitText.TabIndex = 4;
            this.lblUnitText.Text = "Unit:";
            // 
            // lblProvinceText
            // 
            this.lblProvinceText.AutoSize = true;
            this.lblProvinceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinceText.Location = new System.Drawing.Point(473, 208);
            this.lblProvinceText.Name = "lblProvinceText";
            this.lblProvinceText.Size = new System.Drawing.Size(89, 24);
            this.lblProvinceText.TabIndex = 5;
            this.lblProvinceText.Text = "Province:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(166, 138);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.TextChanged += new System.EventHandler(this.TxtAddress_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(126, 213);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 7;
            this.txtCity.TextChanged += new System.EventHandler(this.TxtCity_TextChanged);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(197, 281);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 8;
            this.txtPostalCode.TextChanged += new System.EventHandler(this.TxtPostalCode_TextChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(526, 138);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 20);
            this.txtUnit.TabIndex = 9;
            this.txtUnit.TextChanged += new System.EventHandler(this.TxtUnit_TextChanged);
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(568, 213);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 10;
            this.txtProvince.TextChanged += new System.EventHandler(this.TxtProvince_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(324, 341);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(98, 44);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // frmOptionalParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblProvinceText);
            this.Controls.Add(this.lblUnitText);
            this.Controls.Add(this.lblPostalCodeText);
            this.Controls.Add(this.lblCityText);
            this.Controls.Add(this.lblAddressText);
            this.Controls.Add(this.lblTitleText);
            this.Name = "frmOptionalParameters";
            this.Text = "Optional Parameters by Ethan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.Label lblCityText;
        private System.Windows.Forms.Label lblPostalCodeText;
        private System.Windows.Forms.Label lblUnitText;
        private System.Windows.Forms.Label lblProvinceText;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Button btnEnter;
    }
}

