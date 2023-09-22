using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnswerCode
{
    // 클래스 내의 이벤트 정의
    class MyButton
    {
        public string Text;
        // 이벤트 정의
        public event EventHandler Click;

        public void MouseButtonDown()
        {
            if (this.Click != null)
            {
                // 이벤트핸들러들을 호출
                Click(this, EventArgs.Empty);
            }
        }
    }

    // 이벤트 사용



    class Program
    {
        public void Run()
        {
            MyButton btn = new MyButton();
            // Click 이벤트에 대한 이벤트핸들러로
            // btn_Click 이라는 메서드를 지정함
            btn.Click += new EventHandler(btn_Click);
            btn.Text = "Run";
            //....
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 클릭");
        }
        static int Main(string[] args)
        {
            string[] szInput1 = Console.ReadLine().Split();
            long A = long.Parse(szInput1[0]);
            long B = long.Parse(szInput1[1]);
            long C = long.Parse(szInput1[2]);
            Console.WriteLine(A+B+C);
            
            return 0;
        }
    }
}
