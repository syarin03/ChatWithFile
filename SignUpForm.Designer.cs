
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
            this.SuspendLayout();
            // 
            // inputPW
            // 
            this.inputPW.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputPW.Location = new System.Drawing.Point(78, 105);
            this.inputPW.Name = "inputPW";
            this.inputPW.Size = new System.Drawing.Size(200, 29);
            this.inputPW.TabIndex = 1;
            this.inputPW.UseWaitCursor = true;
            // 
            // inputID
            // 
            this.inputID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputID.Location = new System.Drawing.Point(78, 70);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(200, 29);
            this.inputID.TabIndex = 2;
            this.inputID.UseWaitCursor = true;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputPW);
            this.Controls.Add(this.inputID);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPW;
        private System.Windows.Forms.TextBox inputID;
    }
}