using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
// 김효상
// 2016/12/22
// 계산기 기본 폼 짰습니다. 여기에 맞게 함수 구현하면 되겠습니다.
/// </summary>
namespace practiceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void number_1_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "1";
        }

        private void number_2_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "2";
        }

        private void number_3_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "3";
        }

        private void number_4_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "4";
        }

        private void number_5_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "5";
        }

        private void number_6_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "6";
        }

        private void number_7_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "7";
        }

        private void number_8_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "8";
        }

        private void number_9_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "9";
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "-";
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "*";
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "/";
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "%";
        }

        private void button_rev_Click(object sender, EventArgs e)
        {
            // 임시. 수정필요
            textbox_process.Text = "1/(" + textbox_process.Text + ")";
        }

        private void button_equ_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "0";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "+";
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            textbox_process.Text += ".";
        }
        
        private void number_0_Click(object sender, EventArgs e)
        {
            textbox_process.Text += "0";
        }

        // 장수진
        // 2016/12/22
        // 키가 입력되면 키버튼에 대응하는 클릭 이벤트가 실행됩니다.
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return||e.KeyChar.ToString()=="=")
            {
                button_equ.PerformClick();
            }
            else switch (e.KeyChar.ToString())
            {
               
                case "0":
                    number_0.PerformClick();
                    break;
                case "1":
                    number_1.PerformClick();
                    break;
                case "2":
                    number_2.PerformClick();
                    break;
                case "3":
                    number_3.PerformClick();
                    break;
                case "4":
                    number_4.PerformClick();
                    break;
                case "5":
                    number_5.PerformClick();
                    break;
                case "6":
                    number_6.PerformClick();
                    break;
                case "7":
                    number_7.PerformClick();
                    break;
                case "8":
                    number_8.PerformClick();
                    break;
                case "9":
                    number_9.PerformClick();
                    break;
                case "/":
                    button_div.PerformClick();
                    break;
                case "*":
                    button_mul.PerformClick();
                    break;
                case "-":
                    button_sub.PerformClick();
                    break;
                case "%":
                    button_mod.PerformClick();
                    break;
                case "r":
                    button_rev.PerformClick();
                    break;
                case ".":
                     button_point.PerformClick();
                    break;
                case "+":
                    button_add.PerformClick();
                    break;
            }
        }
    }




    public class function
    {
      
    }
}
