using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 김효상
// 2017/1/4
// 저장 위한 IO 삽입
using System.IO;
/// <summary>
// 김효상
// 2016/12/22
// 계산기 기본 폼 짰습니다. 여기에 맞게 함수 구현하면 되겠습니다.
/// </summary>
namespace practiceCalculator
{
    public partial class Form1 : Form
    {

        String operation = null;    // 연산자 기호
        bool b_op = false;  // 현재 식에 연산자가 하나라도 있는지 확인
        bool b_equal = false;   // 마지막 연산이 =였는지 확인
        bool b_history = false; // 히스토리 기록 접근 시 또 다시 히스토리에 기록을 생성하는 것을 방지
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
            {   // 결과박스에 0밖에 없을 때 or 진행박스의 마지막이 연산자일때 or 막 =를 이용하여 계산을 끝냈던 참일 때
                textbox_result.Clear(); // 새로 입력
                b_op = false;
                b_equal = false;
            }
            textbox_result.Text += b.Text;
        }

        private void ClickOp(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b_op) // 연산자를 다시 입력했을 시 기존 연산자를 교체
            {
                String temp = textbox_process.Text;
                temp = temp.Remove(temp.LastIndexOf(operation), 2);

                operation = b.Text;

                textbox_process.Text = temp + operation + " ";
            }
            else {
                if (operation != null && !b_equal)  // 이미 연산자가 있을 경우 처리하여 결과박스를 갱신
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
                }
                else
                    value = Double.Parse(textbox_result.Text);  // 결과박스의 값을 value에 그대로 입력(초기값)
                if (!b_op)
                {
                    operation = b.Text;
                    textbox_process.Text += textbox_result.Text + " " + operation + " ";
                    textbox_result.Text = value.ToString();
                    b_op = true;
                    b_equal = false;
                }
            }
        }

        private void ClickReciprocal(object sender, EventArgs e)
        {
            textbox_process.Clear();
            listbox_history.Items.Add("1/("+textbox_result.Text+")");
            textbox_result.Text = function.Rec(Double.Parse(textbox_result.Text)).ToString();
            b_equal = true;
        }

        private void ClickEqual(object sender, EventArgs e)
        {
            if (operation == null){
                if (!b_history) listbox_history.Items.Add(textbox_result.Text);
                value = Double.Parse(textbox_result.Text);
            }
            else
            {
                if (!b_history) listbox_history.Items.Add(textbox_process.Text + textbox_result.Text);
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
                textbox_result.Text = value.ToString();
                textbox_process.Clear();
            }
            b_op = false;
            b_equal = true;
            b_history = false;
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

        //장수진
        // 2016/1/3
        // 위아래 화살표 버튼이벤트
        private void button_up_Click(object sender, EventArgs e)
        {
            try {
                listbox_history.SelectedIndex--;
                listbox_history_Click(sender, e);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                // nothing
            }
        }
        private void button_down_Click(object sender, EventArgs e)
        {
            try
            {
                listbox_history.SelectedIndex++;
                listbox_history_Click(sender, e);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                // nothing
            }
        }

        private void listbox_history_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listbox_history_Click(object sender, EventArgs e)
        {
            textbox_result.Clear();
            value = 0;
            b_history = true;
            // 작성자 : 전수영
            // 2017/1/3
            // 아무것도 선택 안되었을 때의 예외 처리
            if (listbox_history.SelectedIndex == -1)
                return;
            String temp = listbox_history.SelectedItem.ToString();
            for (int i = 0, len = temp.Length; i < len; i++)
            {
                if (temp.Length>=5 && temp.Substring(0, 3) == "1/(")
                {

                }
                else switch (temp[i].ToString())
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
                        case "+":
                            button_add.PerformClick();
                            break;
                        case "-":
                            button_sub.PerformClick();
                            break;
                        case "*":
                            button_mul.PerformClick();
                            break;
                        case "/":
                            button_div.PerformClick();
                            break;
                        case "%":
                            button_mod.PerformClick();
                            break;
                        case ".":
                            button_point.PerformClick();
                            break;
                        case " ":
                        default:
                            break;
                    }
            }
            button_equ.PerformClick();
        }

        // 전수영
        // 2017/1/3
        // History Click events 생성

        private void contextmenu_copyclick(object sender, EventArgs e)
        {
            if (listbox_history.SelectedIndex == -1)
                return;

            Clipboard.SetText(textbox_result.Text);
        }

        private void contextmenu_pasteclick(object sender, EventArgs e)
        {
            if (Clipboard.GetText() == null)
                return;

            Clipboard.GetText();
        }

        private void contextmenu_deleteclick(object sender, EventArgs e)
        {
            if (listbox_history.SelectedIndex == -1)
                return;
            listbox_history.Items.RemoveAt(listbox_history.SelectedIndex);
        }

        // 김효상
        // 2017/1/4
        // 저장 기능 구현
        private void save_data(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog(); //윈도우에서 사용하는 저장 다이얼로그 생성
            save_dialog.Title = "저장"; // 다이얼로그 제목
            save_dialog.Filter = "Text File (*.txt)|*.txt"; //파일 확장자 필터
           
            if (save_dialog.ShowDialog()==DialogResult.OK)
            {
                FileStream file = new FileStream(save_dialog.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file,Encoding.Default);
                for(int i = 0;i<listbox_history.Items.Count;i++)
                {
                    textbox_result.Clear();
                    b_history = true;
                    String temp = listbox_history.Items[i].ToString();
                    for (int j = 0, len = temp.Length; j < len; j++)
                    {
                        if (temp.Length >= 5 && temp.Substring(0, 3) == "1/(")
                        {

                        }
                        else switch (temp[j].ToString())
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
                                case "+":
                                    button_add.PerformClick();
                                    break;
                                case "-":
                                    button_sub.PerformClick();
                                    break;
                                case "*":
                                    button_mul.PerformClick();
                                    break;
                                case "/":
                                    button_div.PerformClick();
                                    break;
                                case "%":
                                    button_mod.PerformClick();
                                    break;
                                case ".":
                                    button_point.PerformClick();
                                    break;
                                case " ":
                                default:
                                    break;
                            }
                    }
                    
                    button_equ.PerformClick();

                    writer.WriteLine(listbox_history.Items[i].ToString()+" = "+ textbox_result.Text);//리스트에 저장되어있는 목록 전부 저장 
                }
                writer.Close();
                file.Close();
                b_history = false;
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
