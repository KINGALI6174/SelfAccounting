namespace SelfAccounting.App
{
    partial class FrmReport
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
            this.btnedit = new System.Windows.Forms.ToolStripButton();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.btnrefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnfilter = new System.Windows.Forms.Button();
            this.txttodate = new System.Windows.Forms.MaskedTextBox();
            this.txtfromdate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvreport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاریخ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiprint = new Stimulsoft.Report.StiReport();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreport)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnedit,
            this.btndelete,
            this.btnrefresh,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnedit
            // 
            this.btnedit.Image = global::SelfAccounting.App.Properties.Resources._1371476499_todo_list;
            this.btnedit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(47, 59);
            this.btnedit.Text = "ویرایش";
            this.btnedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = global::SelfAccounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btndelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(44, 59);
            this.btndelete.Text = "حذف";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Image = global::SelfAccounting.App.Properties.Resources._1371476368_Synchronize;
            this.btnrefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(60, 59);
            this.btnrefresh.Text = "بروزرسانی";
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::SelfAccounting.App.Properties.Resources._1371476193_printers___Faxes;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(44, 59);
            this.toolStripButton4.Text = "چاپ";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnfilter);
            this.groupBox1.Controls.Add(this.txttodate);
            this.groupBox1.Controls.Add(this.txtfromdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbcustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // btnfilter
            // 
            this.btnfilter.Location = new System.Drawing.Point(18, 23);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(107, 23);
            this.btnfilter.TabIndex = 6;
            this.btnfilter.Text = "انجام";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // txttodate
            // 
            this.txttodate.Location = new System.Drawing.Point(144, 23);
            this.txttodate.Mask = "0000/00/00";
            this.txttodate.Name = "txttodate";
            this.txttodate.Size = new System.Drawing.Size(100, 21);
            this.txttodate.TabIndex = 5;
            this.txttodate.ValidatingType = typeof(System.DateTime);
            // 
            // txtfromdate
            // 
            this.txtfromdate.Location = new System.Drawing.Point(300, 23);
            this.txtfromdate.Mask = "0000/00/00";
            this.txtfromdate.Name = "txtfromdate";
            this.txtfromdate.Size = new System.Drawing.Size(100, 21);
            this.txtfromdate.TabIndex = 4;
            this.txtfromdate.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "تا تاریخ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "از تاریخ :";
            // 
            // cbcustomer
            // 
            this.cbcustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcustomer.FormattingEnabled = true;
            this.cbcustomer.Location = new System.Drawing.Point(457, 23);
            this.cbcustomer.Name = "cbcustomer";
            this.cbcustomer.Size = new System.Drawing.Size(121, 21);
            this.cbcustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "طرف حساب :";
            // 
            // dgvreport
            // 
            this.dgvreport.AllowUserToAddRows = false;
            this.dgvreport.AllowUserToDeleteRows = false;
            this.dgvreport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.تاریخ,
            this.Column4});
            this.dgvreport.Location = new System.Drawing.Point(12, 117);
            this.dgvreport.Name = "dgvreport";
            this.dgvreport.ReadOnly = true;
            this.dgvreport.Size = new System.Drawing.Size(672, 332);
            this.dgvreport.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerID";
            this.Column2.HeaderText = "طرف حساب";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "amount";
            this.Column3.HeaderText = "مبلغ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // تاریخ
            // 
            this.تاریخ.DataPropertyName = "DateTime";
            this.تاریخ.HeaderText = "تاریخ";
            this.تاریخ.Name = "تاریخ";
            this.تاریخ.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Description";
            this.Column4.HeaderText = "توضیحات";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // stiprint
            // 
            this.stiprint.CookieContainer = null;
            this.stiprint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiprint.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiprint.ReportAlias = "Report";
            this.stiprint.ReportGuid = "bec77624d5ce449fa9c7ebe493b62f0d";
            this.stiprint.ReportName = "Report";
            this.stiprint.ReportSource = null;
            this.stiprint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiprint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiprint.UseProgressInThread = false;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.dgvreport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnedit;
        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.ToolStripButton btnrefresh;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.MaskedTextBox txttodate;
        private System.Windows.Forms.MaskedTextBox txtfromdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbcustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvreport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاریخ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Stimulsoft.Report.StiReport stiprint;
    }
}