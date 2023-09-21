using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJESONHAL
{
    public partial class Form1 : Form
    {
        double sayi,sayi2, sonuc;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }
        void sayiYaz1()//BU FONKSİYON LABELA SAYI VE İŞLEM OPERATÖRÜNÜ EKLEYECEK.
        {
            if(textBox1.Text!="")
            {
                sayi = Convert.ToDouble(textBox1.Text);
                label1.Text = sayi.ToString() + islem.ToString();//GİRDİĞİMİZ SAYI VE İŞLEMİ LABELA YAZDIRMA İŞLEMİ
                textBox1.Text = "";// TEXTBOXIN TEXTİNİ TEMİZLEME İŞLEMİ
            }
        }

        void sayiYaz2()
        {
            label1.Text = sayi.ToString() + islem.ToString()+ sayi2.ToString()+ "=";
            textBox1.Text = sonuc.ToString();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//TEXTBOXIN TEXTİ 0 İSE ;
            {
                textBox1.Text = ""; //TEXTBOXIN TEXTİNİ TEMİZLE.
            }
            textBox1.Text += "3"; // TEMİZLENEN TEXTBOXA 3 SAYISINI YAZ VE HER BASIMDA YANINA EKLE 
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//TEXTBOXIN TEXTİ 0 İSE ;
            {
                textBox1.Text = "";//TEXTBOXIN TEXTİNİ TEMİZLE.
            }
            textBox1.Text += "1"; // TEMİZLENEN TEXTBOXA 1 SAYISINI YAZ VE HER BASIMDA YANINA EKLE 

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//TEXTBOXIN TEXTİ 0 İSE ;
            {
                textBox1.Text = "";//TEXTBOXIN TEXTİNİ TEMİZLE.
            }
            textBox1.Text += "2";// TEMİZLENEN TEXTBOXA 2 SAYISINI YAZ VE HER BASIMDA YANINA EKLE 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//TEXTBOXIN TEXTİ 0 İSE ;
            {
                textBox1.Text = "";//TEXTBOXIN TEXTİNİ TEMİZLE.
            }
            textBox1.Text += "4";// TEMİZLENEN TEXTBOXA 4 SAYISINI YAZ VE HER BASIMDA YANINA EKLE 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//TEXTBOXIN TEXTİ 0 İSE ;
            {
                textBox1.Text = "";//TEXTBOXIN TEXTİNİ TEMİZLE.
            }
            textBox1.Text += "5";// TEMİZLENEN TEXTBOXA 5 SAYISINI YAZ VE HER BASIMDA YANINA EKLE 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//TEXTBOXIN TEXTİ 0 İSE ;
            {
                textBox1.Text = "";//TEXTBOXIN TEXTİNİ TEMİZLE.
            }
            textBox1.Text += "6";// TEMİZLENEN TEXTBOXA 6 SAYISINI YAZ VE HER BASIMDA YANINA EKLE 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//TEXTBOXIN TEXTİ 0 İSE;
            {
                textBox1.Text = "";//TEXTBOXIN TEXTİNİ TEMİZLE.
            }
            textBox1.Text += "7";// TEMİZLENEN TEXTBOXA 7 SAYISINI YAZ VE HER BASIMDA YANINA EKLE 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//TEXTBOXIN TEXTİ 0 İSE;
            {
                textBox1.Text = "";//TEXTBOXIN TEXTİNİ TEMİZLE.
            }
            textBox1.Text += "8";// TEMİZLENEN TEXTBOXA 8 SAYISINI YAZ VE HER BASIMDA YANINA EKLE 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//TEXTBOXIN TEXTİ 0 İSE;
            {
                textBox1.Text = "";//TEXTBOXIN TEXTİNİ TEMİZLE.
            }
            textBox1.Text += "9";// TEMİZLENEN TEXTBOXA 9 SAYISINI YAZ VE HER BASIMDA YANINA EKLE 
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",")<1)
            {
                textBox1.Text += ",";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if(textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            islem = "÷";
            sayiYaz1();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islem = "×";
            sayiYaz1();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            islem = "-";
            sayiYaz1();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islem = "+";
            sayiYaz1();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi2 = Convert.ToDouble(textBox1.Text);
            }

                   // else label1.Text="0+"
            switch(islem)
            {
                case "+":
                    sonuc = sayi +sayi2;
                    sayiYaz2();

                    break;
                case "-":
                    sonuc = sayi - sayi2;
                    sayiYaz2();
                    break;
                case "÷":
                    sonuc = sayi / sayi2;
                    sayiYaz2();
                    break;
                case "×":
                    sonuc = sayi * sayi2;
                    sayiYaz2();
                    break;
            }
            listBox1.Items.Add(label1.Text + textBox1.Text);//LABELDAKİ YAPTIĞIMIZ İŞLEMLER VE TEXTBOXTAKİ SONUCUMUZ GEÇMİŞ BİLGİSİNİ TUTAN LİSTBOXA EKLENDİ..
        }

        private void btnGeçmiş_Click(object sender, EventArgs e)
        {
            if (btnGeçmiş.Text=="◴")
            {
                groupBox1.Visible = true;
                btnGeçmiş.Text = "◷";
            }
            else
            {
                groupBox1.Visible = false;
                btnGeçmiş.Text = "◴";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";//HEM TEXTBOX DA HEMDE LABEL DA YAPILAN İŞLEMLERİ TEMİZLE 
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == sonuc.ToString())//EĞER İŞLEM YAPIP SONUCU BULMUŞSAK HEM TEXTBOXI HEMDE LABELI TEMİZLE 
            {
                textBox1.Text = "";
                label1.Text = "";
            }
            else    //İŞLEM DAHA YAPILMADIYSA YANLIŞ GİRİLEN SAYIYI TEXTBOXTAN TEMİZLE 
                textBox1.Text = "";

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Text);//GEÇMİŞİ TEMİZLE
        }

        private void button5_Click(object sender, EventArgs e)
        {
            islem = "1/x";
            sayi = Convert.ToDouble(textBox1.Text);
            label1.Text = (1 +"/"+ (sayi)).ToString();
            sonuc = 1 / sayi;
            textBox1.Text = sonuc.ToString();
            listBox1.Items.Add(label1.Text +"  =  "+ textBox1.Text);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            islem = "x^2";
            sayi = Convert.ToDouble(textBox1.Text);
            label1.Text = ("sqr"+"("+(sayi)+")").ToString();
            sonuc = Math.Pow(sayi,2);
            textBox1.Text = sonuc.ToString();
            listBox1.Items.Add(label1.Text +"  =  " +textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            islem = "√x";
            sayi = Convert.ToDouble(textBox1.Text);
            label1.Text = ("√" + (sayi)).ToString();
            sonuc = Math.Sqrt(sayi);
            textBox1.Text = sonuc.ToString();
            listBox1.Items.Add(label1.Text +"  =  " +textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")//TEXTBOXIN  TEXTİ 0 İSE;
            {
                textBox1.Text = "";//TEXTBOXIN TEXTİNİ TEMİZLE
            }
            textBox1.Text += "0";// TEMİZLENEN TEXTBOXA 0 SAYISINI YAZ VE HER BASIMDA YANINA EKLE 
        }
  
    }
}
