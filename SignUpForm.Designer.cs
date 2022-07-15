
namespace ChatWithFile
{
    partial class SignUpForm
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
            this.inputPW = new System.Windows.Forms.TextBox();
            this.inputID = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputPhone = new System.Windows.Forms.TextBox();
            this.inputChkPW = new System.Windows.Forms.TextBox();
            this.btnChkID = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputPW
            // 
            this.inputPW.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputPW.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputPW.Location = new System.Drawing.Point(78, 105);
            this.inputPW.Name = "inputPW";
            this.inputPW.Size = new System.Drawing.Size(200, 29);
            this.inputPW.TabIndex = 2;
            this.inputPW.Tag = "비밀번호";
            this.inputPW.Enter += new System.EventHandler(this.inputPW_Enter);
            this.inputPW.Leave += new System.EventHandler(this.inputPW_Leave);
            // 
            // inputID
            // 
            this.inputID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputID.Location = new System.Drawing.Point(78, 70);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(200, 29);
            this.inputID.TabIndex = 0;
            this.inputID.Tag = "아이디";
            this.inputID.Enter += new System.EventHandler(this.inputID_Enter);
            this.inputID.Leave += new System.EventHandler(this.inputID_Leave);
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputName.Location = new System.Drawing.Point(78, 175);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(200, 29);
            this.inputName.TabIndex = 4;
            this.inputName.Tag = "이름";
            this.inputName.Enter += new System.EventHandler(this.inputName_Enter);
            this.inputName.Leave += new System.EventHandler(this.inputName_Leave);
            // 
            // inputPhone
            // 
            this.inputPhone.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputPhone.Location = new System.Drawing.Point(78, 210);
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.Size = new System.Drawing.Size(200, 29);
            this.inputPhone.TabIndex = 5;
            this.inputPhone.Tag = "전화번호";
            this.inputPhone.Enter += new System.EventHandler(this.inputPhone_Enter);
            this.inputPhone.Leave += new System.EventHandler(this.inputPhone_Leave);
            // 
            // inputChkPW
            // 
            this.inputChkPW.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputChkPW.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputChkPW.Location = new System.Drawing.Point(78, 140);
            this.inputChkPW.Name = "inputChkPW";
            this.inputChkPW.Size = new System.Drawing.Size(200, 29);
            this.inputChkPW.TabIndex = 3;
            this.inputChkPW.Tag = "비밀번호 확인";
            this.inputChkPW.Enter += new System.EventHandler(this.inputChkPW_Enter);
            this.inputChkPW.Leave += new System.EventHandler(this.inputChkPW_Leave);
            // 
            // btnChkID
            // 
            this.btnChkID.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnChkID.Location = new System.Drawing.Point(284, 70);
            this.btnChkID.Name = "btnChkID";
            this.btnChkID.Size = new System.Drawing.Size(80, 29);
            this.btnChkID.TabIndex = 1;
            this.btnChkID.Text = "중복 확인";
            this.btnChkID.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.btnSignUp.Location = new System.Drawing.Point(178, 245);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 30);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnChkID);
            this.Controls.Add(this.inputPhone);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputChkPW);
            this.Controls.Add(this.inputPW);
            this.Controls.Add(this.inputID);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPW;
        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputPhone;
        private System.Windows.Forms.TextBox inputChkPW;
        private System.Windows.Forms.Button btnChkID;
        private System.Windows.Forms.Button btnSignUp;
    }
}