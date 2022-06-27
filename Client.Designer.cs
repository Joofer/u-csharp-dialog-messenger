namespace u14
{
    partial class Client
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
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelSendMessage = new System.Windows.Forms.Label();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.buttonSend1 = new System.Windows.Forms.Button();
            this.buttonSend2 = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessage.Location = new System.Drawing.Point(12, 29);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(776, 20);
            this.textBoxMessage.TabIndex = 0;
            // 
            // labelSendMessage
            // 
            this.labelSendMessage.AutoSize = true;
            this.labelSendMessage.Location = new System.Drawing.Point(13, 13);
            this.labelSendMessage.Name = "labelSendMessage";
            this.labelSendMessage.Size = new System.Drawing.Size(35, 13);
            this.labelSendMessage.TabIndex = 1;
            this.labelSendMessage.Text = "label1";
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.Location = new System.Drawing.Point(12, 84);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(776, 355);
            this.listBoxMessages.TabIndex = 2;
            // 
            // buttonSend1
            // 
            this.buttonSend1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend1.Location = new System.Drawing.Point(398, 55);
            this.buttonSend1.Name = "buttonSend1";
            this.buttonSend1.Size = new System.Drawing.Size(192, 23);
            this.buttonSend1.TabIndex = 3;
            this.buttonSend1.Text = "button1";
            this.buttonSend1.UseVisualStyleBackColor = true;
            this.buttonSend1.Click += new System.EventHandler(this.buttonSend1_Click);
            // 
            // buttonSend2
            // 
            this.buttonSend2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend2.Location = new System.Drawing.Point(596, 55);
            this.buttonSend2.Name = "buttonSend2";
            this.buttonSend2.Size = new System.Drawing.Size(192, 23);
            this.buttonSend2.TabIndex = 4;
            this.buttonSend2.Text = "button1";
            this.buttonSend2.UseVisualStyleBackColor = true;
            this.buttonSend2.Click += new System.EventHandler(this.buttonSend2_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(13, 55);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(35, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "label1";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonSend2);
            this.Controls.Add(this.buttonSend1);
            this.Controls.Add(this.listBoxMessages);
            this.Controls.Add(this.labelSendMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Name = "Client";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label labelSendMessage;
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.Button buttonSend1;
        private System.Windows.Forms.Button buttonSend2;
        private System.Windows.Forms.Label labelStatus;
    }
}

