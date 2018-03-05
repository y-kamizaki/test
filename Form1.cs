using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simplecalc
{
    public partial class simplecalc : Form
    {
        public simplecalc()
        {
            InitializeComponent();
        }

        private void simplecalc_Load(object sender, EventArgs e);


             private void calcbutton_Click(object sender, EventArgs e)
             {
                /// 変数の宣言
                int valueLeft;    // 入力値１用の整数型変数
                int valueRight;   // 入力値２用の整数型変数
                int valueanswer;  // 計算結果用整数型変数
 
                valueLeft = inputCheck(input1textbox.Text, out valueLeft);
                valueRight = inputCheck(input2textbox.Text, out valueRight);
            
            /// 取り込んだ値の計算
            valueanswer = valueLeft + valueRight;
            
            /// 計算結果の入力
            answertexbox.Text = valueanswer.ToString(); //　文字列に変換後代入
        }

      private int InputCheck(string textvalue, out int value)
        {
            if (int.TryParse(textvalue, out value) == true) 
            {
                 value = int.Parse(textvalue);            
            }
            else
            { 
                　value = 0;
            }
            return value;
            }
        }
    }


        