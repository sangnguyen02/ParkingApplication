namespace FinalWindow.View.Manager
{
    partial class PayRollWorkerForm
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
            this.button_resetPayroll = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox_typeWorker = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridView_listWorker = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listWorker)).BeginInit();
            this.SuspendLayout();
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
            this.button_resetPayroll.Location = new System.Drawing.Point(12, 387);
            this.button_resetPayroll.Name = "button_resetPayroll";
            this.button_resetPayroll.Size = new System.Drawing.Size(191, 32);
            this.button_resetPayroll.TabIndex = 47;
            this.button_resetPayroll.Text = "Reset";
            // 
            // comboBox_typeWorker
            // 
            this.comboBox_typeWorker.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_typeWorker.BorderRadius = 20;
            this.comboBox_typeWorker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_typeWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_typeWorker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_typeWorker.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_typeWorker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_typeWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_typeWorker.ItemHeight = 30;
            this.comboBox_typeWorker.Items.AddRange(new object[] {
            "FixWorker",
            "KeepWorker"});
            this.comboBox_typeWorker.Location = new System.Drawing.Point(12, 312);
            this.comboBox_typeWorker.Name = "comboBox_typeWorker";
            this.comboBox_typeWorker.Size = new System.Drawing.Size(191, 36);
            this.comboBox_typeWorker.TabIndex = 46;
            this.comboBox_typeWorker.SelectedIndexChanged += new System.EventHandler(this.comboBox_typeWorker_SelectedIndexChanged);
            // 
            // dataGridView_listWorker
            // 
            this.dataGridView_listWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listWorker.Location = new System.Drawing.Point(12, 31);
            this.dataGridView_listWorker.Name = "dataGridView_listWorker";
            this.dataGridView_listWorker.RowHeadersWidth = 51;
            this.dataGridView_listWorker.RowTemplate.Height = 24;
            this.dataGridView_listWorker.Size = new System.Drawing.Size(887, 248);
            this.dataGridView_listWorker.TabIndex = 45;
            this.dataGridView_listWorker.Click += new System.EventHandler(this.dataGridView_listWorker_Click);
            // 
            // PayRollWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.button_resetPayroll);
            this.Controls.Add(this.comboBox_typeWorker);
            this.Controls.Add(this.dataGridView_listWorker);
            this.Name = "PayRollWorkerForm";
            this.Text = "PayRollWorkerForm";
            this.Load += new System.EventHandler(this.PayRollWorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button_resetPayroll;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_typeWorker;
        private System.Windows.Forms.DataGridView dataGridView_listWorker;
    }
}