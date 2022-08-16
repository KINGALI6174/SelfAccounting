namespace SelfAccounting.App
{
    partial class FrmCustomer
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtserch = new System.Windows.Forms.ToolStripTextBox();
            this.dgvcustomer = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnnewcustomer = new System.Windows.Forms.ToolStripButton();
            this.btnedit = new System.Windows.Forms.ToolStripButton();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.btnrefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnewcustomer,
            this.btnedit,
            this.btndelete,
            this.btnrefresh,
            this.toolStripLabel1,
            this.txtserch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 59);
            this.toolStripLabel1.Text = "جستجو :";
            // 
            // txtserch
            // 
            this.txtserch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(100, 62);
            this.txtserch.TextChanged += new System.EventHandler(this.txtserch_TextChanged);
            // 
            // dgvcustomer
            // 
            this.dgvcustomer.AllowUserToAddRows = false;
            this.dgvcustomer.AllowUserToDeleteRows = false;
            this.dgvcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FullName,
            this.Mobile,
            this.Email});
            this.dgvcustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcustomer.Location = new System.Drawing.Point(0, 62);
            this.dgvcustomer.Name = "dgvcustomer";
            this.dgvcustomer.ReadOnly = true;
            this.dgvcustomer.Size = new System.Drawing.Size(584, 299);
            this.dgvcustomer.TabIndex = 1;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "کد شخص";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "تلفن همراه";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "پست الکترونیکی";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // btnnewcustomer
            // 
            this.btnnewcustomer.Image = global::SelfAccounting.App.Properties.Resources._1371475930_filenew;
            this.btnnewcustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnnewcustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnewcustomer.Name = "btnnewcustomer";
            this.btnnewcustomer.Size = new System.Drawing.Size(70, 59);
            this.btnnewcustomer.Text = "شخص جدید";
            this.btnnewcustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnnewcustomer.Click += new System.EventHandler(this.btnnewcustomer_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = global::SelfAccounting.App.Properties.Resources._1371475973_document_edit;
            this.btnedit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(83, 59);
            this.btnedit.Text = "ویرایش شخص";
            this.btnedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btndelete
            // 
            this.btndelete.Image = global::SelfAccounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btndelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(72, 59);
            this.btndelete.Text = "حذف شخص";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Image = global::SelfAccounting.App.Properties.Resources._1371476342_Refresh;
            this.btnrefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(60, 59);
            this.btnrefresh.Text = "بروزرسانی";
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dgvcustomer);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست اشخاص";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnrefresh;
        private System.Windows.Forms.ToolStripButton btnnewcustomer;
        private System.Windows.Forms.ToolStripButton btnedit;
        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtserch;
        private System.Windows.Forms.DataGridView dgvcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}