
namespace ChatWithFile
{
    partial class ChatForm
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
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.inputMsg = new System.Windows.Forms.TextBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.chatList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(499, 383);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 29);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "전송";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // inputMsg
            // 
            this.inputMsg.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputMsg.Location = new System.Drawing.Point(93, 383);
            this.inputMsg.Name = "inputMsg";
            this.inputMsg.Size = new System.Drawing.Size(400, 29);
            this.inputMsg.TabIndex = 0;
            this.inputMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputMsg_KeyPress);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(12, 383);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 29);
            this.btnAddFile.TabIndex = 2;
            this.btnAddFile.Text = "파일";
            this.btnAddFile.UseVisualStyleBackColor = true;
            // 
            // chatList
            // 
            this.chatList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chatList.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.chatList.Location = new System.Drawing.Point(12, 12);
            this.chatList.Name = "chatList";
            this.chatList.ReadOnly = true;
            this.chatList.Size = new System.Drawing.Size(562, 365);
            this.chatList.TabIndex = 4;
            this.chatList.TabStop = false;
            this.chatList.Text = "";
            this.chatList.Enter += new System.EventHandler(this.chatList_Enter);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chatList);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.inputMsg);
            this.Controls.Add(this.btnSendMsg);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox inputMsg;
        private System.Windows.Forms.Button btnAddFile;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.RichTextBox chatList;
    }
}