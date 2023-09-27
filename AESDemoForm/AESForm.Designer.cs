
namespace AESDemoForm
{
    partial class AESForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AESForm));
            this.gb = new System.Windows.Forms.GroupBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.btn_decode = new System.Windows.Forms.Button();
            this.gb_content = new System.Windows.Forms.GroupBox();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.gb_result = new System.Windows.Forms.GroupBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_encryption = new System.Windows.Forms.Button();
            this.btn_newKey = new System.Windows.Forms.Button();
            this.txt_keyLenght = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.gb_content.SuspendLayout();
            this.gb_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.txt_key);
            this.gb.Location = new System.Drawing.Point(13, 31);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(765, 113);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Text = "密钥";
            // 
            // txt_key
            // 
            this.txt_key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_key.Location = new System.Drawing.Point(3, 21);
            this.txt_key.Multiline = true;
            this.txt_key.Name = "txt_key";
            this.txt_key.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_key.Size = new System.Drawing.Size(759, 89);
            this.txt_key.TabIndex = 1;
            // 
            // btn_decode
            // 
            this.btn_decode.Location = new System.Drawing.Point(645, 427);
            this.btn_decode.Name = "btn_decode";
            this.btn_decode.Size = new System.Drawing.Size(132, 27);
            this.btn_decode.TabIndex = 1;
            this.btn_decode.Text = "解密";
            this.btn_decode.UseVisualStyleBackColor = true;
            this.btn_decode.Click += new System.EventHandler(this.btn_decode_Click);
            // 
            // gb_content
            // 
            this.gb_content.Controls.Add(this.txt_content);
            this.gb_content.Location = new System.Drawing.Point(15, 183);
            this.gb_content.Name = "gb_content";
            this.gb_content.Size = new System.Drawing.Size(765, 113);
            this.gb_content.TabIndex = 0;
            this.gb_content.TabStop = false;
            this.gb_content.Text = "内容";
            // 
            // txt_content
            // 
            this.txt_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_content.Location = new System.Drawing.Point(3, 21);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_content.Size = new System.Drawing.Size(759, 89);
            this.txt_content.TabIndex = 1;
            // 
            // gb_result
            // 
            this.gb_result.Controls.Add(this.txt_result);
            this.gb_result.Location = new System.Drawing.Point(15, 302);
            this.gb_result.Name = "gb_result";
            this.gb_result.Size = new System.Drawing.Size(765, 113);
            this.gb_result.TabIndex = 0;
            this.gb_result.TabStop = false;
            this.gb_result.Text = "结果";
            // 
            // txt_result
            // 
            this.txt_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_result.Location = new System.Drawing.Point(3, 21);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_result.Size = new System.Drawing.Size(759, 89);
            this.txt_result.TabIndex = 1;
            // 
            // btn_encryption
            // 
            this.btn_encryption.Location = new System.Drawing.Point(478, 427);
            this.btn_encryption.Name = "btn_encryption";
            this.btn_encryption.Size = new System.Drawing.Size(132, 27);
            this.btn_encryption.TabIndex = 1;
            this.btn_encryption.Text = "加密";
            this.btn_encryption.UseVisualStyleBackColor = true;
            this.btn_encryption.Click += new System.EventHandler(this.btn_encryption_Click);
            // 
            // btn_newKey
            // 
            this.btn_newKey.Location = new System.Drawing.Point(643, 150);
            this.btn_newKey.Name = "btn_newKey";
            this.btn_newKey.Size = new System.Drawing.Size(132, 27);
            this.btn_newKey.TabIndex = 1;
            this.btn_newKey.Text = "生成密钥";
            this.btn_newKey.UseVisualStyleBackColor = true;
            this.btn_newKey.Click += new System.EventHandler(this.btn_newKey_Click);
            // 
            // txt_keyLenght
            // 
            this.txt_keyLenght.Location = new System.Drawing.Point(533, 151);
            this.txt_keyLenght.Name = "txt_keyLenght";
            this.txt_keyLenght.Size = new System.Drawing.Size(100, 25);
            this.txt_keyLenght.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "密钥长度：";
            // 
            // AESForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_keyLenght);
            this.Controls.Add(this.btn_newKey);
            this.Controls.Add(this.btn_encryption);
            this.Controls.Add(this.btn_decode);
            this.Controls.Add(this.gb_result);
            this.Controls.Add(this.gb_content);
            this.Controls.Add(this.gb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AESForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.gb_content.ResumeLayout(false);
            this.gb_content.PerformLayout();
            this.gb_result.ResumeLayout(false);
            this.gb_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Button btn_decode;
        private System.Windows.Forms.GroupBox gb_content;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.GroupBox gb_result;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_encryption;
        private System.Windows.Forms.Button btn_newKey;
        private System.Windows.Forms.TextBox txt_keyLenght;
        private System.Windows.Forms.Label label1;
    }
}

