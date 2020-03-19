namespace _102170301_HoangDucThanh_17TCLC2.GUI
{
    partial class DetailForm
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
            this.tB_ID_Em = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.rB_Male = new System.Windows.Forms.RadioButton();
            this.rB_Female = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_ID_Dep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_Birthday = new System.Windows.Forms.DateTimePicker();
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tB_ID_Em
            // 
            this.tB_ID_Em.Location = new System.Drawing.Point(182, 90);
            this.tB_ID_Em.Name = "tB_ID_Em";
            this.tB_ID_Em.Size = new System.Drawing.Size(100, 22);
            this.tB_ID_Em.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID_Employee";
            // 
            // tB_Name
            // 
            this.tB_Name.Location = new System.Drawing.Point(182, 157);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(100, 22);
            this.tB_Name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.rB_Female);
            this.groupbox1.Controls.Add(this.rB_Male);
            this.groupbox1.Location = new System.Drawing.Point(73, 227);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(229, 109);
            this.groupbox1.TabIndex = 2;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Gender";
            // 
            // rB_Male
            // 
            this.rB_Male.AutoSize = true;
            this.rB_Male.Location = new System.Drawing.Point(18, 35);
            this.rB_Male.Name = "rB_Male";
            this.rB_Male.Size = new System.Drawing.Size(57, 19);
            this.rB_Male.TabIndex = 0;
            this.rB_Male.TabStop = true;
            this.rB_Male.Text = "Male";
            this.rB_Male.UseVisualStyleBackColor = true;
            // 
            // rB_Female
            // 
            this.rB_Female.AutoSize = true;
            this.rB_Female.Location = new System.Drawing.Point(18, 75);
            this.rB_Female.Name = "rB_Female";
            this.rB_Female.Size = new System.Drawing.Size(73, 19);
            this.rB_Female.TabIndex = 0;
            this.rB_Female.TabStop = true;
            this.rB_Female.Text = "Female";
            this.rB_Female.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID_Department";
            // 
            // cbb_ID_Dep
            // 
            this.cbb_ID_Dep.FormattingEnabled = true;
            this.cbb_ID_Dep.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbb_ID_Dep.Location = new System.Drawing.Point(539, 153);
            this.cbb_ID_Dep.Name = "cbb_ID_Dep";
            this.cbb_ID_Dep.Size = new System.Drawing.Size(137, 23);
            this.cbb_ID_Dep.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birthday";
            // 
            // dt_Birthday
            // 
            this.dt_Birthday.Location = new System.Drawing.Point(539, 232);
            this.dt_Birthday.Name = "dt_Birthday";
            this.dt_Birthday.Size = new System.Drawing.Size(236, 22);
            this.dt_Birthday.TabIndex = 4;
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(182, 382);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(120, 42);
            this.bt_OK.TabIndex = 5;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(421, 382);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(117, 41);
            this.bt_cancel.TabIndex = 6;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.dt_Birthday);
            this.Controls.Add(this.cbb_ID_Dep);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_ID_Em);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_ID_Em;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.RadioButton rB_Female;
        private System.Windows.Forms.RadioButton rB_Male;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_ID_Dep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_Birthday;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_cancel;
    }
}