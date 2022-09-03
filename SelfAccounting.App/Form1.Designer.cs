namespace SelfAccounting.App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btneditlogin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnadduser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnnewtransaction = new System.Windows.Forms.ToolStripButton();
            this.btnreportpay = new System.Windows.Forms.ToolStripButton();
            this.btnreportrecive = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbldate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbltime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btneditlogin,
            this.btnadduser});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            // 
            // btneditlogin
            // 
            this.btneditlogin.Name = "btneditlogin";
            this.btneditlogin.Size = new System.Drawing.Size(180, 22);
            this.btneditlogin.Text = "تنظیمات ورود";
            this.btneditlogin.Click += new System.EventHandler(this.btneditlogin_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(180, 22);
            this.btnadduser.Text = "کاربر جدید";
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnnewtransaction,
            this.btnreportpay,
            this.btnreportrecive});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::SelfAccounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 59);
            this.toolStripButton1.Text = "طرف حساب";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnnewtransaction
            // 
            this.btnnewtransaction.Image = global::SelfAccounting.App.Properties.Resources.list2;
            this.btnnewtransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnnewtransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnewtransaction.Name = "btnnewtransaction";
            this.btnnewtransaction.Size = new System.Drawing.Size(72, 59);
            this.btnnewtransaction.Text = "تراکنش جدید";
            this.btnnewtransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnnewtransaction.Click += new System.EventHandler(this.btnnewtransaction_Click);
            // 
            // btnreportpay
            // 
            this.btnreportpay.Image = global::SelfAccounting.App.Properties.Resources._1371475973_document_edit;
            this.btnreportpay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnreportpay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnreportpay.Name = "btnreportpay";
            this.btnreportpay.Size = new System.Drawing.Size(97, 59);
            this.btnreportpay.Text = "گزارش پرداختی ها";
            this.btnreportpay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnreportpay.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnreportrecive
            // 
            this.btnreportrecive.Image = global::SelfAccounting.App.Properties.Resources._1371476499_todo_list;
            this.btnreportrecive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnreportrecive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnreportrecive.Name = "btnreportrecive";
            this.btnreportrecive.Size = new System.Drawing.Size(98, 59);
            this.btnreportrecive.Text = "گزارش دریافتی ها";
            this.btnreportrecive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnreportrecive.Click += new System.EventHandler(this.btnreportrecive_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SelfAccounting.App.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(12, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 348);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbldate,
            this.lbltime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbldate
            // 
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(118, 17);
            this.lbldate.Text = "toolStripStatusLabel1";
            // 
            // lbltime
            // 
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(118, 17);
            this.lbltime.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnnewtransaction;
        private System.Windows.Forms.ToolStripButton btnreportpay;
        private System.Windows.Forms.ToolStripButton btnreportrecive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbldate;
        private System.Windows.Forms.ToolStripStatusLabel lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem btneditlogin;
        private System.Windows.Forms.ToolStripMenuItem btnadduser;
    }
}

