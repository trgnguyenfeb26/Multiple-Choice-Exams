
namespace AppThiTracNghiem
{
    partial class FormDangNhap
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
            System.Windows.Forms.Label tENCSLabel;
            this.rdbSV = new System.Windows.Forms.RadioButton();
            this.rdbGV = new System.Windows.Forms.RadioButton();
            this.cbbTenCS = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            tENCSLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tENCSLabel
            // 
            tENCSLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            tENCSLabel.AutoSize = true;
            tENCSLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            tENCSLabel.Location = new System.Drawing.Point(257, 42);
            tENCSLabel.Name = "tENCSLabel";
            tENCSLabel.Size = new System.Drawing.Size(131, 30);
            tENCSLabel.TabIndex = 16;
            tENCSLabel.Text = "Tên cơ sở:";
            // 
            // rdbSV
            // 
            this.rdbSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbSV.AutoSize = true;
            this.rdbSV.Checked = true;
            this.rdbSV.Font = new System.Drawing.Font("Tahoma", 15F);
            this.rdbSV.Location = new System.Drawing.Point(521, 99);
            this.rdbSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbSV.Name = "rdbSV";
            this.rdbSV.Size = new System.Drawing.Size(135, 34);
            this.rdbSV.TabIndex = 20;
            this.rdbSV.TabStop = true;
            this.rdbSV.Text = "Sinh viên";
            this.rdbSV.UseVisualStyleBackColor = true;
            this.rdbSV.CheckedChanged += new System.EventHandler(this.rdbSV_CheckedChanged);
            // 
            // rdbGV
            // 
            this.rdbGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbGV.AutoSize = true;
            this.rdbGV.Font = new System.Drawing.Font("Tahoma", 15F);
            this.rdbGV.Location = new System.Drawing.Point(291, 99);
            this.rdbGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbGV.Name = "rdbGV";
            this.rdbGV.Size = new System.Drawing.Size(151, 34);
            this.rdbGV.TabIndex = 19;
            this.rdbGV.TabStop = true;
            this.rdbGV.Text = "Giảng viên";
            this.rdbGV.UseVisualStyleBackColor = true;
            this.rdbGV.CheckedChanged += new System.EventHandler(this.rdbGV_CheckedChanged);
            // 
            // cbbTenCS
            // 
            this.cbbTenCS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbTenCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenCS.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cbbTenCS.FormattingEnabled = true;
            this.cbbTenCS.Location = new System.Drawing.Point(394, 34);
            this.cbbTenCS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbTenCS.Name = "cbbTenCS";
            this.cbbTenCS.Size = new System.Drawing.Size(229, 38);
            this.cbbTenCS.TabIndex = 18;
            this.cbbTenCS.SelectedIndexChanged += new System.EventHandler(this.cbbTenCS_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnThoat.Location = new System.Drawing.Point(487, 317);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(190, 50);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnDangNhap.Location = new System.Drawing.Point(236, 317);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(190, 50);
            this.btnDangNhap.TabIndex = 15;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtPassword.Location = new System.Drawing.Point(394, 224);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(229, 38);
            this.txtPassword.TabIndex = 14;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLogin.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtLogin.Location = new System.Drawing.Point(394, 161);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(229, 38);
            this.txtLogin.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(257, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(257, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã số SV:";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 460);
            this.Controls.Add(this.rdbSV);
            this.Controls.Add(this.rdbGV);
            this.Controls.Add(tENCSLabel);
            this.Controls.Add(this.cbbTenCS);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbSV;
        private System.Windows.Forms.RadioButton rdbGV;
        private System.Windows.Forms.ComboBox cbbTenCS;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}