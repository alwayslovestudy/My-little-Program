namespace LibaryManager
{
    partial class Log
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label username;
            this.username_tx = new System.Windows.Forms.TextBox();
            this.Pw_tx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginIn_Bt = new System.Windows.Forms.Button();
            this.Reg_Bt = new System.Windows.Forms.Button();
            username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new System.Drawing.Point(49, 85);
            username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            username.Name = "username";
            username.Size = new System.Drawing.Size(52, 15);
            username.TabIndex = 2;
            username.Text = "用户名";
            // 
            // username_tx
            // 
            this.username_tx.Location = new System.Drawing.Point(133, 81);
            this.username_tx.Margin = new System.Windows.Forms.Padding(4);
            this.username_tx.Name = "username_tx";
            this.username_tx.Size = new System.Drawing.Size(132, 25);
            this.username_tx.TabIndex = 0;
            // 
            // Pw_tx
            // 
            this.Pw_tx.Location = new System.Drawing.Point(133, 159);
            this.Pw_tx.Margin = new System.Windows.Forms.Padding(4);
            this.Pw_tx.Name = "Pw_tx";
            this.Pw_tx.Size = new System.Drawing.Size(132, 25);
            this.Pw_tx.TabIndex = 1;
            this.Pw_tx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginIn_Bt
            // 
            this.LoginIn_Bt.Location = new System.Drawing.Point(85, 271);
            this.LoginIn_Bt.Margin = new System.Windows.Forms.Padding(4);
            this.LoginIn_Bt.Name = "LoginIn_Bt";
            this.LoginIn_Bt.Size = new System.Drawing.Size(100, 29);
            this.LoginIn_Bt.TabIndex = 4;
            this.LoginIn_Bt.Text = "登录";
            this.LoginIn_Bt.UseVisualStyleBackColor = true;
            this.LoginIn_Bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reg_Bt
            // 
            this.Reg_Bt.Location = new System.Drawing.Point(236, 271);
            this.Reg_Bt.Margin = new System.Windows.Forms.Padding(4);
            this.Reg_Bt.Name = "Reg_Bt";
            this.Reg_Bt.Size = new System.Drawing.Size(100, 29);
            this.Reg_Bt.TabIndex = 5;
            this.Reg_Bt.Text = "注册";
            this.Reg_Bt.UseVisualStyleBackColor = true;
            this.Reg_Bt.Click += new System.EventHandler(this.Reg_Bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 426);
            this.Controls.Add(this.Reg_Bt);
            this.Controls.Add(this.LoginIn_Bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(username);
            this.Controls.Add(this.Pw_tx);
            this.Controls.Add(this.username_tx);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_tx;
        private System.Windows.Forms.TextBox Pw_tx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginIn_Bt;
        private System.Windows.Forms.Button Reg_Bt;
    }
}

