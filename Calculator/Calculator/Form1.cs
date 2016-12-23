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
        // private double[] stack = new double[10];    // infix stack 연산용 저장공간 생각중
        // System.Windows.Forms.RichTextBox textbox_current;   // 맨 위의 stack

        String operation = null;
        bool b_op = false;
        bool b_cal_start = false;
        bool b_equal = false;
        Double value = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        // 장수진
        // 2016/12/22
        // 숫자는 숫자끼리 연산자는 연산자끼리 묶어 처리하고자 합니다. (연산에 숫자를 두 개 밖에 이용할 수 없는 부분 수정필요)
        private void ClickNum(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textbox_result.Text == "0" || b_op || b_equal)
            {
                textbox_result.Clear();
                b_op = false;
                b_equal = false;
            }
            textbox_result.Text += b.Text;
        }

        private void ClickOp(object sender, EventArgs e)
        {
            if (operation != null)
            {
                switch (operation)
                {
                    case "+":
                        value = function.Add(value, Double.Parse(textbox_result.Text));
                        break;
                    case "-":
                        value = function.Sub(value, Double.Parse(textbox_result.Text));
                        break;
                    case "*":
                        value = function.Mul(value, Double.Parse(textbox_result.Text));
                        break;
                    case "/":
                        value = function.Div(value, Double.Parse(textbox_result.Text));
                        break;
                    case "%":
                        value = function.Mod(value, Double.Parse(textbox_result.Text));
                        break;
                }
                operation = null;
            }
            Button b = (Button)sender;
            operation = b.Text;
            if (!b_cal_start)
            {
                value = Double.Parse(textbox_result.Text);
                b_cal_start = true;
            }
            b_op = true;
            b_equal = false;
            textbox_process.Text += textbox_result.Text + " " + operation + " ";
            textbox_result.Text = value.ToString();
        }

        private void ClickReciprocal(object sender, EventArgs e)
        {
            textbox_process.Clear();
            textbox_result.Text = function.Rec(Double.Parse(textbox_result.Text)).ToString();
            b_equal = true;
        }

        private void ClickEqual(object sender, EventArgs e)
        {
            textbox_process.Clear();
            switch (operation)
            {
                case "+":
                    value = function.Add(value, Double.Parse(textbox_result.Text));
                    break;
                case "-":
                    value = function.Sub(value, Double.Parse(textbox_result.Text));
                    break;
                case "*":
                    value = function.Mul(value, Double.Parse(textbox_result.Text));
                    break;
                case "/":
                    value = function.Div(value, Double.Parse(textbox_result.Text));
                    break;
                case "%":
                    value = function.Mod(value, Double.Parse(textbox_result.Text));
                    break;
            }
            textbox_result.Text = value.ToString();
            b_equal = true;
        }

        //장수진
        // 2016/12/22
        //키가 입력되면 키버튼에 대응하는 클릭 이벤트가 실행됩니다.
        private void PressKey(object sender, KeyPressEventArgs e)
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




    public static class function
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mul(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }
        public static double Mod(double a, double b)
        {
            return a % b;
        }
        public static double Rec(double x)
        {
            return 1/x;
        }
    }
}
