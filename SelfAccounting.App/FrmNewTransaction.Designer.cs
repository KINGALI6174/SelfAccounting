namespace SelfAccounting.App
{
    partial class FrmNewTransaction
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvcustomers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbrecive = new System.Windows.Forms.RadioButton();
            this.rbpay = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.errorprovidertxtname = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprovidertxtname)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvcustomers);
            this.groupBox1.Controls.Add(this.txtfilter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اشخاص";
            // 
            // dgvcustomers
            // 
            this.dgvcustomers.AllowUserToAddRows = false;
            this.dgvcustomers.AllowUserToDeleteRows = false;
            this.dgvcustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvcustomers.Location = new System.Drawing.Point(6, 45);
            this.dgvcustomers.Name = "dgvcustomers";
            this.dgvcustomers.ReadOnly = true;
            this.dgvcustomers.Size = new System.Drawing.Size(188, 286);
            this.dgvcustomers.TabIndex = 1;
            this.dgvcustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcustomers_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FullName";
            this.Column1.HeaderText = "نام شخص";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerID";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // txtfilter
            // 
            this.txtfilter.Location = new System.Drawing.Point(6, 19);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(188, 21);
            this.txtfilter.TabIndex = 0;
            this.txtfilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "طرف حساب :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(257, 31);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(248, 21);
            this.txtname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "نوع تراکنش :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbrecive
            // 
            this.rbrecive.AutoSize = true;
            this.rbrecive.Location = new System.Drawing.Point(434, 73);
            this.rbrecive.Name = "rbrecive";
            this.rbrecive.Size = new System.Drawing.Size(55, 17);
            this.rbrecive.TabIndex = 4;
            this.rbrecive.TabStop = true;
            this.rbrecive.Text = "دریافت";
            this.rbrecive.UseVisualStyleBackColor = true;
            // 
            // rbpay
            // 
            this.rbpay.AutoSize = true;
            this.rbpay.Location = new System.Drawing.Point(337, 73);
            this.rbpay.Name = "rbpay";
            this.rbpay.Size = new System.Drawing.Size(58, 17);
            this.rbpay.TabIndex = 5;
            this.rbpay.TabStop = true;
            this.rbpay.Text = "پرداخت";
            this.rbpay.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "مبلغ :";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(257, 112);
            this.txtamount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(248, 21);
            this.txtamount.TabIndex = 7;
            this.txtamount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "شرح :";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(257, 155);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(248, 159);
            this.txtdescription.TabIndex = 9;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(257, 320);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(248, 23);
            this.btnsubmit.TabIndex = 10;
            this.btnsubmit.Text = "ثبت";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // errorprovidertxtname
            // 
            this.errorprovidertxtname.ContainerControl = this;
            // 
            // FrmNewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbpay);
            this.Controls.Add(this.rbrecive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmNewTransaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmNewTransaction";
            this.Load += new System.EventHandler(this.FrmNewTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorprovidertxtname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvcustomers;
        private System.Windows.Forms.TextBox txtfilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbrecive;
        private System.Windows.Forms.RadioButton rbpay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtamount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.ErrorProvider errorprovidertxtname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}