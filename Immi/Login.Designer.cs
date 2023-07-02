namespace Immi
{
    partial class Login
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lb_canhbao = new Label();
            btn_CanhTrangthai = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_password = new TextBox();
            txt_userName = new TextBox();
            Start = new Button();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 457);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lb_canhbao);
            tabPage1.Controls.Add(btn_CanhTrangthai);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txt_password);
            tabPage1.Controls.Add(txt_userName);
            tabPage1.Controls.Add(Start);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(793, 429);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Từ trang 1 đến 4";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_canhbao
            // 
            lb_canhbao.AutoSize = true;
            lb_canhbao.Location = new Point(561, 145);
            lb_canhbao.Name = "lb_canhbao";
            lb_canhbao.Size = new Size(38, 15);
            lb_canhbao.TabIndex = 9;
            lb_canhbao.Text = "label3";
            // 
            // btn_CanhTrangthai
            // 
            btn_CanhTrangthai.Location = new Point(561, 21);
            btn_CanhTrangthai.Name = "btn_CanhTrangthai";
            btn_CanhTrangthai.Size = new Size(223, 37);
            btn_CanhTrangthai.TabIndex = 8;
            btn_CanhTrangthai.Text = "Bắt đầu canh";
            btn_CanhTrangthai.UseVisualStyleBackColor = true;
            btn_CanhTrangthai.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(235, 18);
            button3.Name = "button3";
            button3.Size = new Size(89, 51);
            button3.TabIndex = 7;
            button3.Text = "Tắt loa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(142, 18);
            button2.Name = "button2";
            button2.Size = new Size(75, 51);
            button2.TabIndex = 6;
            button2.Text = "Thử loa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 148);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 108);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập :";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(105, 145);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(165, 23);
            txt_password.TabIndex = 2;
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(105, 105);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(165, 23);
            txt_userName.TabIndex = 1;
            // 
            // Start
            // 
            Start.Location = new Point(43, 18);
            Start.Name = "Start";
            Start.Size = new Size(83, 51);
            Start.TabIndex = 0;
            Start.Text = "Bắt đầu";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(793, 429);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button Start;
        private TabPage tabPage2;
        private Label label1;
        private TextBox txt_password;
        private TextBox txt_userName;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button btn_CanhTrangthai;
        private Label lb_canhbao;
    }
}