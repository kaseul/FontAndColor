using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FontAndColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TsbtnFont_Click(object sender, EventArgs e)
        {
            DialogResult result = this.fontDlg.ShowDialog();

            switch(result)
            {
                case DialogResult.OK:
                    // this.rtbText.Font = this.fontDlg.Font; // 전체 글자 폰트 바꾸기
                    this.rtbText.SelectionFont = this.fontDlg.Font; // 사용자가 드래그 한 부분만 폰트 바꾸기
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("폰트 변경을 취소했어요", "알림");
                    break;
            }
        }

        private void TsbtnColor_Click(object sender, EventArgs e)
        {
            DialogResult result = this.colorDlg.ShowDialog();
            
            switch(result)
            {
                case DialogResult.OK:
                    this.rtbText.SelectionColor = this.colorDlg.Color;
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("색 변경을 취소했네요", "알림");
                    break;
            }
        }
    }
}
