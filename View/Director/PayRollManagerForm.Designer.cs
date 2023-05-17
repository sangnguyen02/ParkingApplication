namespace FinalWindow.View.Director
{
    partial class PayRollManagerForm
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
            this.dataGridView_listManager = new System.Windows.Forms.DataGridView();
            this.comboBox_facilityAddress = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_resetPayroll = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_listManager
            // 
            this.dataGridView_listManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listManager.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_listManager.Name = "dataGridView_listManager";
            this.dataGridView_listManager.RowHeadersWidth = 51;
            this.dataGridView_listManager.RowTemplate.Height = 24;
            this.dataGridView_listManager.Size = new System.Drawing.Size(776, 248);
            this.dataGridView_listManager.TabIndex = 0;
            this.dataGridView_listManager.Click += new System.EventHandler(this.dataGridView_listManager_Click);
            // 
            // comboBox_facilityAddress
            // 
            this.comboBox_facilityAddress.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_facilityAddress.BorderRadius = 20;
            this.comboBox_facilityAddress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_facilityAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_facilityAddress.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_facilityAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_facilityAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_facilityAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_facilityAddress.ItemHeight = 30;
            this.comboBox_facilityAddress.Items.AddRange(new object[] {
            "Manager",
            "FixWorker",
            "KeepWorker"});
            this.comboBox_facilityAddress.Location = new System.Drawing.Point(12, 293);
            this.comboBox_facilityAddress.Name = "comboBox_facilityAddress";
            this.comboBox_facilityAddress.Size = new System.Drawing.Size(191, 36);
            this.comboBox_facilityAddress.TabIndex = 43;
            this.comboBox_facilityAddress.SelectedValueChanged += new System.EventHandler(this.comboBox_facilityAddress_SelectedValueChanged);
            // 
            // button_resetPayroll
            // 
            this.button_resetPayroll.BorderRadius = 10;
            this.button_resetPayroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_resetPayroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_resetPayroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_resetPayroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_resetPayroll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resetPayroll.ForeColor = System.Drawing.Color.White;
            this.button_resetPayroll.Location = new System.Drawing.Point(12, 368);
            this.button_resetPayroll.Name = "button_resetPayroll";
            this.button_resetPayroll.Size = new System.Drawing.Size(92, 32);
            this.button_resetPayroll.TabIndex = 44;
            this.button_resetPayroll.Text = "Reset";
            this.button_resetPayroll.Click += new System.EventHandler(this.button_resetPayroll_Click);
            // 
            // PayRollManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_resetPayroll);
            this.Controls.Add(this.comboBox_facilityAddress);
            this.Controls.Add(this.dataGridView_listManager);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PayRollManagerForm";
            this.Text = "PayRollManagerForm";
            this.Load += new System.EventHandler(this.PayRollManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_listManager;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_facilityAddress;
        private Guna.UI2.WinForms.Guna2Button button_resetPayroll;
    }
}