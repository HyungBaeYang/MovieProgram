namespace 회원_로그인_Test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID_Text = new System.Windows.Forms.TextBox();
            this.PW_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.NewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_Text
            // 
            this.ID_Text.Location = new System.Drawing.Point(183, 86);
            this.ID_Text.Name = "ID_Text";
            this.ID_Text.Size = new System.Drawing.Size(100, 21);
            this.ID_Text.TabIndex = 0;
            this.ID_Text.TextChanged += new System.EventHandler(this.ID_Text_TextChanged);
            // 
            // PW_Text
            // 
            this.PW_Text.Location = new System.Drawing.Point(183, 117);
            this.PW_Text.Name = "PW_Text";
            this.PW_Text.Size = new System.Drawing.Size(100, 21);
            this.PW_Text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "아이디";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(122, 165);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(87, 44);
            this.Login.TabIndex = 4;
            this.Login.Text = "로그인";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // NewUser
            // 
            this.NewUser.Location = new System.Drawing.Point(215, 165);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(87, 44);
            this.NewUser.TabIndex = 5;
            this.NewUser.Text = "회원가입";
            this.NewUser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PW_Text);
            this.Controls.Add(this.ID_Text);
            this.Name = "Form1";
            this.Text = "로그인창";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_Text;
        private System.Windows.Forms.TextBox PW_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button NewUser;
    }
}

