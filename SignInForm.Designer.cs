
namespace ChatWithFile
{
    partial class SignInForm
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
            this.inputID = new System.Windows.Forms.TextBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.inputPW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputID
            // 
            this.inputID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputID.Location = new System.Drawing.Point(71, 65);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(200, 29);
            this.inputID.TabIndex = 0;
            this.inputID.UseWaitCursor = true;
            // 
            // btnSignin
            // 
            this.btnSignin.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSignin.Location = new System.Drawing.Point(277, 65);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(100, 64);
            this.btnSignin.TabIndex = 1;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.UseVisualStyleBackColor = true;
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSignup.Location = new System.Drawing.Point(126, 174);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(100, 30);
            this.btnSignup.TabIndex = 1;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFind.Location = new System.Drawing.Point(232, 174);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 30);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find ID/PW";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // inputPW
            // 
            this.inputPW.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputPW.Location = new System.Drawing.Point(71, 100);
            this.inputPW.Name = "inputPW";
            this.inputPW.Size = new System.Drawing.Size(200, 29);
            this.inputPW.TabIndex = 0;
            this.inputPW.UseWaitCursor = true;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.inputPW);
            this.Controls.Add(this.inputID);
            this.Name = "SignInForm";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox inputPW;
    }
}

