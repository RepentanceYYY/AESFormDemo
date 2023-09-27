using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESDemoForm
{
    public partial class AESForm : Form
    {
        public AESForm()
        {
            InitializeComponent();
        }

        private void btn_newKey_Click(object sender, EventArgs e)
        {
            try
            {
                int len;
                if (string.IsNullOrWhiteSpace(this.txt_keyLenght.Text))
                {
                    throw new Exception("密钥长度不能为空");
                }
                if(!Regex.IsMatch(this.txt_keyLenght.Text, @"^[0-9]+$"))
                {
                    throw new Exception("密钥格式无效");
                }
                else
                {
                    len = Convert.ToInt32(this.txt_keyLenght.Text);
                    if (len <= 0)
                    {
                        throw new Exception("密钥长度无效");
                    }
                }
                this.txt_key.Text = Convert.ToBase64String(AESHelper.GetIv(len));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示");
            }
        }

        private void btn_encryption_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_result.Text = AESHelper.AESEncrypt(this.txt_content.Text, this.txt_key.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示");
            }
            
        }

        private void btn_decode_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_result.Text = AESHelper.AESDecrypt(this.txt_content.Text, this.txt_key.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示");
            }
        }
    }
}
