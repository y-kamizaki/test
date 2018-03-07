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
                int ValueLeft;    // 入力値１用の整数型変数
                int ValueRight;   // 入力値２用の整数型変数
                int ValueAnswer;  // 計算結果用整数型変数
 
                ValueLeft = inputCheck(input1textbox.Text, out ValueLeft);
                ValueRight = inputCheck(input2textbox.Text, out ValueRight);
            
            /// 取り込んだ値の計算
           ValueAnswer = ValueLeft + ValueRight;
            
            /// 計算結果の入力
            answertexbox.Text = ValueAnswer.ToString(); //　文字列に変換後代入
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


        
