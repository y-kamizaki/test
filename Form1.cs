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
                int VL;    // 入力値１用の整数型変数
                int VR;   // 入力値２用の整数型変数
                int VA;  // 計算結果用整数型変数 master
 
                VL = inputCheck(input1textbox.Text, out VL);
                VR = inputCheck(input2textbox.Text, out VR);
            
            /// 取り込んだ値の計算
           VA = VL + VR;
            
            /// 計算結果の入力
            answertexbox.Text = VA.ToString(); //　文字列に変換後代入
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


        
