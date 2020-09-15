using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPro
{
    public partial class Form1 : Form
    {
        private double savedValue;
        private char op='\0'; //null값
        private bool operFlag =false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            //숫자 버튼 클릭 시 이벤트 (모든 숫자에 해당하는 함수)
            Button btn = sender as Button; 
            if (Result.Text == "0" || operFlag == true) 
            {
                Result.Text = btn.Text;  //0일경우 그 숫자로 시작
                operFlag = false;
            }
            else
                Result.Text = Result.Text + btn.Text; //기존값에 이어서
            
            // ,찍기 함수로
            double v = Double.Parse(Result.Text);
            Result.Text = commaProcedure(v, Result.Text);
        }

        private static string commaProcedure(double v, string s)
        {
            //세자리 콤마 찍기 함수
            int pos = 0;
            if (s.Contains(".")) 
            {
                pos = s.Length - s.IndexOf('.');
                if (pos == 1)
                    return s;
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else
                s = string.Format("{0:N0}", v);
            return s;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            //소수점버튼 클릭 이벤트
            if (Result.Text.Contains("."))
                return;
            else
                Result.Text += ".";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            //양수음수버튼 클릭 이벤트
            double v = Double.Parse(Result.Text);
            Result.Text = (-v).ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //더하기버튼 클릭 이벤트
            savedValue = Double.Parse(Result.Text);
            Express.Text = Result.Text + " + ";
            op = '+';
            operFlag = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //빼기버튼 클릭 이벤트
            savedValue = Double.Parse(Result.Text);
            Express.Text = Result.Text + " - ";
            op = '-';
            operFlag = true;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            //곱하기버튼 클릭 이벤트
            savedValue = Double.Parse(Result.Text);
            Express.Text = Result.Text + " × ";
            op = '*';
            operFlag = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            //나누기버튼 클릭이벤트
            savedValue = Double.Parse(Result.Text);
            Express.Text = Result.Text + " ÷ ";
            op = '/';
            operFlag = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //결과버튼 클릭 이벤트 (계산처리)
            Double x = Double.Parse(Result.Text);
            switch (op)
            {
                case '+':
                    Result.Text = (savedValue + x).ToString();
                    break;
                case '-':
                    Result.Text = (savedValue - x).ToString();
                    break;
                case '*':
                    Result.Text = (savedValue * x).ToString();
                    break;
                case '/':
                    Result.Text = (savedValue / x).ToString();
                    break;
            }
            // 3자리에 , 넣기 함수로
            double v = Double.Parse(Result.Text);
            Result.Text = commaProcedure(v, Result.Text);

            Express.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            //CE 클릭 이벤트 (현재값날림)
            Result.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            //C 클릭 이벤트 (전체값날림)
            Result.Text = "0";
            Express.Text = "";
            savedValue = 0;
            op = '\0';
            operFlag = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //백스페이스 클릭 이벤트
            Result.Text = Result.Text.Remove(Result.Text.Length - 1);
            if (Result.Text.Length == 0)
                Result.Text = "0";
        }
    }
}
