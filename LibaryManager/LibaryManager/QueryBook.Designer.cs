namespace LibaryManager
{
    partial class QueryBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.BkID_query = new System.Windows.Forms.TextBox();
            this.BkQuery_result = new System.Windows.Forms.TextBox();
            this.Bt_query = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BK_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(126, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书ID";
            // 
            // BkID_query
            // 
            this.BkID_query.Location = new System.Drawing.Point(226, 20);
            this.BkID_query.Name = "BkID_query";
            this.BkID_query.Size = new System.Drawing.Size(144, 21);
            this.BkID_query.TabIndex = 1;
            this.BkID_query.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BkQuery_result
            // 
            this.BkQuery_result.Location = new System.Drawing.Point(129, 106);
            this.BkQuery_result.Multiline = true;
            this.BkQuery_result.Name = "BkQuery_result";
            this.BkQuery_result.ReadOnly = true;
            this.BkQuery_result.Size = new System.Drawing.Size(329, 121);
            this.BkQuery_result.TabIndex = 2;
            // 
            // Bt_query
            // 
            this.Bt_query.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bt_query.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Bt_query.Location = new System.Drawing.Point(261, 253);
            this.Bt_query.Name = "Bt_query";
            this.Bt_query.Size = new System.Drawing.Size(75, 23);
            this.Bt_query.TabIndex = 3;
            this.Bt_query.Text = "查询";
            this.Bt_query.UseVisualStyleBackColor = true;
            this.Bt_query.Click += new System.EventHandler(this.Bt_query_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(129, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "图书名";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BK_Name
            // 
            this.BK_Name.Location = new System.Drawing.Point(226, 60);
            this.BK_Name.Name = "BK_Name";
            this.BK_Name.Size = new System.Drawing.Size(144, 21);
            this.BK_Name.TabIndex = 5;
            // 
            // QueryBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 455);
            this.Controls.Add(this.BK_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bt_query);
            this.Controls.Add(this.BkQuery_result);
            this.Controls.Add(this.BkID_query);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QueryBook";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QueryBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BkID_query;
        private System.Windows.Forms.TextBox BkQuery_result;
        private System.Windows.Forms.Button Bt_query;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BK_Name;
    }
}