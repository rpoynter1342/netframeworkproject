namespace Poynter_CourseProject_part2
{
    partial class inputForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.hireDateText = new System.Windows.Forms.TextBox();
            this.hireDateLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.benefitsGroupBox = new System.Windows.Forms.GroupBox();
            this.HealthInsuranceTextBox = new System.Windows.Forms.TextBox();
            this.HealthInsuranceLabel = new System.Windows.Forms.Label();
            this.LifeInsuranceTextBox = new System.Windows.Forms.TextBox();
            this.LifeInsuranceLabel = new System.Windows.Forms.Label();
            this.VacationDaysTextBox = new System.Windows.Forms.TextBox();
            this.VacationDaysLabel = new System.Windows.Forms.Label();
            this.benefitsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(14, 16);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(80, 13);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(245, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(80, 47);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(245, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(14, 50);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Location = new System.Drawing.Point(80, 83);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(245, 20);
            this.SSNTextBox.TabIndex = 2;
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(14, 86);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(35, 13);
            this.ssnLabel.TabIndex = 3;
            this.ssnLabel.Text = "SSN: ";
            // 
            // hireDateText
            // 
            this.hireDateText.Location = new System.Drawing.Point(80, 119);
            this.hireDateText.Name = "hireDateText";
            this.hireDateText.Size = new System.Drawing.Size(245, 20);
            this.hireDateText.TabIndex = 3;
            // 
            // hireDateLabel
            // 
            this.hireDateLabel.AutoSize = true;
            this.hireDateLabel.Location = new System.Drawing.Point(14, 122);
            this.hireDateLabel.Name = "hireDateLabel";
            this.hireDateLabel.Size = new System.Drawing.Size(55, 13);
            this.hireDateLabel.TabIndex = 5;
            this.hireDateLabel.Text = "Hire Date:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(108, 305);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(189, 305);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Cancel";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // benefitsGroupBox
            // 
            this.benefitsGroupBox.Controls.Add(this.HealthInsuranceTextBox);
            this.benefitsGroupBox.Controls.Add(this.HealthInsuranceLabel);
            this.benefitsGroupBox.Controls.Add(this.LifeInsuranceTextBox);
            this.benefitsGroupBox.Controls.Add(this.LifeInsuranceLabel);
            this.benefitsGroupBox.Controls.Add(this.VacationDaysTextBox);
            this.benefitsGroupBox.Controls.Add(this.VacationDaysLabel);
            this.benefitsGroupBox.Location = new System.Drawing.Point(12, 160);
            this.benefitsGroupBox.Name = "benefitsGroupBox";
            this.benefitsGroupBox.Size = new System.Drawing.Size(318, 139);
            this.benefitsGroupBox.TabIndex = 4;
            this.benefitsGroupBox.TabStop = false;
            this.benefitsGroupBox.Text = "Benefits";
            // 
            // HealthInsuranceTextBox
            // 
            this.HealthInsuranceTextBox.Location = new System.Drawing.Point(96, 48);
            this.HealthInsuranceTextBox.Name = "HealthInsuranceTextBox";
            this.HealthInsuranceTextBox.Size = new System.Drawing.Size(214, 20);
            this.HealthInsuranceTextBox.TabIndex = 0;
            // 
            // HealthInsuranceLabel
            // 
            this.HealthInsuranceLabel.AutoSize = true;
            this.HealthInsuranceLabel.Location = new System.Drawing.Point(2, 51);
            this.HealthInsuranceLabel.Name = "HealthInsuranceLabel";
            this.HealthInsuranceLabel.Size = new System.Drawing.Size(91, 13);
            this.HealthInsuranceLabel.TabIndex = 12;
            this.HealthInsuranceLabel.Text = "Health Insurance:";
            // 
            // LifeInsuranceTextBox
            // 
            this.LifeInsuranceTextBox.Location = new System.Drawing.Point(96, 74);
            this.LifeInsuranceTextBox.Name = "LifeInsuranceTextBox";
            this.LifeInsuranceTextBox.Size = new System.Drawing.Size(214, 20);
            this.LifeInsuranceTextBox.TabIndex = 1;
            // 
            // LifeInsuranceLabel
            // 
            this.LifeInsuranceLabel.AutoSize = true;
            this.LifeInsuranceLabel.Location = new System.Drawing.Point(2, 77);
            this.LifeInsuranceLabel.Name = "LifeInsuranceLabel";
            this.LifeInsuranceLabel.Size = new System.Drawing.Size(77, 13);
            this.LifeInsuranceLabel.TabIndex = 10;
            this.LifeInsuranceLabel.Text = "Life Insurance:";
            // 
            // VacationDaysTextBox
            // 
            this.VacationDaysTextBox.Location = new System.Drawing.Point(96, 100);
            this.VacationDaysTextBox.Name = "VacationDaysTextBox";
            this.VacationDaysTextBox.Size = new System.Drawing.Size(214, 20);
            this.VacationDaysTextBox.TabIndex = 2;
            // 
            // VacationDaysLabel
            // 
            this.VacationDaysLabel.AutoSize = true;
            this.VacationDaysLabel.Location = new System.Drawing.Point(2, 103);
            this.VacationDaysLabel.Name = "VacationDaysLabel";
            this.VacationDaysLabel.Size = new System.Drawing.Size(79, 13);
            this.VacationDaysLabel.TabIndex = 8;
            this.VacationDaysLabel.Text = "Vacation Days:";
            // 
            // inputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 340);
            this.Controls.Add(this.benefitsGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.hireDateText);
            this.Controls.Add(this.hireDateLabel);
            this.Controls.Add(this.SSNTextBox);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "inputForm";
            this.Text = "Employee Input Form";
            this.benefitsGroupBox.ResumeLayout(false);
            this.benefitsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        public System.Windows.Forms.TextBox firstNameTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        public System.Windows.Forms.TextBox SSNTextBox;
        private System.Windows.Forms.Label ssnLabel;
        public System.Windows.Forms.TextBox hireDateText;
        private System.Windows.Forms.Label hireDateLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox benefitsGroupBox;
        public System.Windows.Forms.TextBox HealthInsuranceTextBox;
        private System.Windows.Forms.Label HealthInsuranceLabel;
        public System.Windows.Forms.TextBox LifeInsuranceTextBox;
        private System.Windows.Forms.Label LifeInsuranceLabel;
        public System.Windows.Forms.TextBox VacationDaysTextBox;
        private System.Windows.Forms.Label VacationDaysLabel;
        public System.Windows.Forms.Button submitButton;
    }
}