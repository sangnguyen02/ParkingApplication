namespace FinalWindow.View.Director
{
    partial class CalculateManagerSalaryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_totalSalary = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.checkBox_late = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBox_laziness = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBox_longevityBonus = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBox_Harworking = new Guna.UI2.WinForms.Guna2CheckBox();
            this.button_confirm = new Guna.UI2.WinForms.Guna2Button();
            this.label_manCardID = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Salary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_totalSalary
            // 
            this.label_totalSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_totalSalary.AutoSize = true;
            this.label_totalSalary.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalSalary.Location = new System.Drawing.Point(117, 101);
            this.label_totalSalary.Name = "label_totalSalary";
            this.label_totalSalary.Size = new System.Drawing.Size(259, 57);
            this.label_totalSalary.TabIndex = 1;
            this.label_totalSalary.Text = "Total Salary";
            this.label_totalSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.label_FirstName);
            this.guna2GroupBox1.Controls.Add(this.label_manCardID);
            this.guna2GroupBox1.Controls.Add(this.checkBox_late);
            this.guna2GroupBox1.Controls.Add(this.checkBox_laziness);
            this.guna2GroupBox1.Controls.Add(this.checkBox_longevityBonus);
            this.guna2GroupBox1.Controls.Add(this.checkBox_Harworking);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.guna2GroupBox1.Location = new System.Drawing.Point(35, 194);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(428, 250);
            this.guna2GroupBox1.TabIndex = 21;
            // 
            // checkBox_late
            // 
            this.checkBox_late.AutoSize = true;
            this.checkBox_late.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox_late.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox_late.CheckedState.BorderRadius = 0;
            this.checkBox_late.CheckedState.BorderThickness = 0;
            this.checkBox_late.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkBox_late.CheckMarkColor = System.Drawing.Color.Black;
            this.checkBox_late.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBox_late.ForeColor = System.Drawing.Color.Black;
            this.checkBox_late.Location = new System.Drawing.Point(240, 199);
            this.checkBox_late.Name = "checkBox_late";
            this.checkBox_late.Size = new System.Drawing.Size(66, 27);
            this.checkBox_late.TabIndex = 6;
            this.checkBox_late.Text = "Late";
            this.checkBox_late.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkBox_late.UncheckedState.BorderRadius = 0;
            this.checkBox_late.UncheckedState.BorderThickness = 0;
            this.checkBox_late.UncheckedState.FillColor = System.Drawing.Color.White;
            this.checkBox_late.UseVisualStyleBackColor = false;
            this.checkBox_late.CheckedChanged += new System.EventHandler(this.checkBox_late_CheckedChanged);
            // 
            // checkBox_laziness
            // 
            this.checkBox_laziness.AutoSize = true;
            this.checkBox_laziness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox_laziness.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox_laziness.CheckedState.BorderRadius = 0;
            this.checkBox_laziness.CheckedState.BorderThickness = 0;
            this.checkBox_laziness.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkBox_laziness.CheckMarkColor = System.Drawing.Color.Black;
            this.checkBox_laziness.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBox_laziness.ForeColor = System.Drawing.Color.Black;
            this.checkBox_laziness.Location = new System.Drawing.Point(29, 199);
            this.checkBox_laziness.Name = "checkBox_laziness";
            this.checkBox_laziness.Size = new System.Drawing.Size(96, 27);
            this.checkBox_laziness.TabIndex = 5;
            this.checkBox_laziness.Text = "Laziness";
            this.checkBox_laziness.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkBox_laziness.UncheckedState.BorderRadius = 0;
            this.checkBox_laziness.UncheckedState.BorderThickness = 0;
            this.checkBox_laziness.UncheckedState.FillColor = System.Drawing.Color.White;
            this.checkBox_laziness.UseVisualStyleBackColor = false;
            this.checkBox_laziness.CheckedChanged += new System.EventHandler(this.checkBox_laziness_CheckedChanged);
            // 
            // checkBox_longevityBonus
            // 
            this.checkBox_longevityBonus.AutoSize = true;
            this.checkBox_longevityBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox_longevityBonus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox_longevityBonus.CheckedState.BorderRadius = 0;
            this.checkBox_longevityBonus.CheckedState.BorderThickness = 0;
            this.checkBox_longevityBonus.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkBox_longevityBonus.CheckMarkColor = System.Drawing.Color.Black;
            this.checkBox_longevityBonus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBox_longevityBonus.ForeColor = System.Drawing.Color.Black;
            this.checkBox_longevityBonus.Location = new System.Drawing.Point(240, 143);
            this.checkBox_longevityBonus.Name = "checkBox_longevityBonus";
            this.checkBox_longevityBonus.Size = new System.Drawing.Size(164, 27);
            this.checkBox_longevityBonus.TabIndex = 4;
            this.checkBox_longevityBonus.Text = "Longevity Bonus";
            this.checkBox_longevityBonus.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkBox_longevityBonus.UncheckedState.BorderRadius = 0;
            this.checkBox_longevityBonus.UncheckedState.BorderThickness = 0;
            this.checkBox_longevityBonus.UncheckedState.FillColor = System.Drawing.Color.White;
            this.checkBox_longevityBonus.UseVisualStyleBackColor = false;
            this.checkBox_longevityBonus.CheckedChanged += new System.EventHandler(this.checkBox_longevityBonus_CheckedChanged);
            // 
            // checkBox_Harworking
            // 
            this.checkBox_Harworking.AutoSize = true;
            this.checkBox_Harworking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox_Harworking.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox_Harworking.CheckedState.BorderRadius = 0;
            this.checkBox_Harworking.CheckedState.BorderThickness = 0;
            this.checkBox_Harworking.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkBox_Harworking.CheckMarkColor = System.Drawing.Color.Black;
            this.checkBox_Harworking.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBox_Harworking.ForeColor = System.Drawing.Color.Black;
            this.checkBox_Harworking.Location = new System.Drawing.Point(29, 143);
            this.checkBox_Harworking.Name = "checkBox_Harworking";
            this.checkBox_Harworking.Size = new System.Drawing.Size(192, 27);
            this.checkBox_Harworking.TabIndex = 3;
            this.checkBox_Harworking.Text = "Hardworking Bonus";
            this.checkBox_Harworking.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkBox_Harworking.UncheckedState.BorderRadius = 0;
            this.checkBox_Harworking.UncheckedState.BorderThickness = 0;
            this.checkBox_Harworking.UncheckedState.FillColor = System.Drawing.Color.White;
            this.checkBox_Harworking.UseVisualStyleBackColor = false;
            this.checkBox_Harworking.CheckedChanged += new System.EventHandler(this.checkBox_Harworking_CheckedChanged);
            // 
            // button_confirm
            // 
            this.button_confirm.BorderRadius = 20;
            this.button_confirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_confirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_confirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_confirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_confirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirm.ForeColor = System.Drawing.Color.White;
            this.button_confirm.Location = new System.Drawing.Point(91, 477);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(315, 40);
            this.button_confirm.TabIndex = 56;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label_manCardID
            // 
            this.label_manCardID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_manCardID.AutoSize = true;
            this.label_manCardID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label_manCardID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manCardID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_manCardID.Location = new System.Drawing.Point(24, 28);
            this.label_manCardID.Name = "label_manCardID";
            this.label_manCardID.Size = new System.Drawing.Size(76, 28);
            this.label_manCardID.TabIndex = 57;
            this.label_manCardID.Text = "CardID";
            this.label_manCardID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_FirstName
            // 
            this.label_FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label_FirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_FirstName.Location = new System.Drawing.Point(24, 76);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(109, 28);
            this.label_FirstName.TabIndex = 58;
            this.label_FirstName.Text = "FirstName";
            this.label_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateManagerSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(503, 555);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label_totalSalary);
            this.Controls.Add(this.label1);
            this.Name = "CalculateManagerSalaryForm";
            this.Text = "CalculateManagerSalaryForm";
            this.Load += new System.EventHandler(this.CalculateSalaryForm_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_Harworking;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_laziness;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_longevityBonus;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_late;
        public System.Windows.Forms.Label label_totalSalary;
        private Guna.UI2.WinForms.Guna2Button button_confirm;
        public System.Windows.Forms.Label label_FirstName;
        public System.Windows.Forms.Label label_manCardID;
    }
}