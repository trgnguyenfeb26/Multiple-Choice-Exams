
namespace AppThiTracNghiem
{
    partial class FormDoiMK
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDMK = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMK
            // 
            this.txtMK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMK.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtMK.Location = new System.Drawing.Point(346, 86);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(229, 38);
            this.txtMK.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(183, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // txtMKM
            // 
            this.txtMKM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMKM.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtMKM.Location = new System.Drawing.Point(346, 162);
            this.txtMKM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '*';
            this.txtMKM.Size = new System.Drawing.Size(229, 38);
            this.txtMKM.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(168, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mật khẩu mới:";
            // 
            // txtXN
            // 
            this.txtXN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtXN.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtXN.Location = new System.Drawing.Point(346, 242);
            this.txtXN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXN.Name = "txtXN";
            this.txtXN.PasswordChar = '*';
            this.txtXN.Size = new System.Drawing.Size(229, 38);
            this.txtXN.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(116, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.Location = new System.Drawing.Point(328, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "ĐỔI MẬT KHẨU";
            // 
            // btnDMK
            // 
            this.btnDMK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDMK.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMK.Location = new System.Drawing.Point(180, 326);
            this.btnDMK.Name = "btnDMK";
            this.btnDMK.Size = new System.Drawing.Size(160, 52);
            this.btnDMK.TabIndex = 22;
            this.btnDMK.Text = "Xác nhận";
            this.btnDMK.UseVisualStyleBackColor = true;
            this.btnDMK.Click += new System.EventHandler(this.btnDMK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(487, 326);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(160, 52);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 421);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtXN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label2);
            this.Name = "FormDoiMK";
            this.Text = "Đổi mật khẩu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDMK;
        private System.Windows.Forms.Button btnHuy;
    }
}