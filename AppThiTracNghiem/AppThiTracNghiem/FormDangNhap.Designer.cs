
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
            this.rdSinhvien = new System.Windows.Forms.RadioButton();
            this.rdGiangvien = new System.Windows.Forms.RadioButton();
            this.tENCSComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            tENCSLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdSinhvien
            // 
            this.rdSinhvien.AutoSize = true;
            this.rdSinhvien.Location = new System.Drawing.Point(339, 104);
            this.rdSinhvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdSinhvien.Name = "rdSinhvien";
            this.rdSinhvien.Size = new System.Drawing.Size(84, 21);
            this.rdSinhvien.TabIndex = 20;
            this.rdSinhvien.TabStop = true;
            this.rdSinhvien.Text = "Sinh viên";
            this.rdSinhvien.UseVisualStyleBackColor = true;
            // 
            // rdGiangvien
            // 
            this.rdGiangvien.AutoSize = true;
            this.rdGiangvien.Location = new System.Drawing.Point(182, 104);
            this.rdGiangvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdGiangvien.Name = "rdGiangvien";
            this.rdGiangvien.Size = new System.Drawing.Size(92, 21);
            this.rdGiangvien.TabIndex = 19;
            this.rdGiangvien.TabStop = true;
            this.rdGiangvien.Text = "Giảng viên";
            this.rdGiangvien.UseVisualStyleBackColor = true;
            // 
            // tENCSLabel
            // 
            tENCSLabel.AutoSize = true;
            tENCSLabel.Location = new System.Drawing.Point(136, 72);
            tENCSLabel.Name = "tENCSLabel";
            tENCSLabel.Size = new System.Drawing.Size(73, 17);
            tENCSLabel.TabIndex = 16;
            tENCSLabel.Text = "Tên cơ sở:";
            // 
            // tENCSComboBox
            // 
            this.tENCSComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tENCSComboBox.FormattingEnabled = true;
            this.tENCSComboBox.Location = new System.Drawing.Point(240, 69);
            this.tENCSComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tENCSComboBox.Name = "tENCSComboBox";
            this.tENCSComboBox.Size = new System.Drawing.Size(140, 24);
            this.tENCSComboBox.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 217);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(245, 174);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(138, 23);
            this.txtPass.TabIndex = 14;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(244, 138);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(139, 23);
            this.txtLogin.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 317);
            this.Controls.Add(this.rdSinhvien);
            this.Controls.Add(this.rdGiangvien);
            this.Controls.Add(tENCSLabel);
            this.Controls.Add(this.tENCSComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdSinhvien;
        private System.Windows.Forms.RadioButton rdGiangvien;
        private System.Windows.Forms.ComboBox tENCSComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}