namespace FinalWindow.View.Director.List
{
    partial class ListLoanContractForm
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
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.active = new System.Windows.Forms.TabPage();
            this.done = new System.Windows.Forms.TabPage();
            this.dataGridView_listActiveLoan = new System.Windows.Forms.DataGridView();
            this.dataGridView_listDoneLoan = new System.Windows.Forms.DataGridView();
            this.guna2TabControl1.SuspendLayout();
            this.active.SuspendLayout();
            this.done.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listActiveLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listDoneLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.active);
            this.guna2TabControl1.Controls.Add(this.done);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(12, 12);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1048, 611);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // active
            // 
            this.active.Controls.Add(this.dataGridView_listActiveLoan);
            this.active.Location = new System.Drawing.Point(4, 44);
            this.active.Name = "active";
            this.active.Padding = new System.Windows.Forms.Padding(3);
            this.active.Size = new System.Drawing.Size(1040, 563);
            this.active.TabIndex = 0;
            this.active.Text = "Active";
            this.active.UseVisualStyleBackColor = true;
            // 
            // done
            // 
            this.done.Controls.Add(this.dataGridView_listDoneLoan);
            this.done.Location = new System.Drawing.Point(4, 44);
            this.done.Name = "done";
            this.done.Padding = new System.Windows.Forms.Padding(3);
            this.done.Size = new System.Drawing.Size(1040, 563);
            this.done.TabIndex = 1;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            // 
            // dataGridView_listActiveLoan
            // 
            this.dataGridView_listActiveLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listActiveLoan.Location = new System.Drawing.Point(33, 20);
            this.dataGridView_listActiveLoan.Name = "dataGridView_listActiveLoan";
            this.dataGridView_listActiveLoan.RowHeadersWidth = 51;
            this.dataGridView_listActiveLoan.RowTemplate.Height = 24;
            this.dataGridView_listActiveLoan.Size = new System.Drawing.Size(921, 522);
            this.dataGridView_listActiveLoan.TabIndex = 0;
            // 
            // dataGridView_listDoneLoan
            // 
            this.dataGridView_listDoneLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listDoneLoan.Location = new System.Drawing.Point(60, 20);
            this.dataGridView_listDoneLoan.Name = "dataGridView_listDoneLoan";
            this.dataGridView_listDoneLoan.RowHeadersWidth = 51;
            this.dataGridView_listDoneLoan.RowTemplate.Height = 24;
            this.dataGridView_listDoneLoan.Size = new System.Drawing.Size(921, 522);
            this.dataGridView_listDoneLoan.TabIndex = 1;
            // 
            // ListLoanContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 635);
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "ListLoanContractForm";
            this.Text = "ListLoanContractForm";
            this.guna2TabControl1.ResumeLayout(false);
            this.active.ResumeLayout(false);
            this.done.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listActiveLoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listDoneLoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage active;
        private System.Windows.Forms.TabPage done;
        private System.Windows.Forms.DataGridView dataGridView_listActiveLoan;
        private System.Windows.Forms.DataGridView dataGridView_listDoneLoan;
    }
}