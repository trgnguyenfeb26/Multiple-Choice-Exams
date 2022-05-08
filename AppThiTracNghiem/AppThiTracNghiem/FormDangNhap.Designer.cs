
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
            this.button2 = new System.Windows.Forms.Button();
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
            tENCSLabel.AutoSize = true;
            tENCSLabel.Location = new System.Drawing.Point(342, 67);
            tENCSLabel.Name = "tENCSLabel";
            tENCSLabel.Size = new System.Drawing.Size(73, 17);
            tENCSLabel.TabIndex = 16;
            tENCSLabel.Text = "Tên cơ sở:";
            // 
            // rdbSV
            // 
            this.rdbSV.AutoSize = true;
            this.rdbSV.Location = new System.Drawing.Point(545, 99);
            this.rdbSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbSV.Name = "rdbSV";
            this.rdbSV.Size = new System.Drawing.Size(84, 21);
            this.rdbSV.TabIndex = 20;
            this.rdbSV.TabStop = true;
            this.rdbSV.Text = "Sinh viên";
            this.rdbSV.UseVisualStyleBackColor = true;
            // 
            // rdbGV
            // 
            this.rdbGV.AutoSize = true;
            this.rdbGV.Location = new System.Drawing.Point(388, 99);
            this.rdbGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbGV.Name = "rdbGV";
            this.rdbGV.Size = new System.Drawing.Size(92, 21);
            this.rdbGV.TabIndex = 19;
            this.rdbGV.TabStop = true;
            this.rdbGV.Text = "Giảng viên";
            this.rdbGV.UseVisualStyleBackColor = true;
            // 
            // cbbTenCS
            // 
            this.cbbTenCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenCS.FormattingEnabled = true;
            this.cbbTenCS.Location = new System.Drawing.Point(446, 64);
            this.cbbTenCS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbTenCS.Name = "cbbTenCS";
            this.cbbTenCS.Size = new System.Drawing.Size(140, 24);
            this.cbbTenCS.TabIndex = 18;
            this.cbbTenCS.SelectedIndexChanged += new System.EventHandler(this.cbbTenCS_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 212);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(388, 212);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(87, 28);
            this.btnDangNhap.TabIndex = 15;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(451, 169);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(138, 23);
            this.txtPassword.TabIndex = 14;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(450, 133);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(139, 23);
            this.txtLogin.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 326);
            this.Controls.Add(this.rdbSV);
            this.Controls.Add(this.rdbGV);
            this.Controls.Add(tENCSLabel);
            this.Controls.Add(this.cbbTenCS);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}