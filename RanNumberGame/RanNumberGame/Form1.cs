using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RanNumberGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        int num = 0;
        int count = 0;
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            
           
            if (a == 1) 
            {
                MessageBox.Show("다시 시도해 주세용", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                a = 0;
            }
            else
            {
                Random random = new Random();
                num = random.Next(1,50);
                MessageBox.Show("1~50\t기회 5번\n\t시작합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                display.Text = $"{5 - count}번 남았습니다.";
                Console.WriteLine("랜덤 숫자: " + num);
                a = 1;
            }
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                MessageBox.Show("게임을 시작해 주세요!", "경고");
                display.Text = "게임을 시작해 주세요!";
                return;
            }
            else
            {
                if (int.TryParse(textBox.Text, out int input))
                {
                    if (input == num)
                    {
                        MessageBox.Show("정답입니다!", "게임종료");
                        a = 0;
                        count = 0;
                        display.Text = "게임을 시작합니다!";
                    }
                    else if (input < num && count != 4)
                    {
                        count++;
                        display.Text = $"{5 - count}번 남았습니다.\n{input} 보다 큽니다";
                    }
                    else if (input > num && count != 4)
                    {
                        count++;
                        display.Text = $"{5 - count}번 남았습니다.\n{input} 보다 작습니다";
                    }
                    else if (input != num && count == 4)
                    {
                        MessageBox.Show("실패\n\n정답은 \'" + num + "\' 입니다,", "게임종료");
                        a = 0;
                        display.Text = "게임을 시작합니다!";
                        count = 0 ;
                    }
                }
                else
                {
                    MessageBox.Show("숫자를 입력해주세요!", "경고");
                }
            }

            

            
        }

        
    }
}
