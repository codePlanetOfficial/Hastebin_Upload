namespace Hastebin_Upload
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.server_url = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_box_multiline = new System.Windows.Forms.TextBox();
            this.upload_btn = new System.Windows.Forms.Button();
            this.display_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // server_url
            // 
            this.server_url.Location = new System.Drawing.Point(98, 13);
            this.server_url.Name = "server_url";
            this.server_url.Size = new System.Drawing.Size(324, 22);
            this.server_url.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server URL:";
            // 
            // text_box_multiline
            // 
            this.text_box_multiline.Location = new System.Drawing.Point(15, 67);
            this.text_box_multiline.Multiline = true;
            this.text_box_multiline.Name = "text_box_multiline";
            this.text_box_multiline.Size = new System.Drawing.Size(407, 353);
            this.text_box_multiline.TabIndex = 3;
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(12, 426);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(410, 44);
            this.upload_btn.TabIndex = 4;
            this.upload_btn.Text = "Upload";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // display_textbox
            // 
            this.display_textbox.Location = new System.Drawing.Point(12, 476);
            this.display_textbox.Name = "display_textbox";
            this.display_textbox.ReadOnly = true;
            this.display_textbox.Size = new System.Drawing.Size(410, 22);
            this.display_textbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Your Text Here:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Location = new System.Drawing.Point(-32, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 78);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.display_textbox);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.text_box_multiline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.server_url);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hastebin Uploader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox server_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_box_multiline;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.TextBox display_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

