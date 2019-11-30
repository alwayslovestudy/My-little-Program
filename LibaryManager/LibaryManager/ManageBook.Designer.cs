namespace LibaryManager
{
    partial class ManageBook
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BkID = new System.Windows.Forms.TextBox();
            this.BkName = new System.Windows.Forms.TextBox();
            this.StoreNum = new System.Windows.Forms.TextBox();
            this.BorrowNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.Bt_Add = new System.Windows.Forms.Button();
            this.Bt_Del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "书名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "在馆数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "外借数";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BkID
            // 
            this.BkID.Location = new System.Drawing.Point(180, 32);
            this.BkID.Name = "BkID";
            this.BkID.Size = new System.Drawing.Size(162, 21);
            this.BkID.TabIndex = 4;
            // 
            // BkName
            // 
            this.BkName.Location = new System.Drawing.Point(180, 88);
            this.BkName.Name = "BkName";
            this.BkName.Size = new System.Drawing.Size(162, 21);
            this.BkName.TabIndex = 5;
            // 
            // StoreNum
            // 
            this.StoreNum.Location = new System.Drawing.Point(180, 138);
            this.StoreNum.Name = "StoreNum";
            this.StoreNum.Size = new System.Drawing.Size(162, 21);
            this.StoreNum.TabIndex = 6;
            // 
            // BorrowNum
            // 
            this.BorrowNum.Location = new System.Drawing.Point(180, 188);
            this.BorrowNum.Name = "BorrowNum";
            this.BorrowNum.Size = new System.Drawing.Size(162, 21);
            this.BorrowNum.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "位置";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(180, 237);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(162, 21);
            this.Location.TabIndex = 9;
            // 
            // Bt_Add
            // 
            this.Bt_Add.Location = new System.Drawing.Point(180, 289);
            this.Bt_Add.Name = "Bt_Add";
            this.Bt_Add.Size = new System.Drawing.Size(162, 23);
            this.Bt_Add.TabIndex = 10;
            this.Bt_Add.Text = "增加";
            this.Bt_Add.UseVisualStyleBackColor = true;
            this.Bt_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bt_Del
            // 
            this.Bt_Del.Location = new System.Drawing.Point(180, 334);
            this.Bt_Del.Name = "Bt_Del";
            this.Bt_Del.Size = new System.Drawing.Size(162, 23);
            this.Bt_Del.TabIndex = 11;
            this.Bt_Del.Text = "删除(只需ID)";
            this.Bt_Del.UseVisualStyleBackColor = true;
            this.Bt_Del.Click += new System.EventHandler(this.Bt_Del_Click);
            // 
            // ManageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.Bt_Del);
            this.Controls.Add(this.Bt_Add);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BorrowNum);
            this.Controls.Add(this.StoreNum);
            this.Controls.Add(this.BkName);
            this.Controls.Add(this.BkID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageBook";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " 增加/删除";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BkID;
        private System.Windows.Forms.TextBox BkName;
        private System.Windows.Forms.TextBox StoreNum;
        private System.Windows.Forms.TextBox BorrowNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Button Bt_Add;
        private System.Windows.Forms.Button Bt_Del;
    }
}