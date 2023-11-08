namespace FinalWindow.View.Director.List
{
    partial class ListLongContractForm
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
            this.dataGridView_listActiveLong = new System.Windows.Forms.DataGridView();
            this.done = new System.Windows.Forms.TabPage();
            this.dataGridView_listDoneLong = new System.Windows.Forms.DataGridView();
            this.guna2TabControl1.SuspendLayout();
            this.active.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listActiveLong)).BeginInit();
            this.done.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listDoneLong)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.active);
            this.guna2TabControl1.Controls.Add(this.done);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(3, 12);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1146, 692);
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
            this.guna2TabControl1.TabIndex = 1;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // active
            // 
            this.active.Controls.Add(this.dataGridView_listActiveLong);
            this.active.Location = new System.Drawing.Point(4, 44);
            this.active.Name = "active";
            this.active.Padding = new System.Windows.Forms.Padding(3);
            this.active.Size = new System.Drawing.Size(1138, 644);
            this.active.TabIndex = 0;
            this.active.Text = "Active";
            this.active.UseVisualStyleBackColor = true;
            // 
            // dataGridView_listActiveLong
            // 
            this.dataGridView_listActiveLong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listActiveLong.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_listActiveLong.Name = "dataGridView_listActiveLong";
            this.dataGridView_listActiveLong.RowHeadersWidth = 51;
            this.dataGridView_listActiveLong.RowTemplate.Height = 24;
            this.dataGridView_listActiveLong.Size = new System.Drawing.Size(1034, 632);
            this.dataGridView_listActiveLong.TabIndex = 0;
            // 
            // done
            // 
            this.done.Controls.Add(this.dataGridView_listDoneLong);
            this.done.Location = new System.Drawing.Point(4, 44);
            this.done.Name = "done";
            this.done.Padding = new System.Windows.Forms.Padding(3);
            this.done.Size = new System.Drawing.Size(1138, 644);
            this.done.TabIndex = 1;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            // 
            // dataGridView_listDoneLong
            // 
            this.dataGridView_listDoneLong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listDoneLong.Location = new System.Drawing.Point(16, 6);
            this.dataGridView_listDoneLong.Name = "dataGridView_listDoneLong";
            this.dataGridView_listDoneLong.RowHeadersWidth = 51;
            this.dataGridView_listDoneLong.RowTemplate.Height = 24;
            this.dataGridView_listDoneLong.Size = new System.Drawing.Size(970, 618);
            this.dataGridView_listDoneLong.TabIndex = 1;
            // 
            // ListLongContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 716);
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "ListLongContractForm";
            this.Text = "ListLongContractForm";
            this.guna2TabControl1.ResumeLayout(false);
            this.active.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listActiveLong)).EndInit();
            this.done.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listDoneLong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage active;
        private System.Windows.Forms.DataGridView dataGridView_listActiveLong;
        private System.Windows.Forms.TabPage done;
        private System.Windows.Forms.DataGridView dataGridView_listDoneLong;
    }
}