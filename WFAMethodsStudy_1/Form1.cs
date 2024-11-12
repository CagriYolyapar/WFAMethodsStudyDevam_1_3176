using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAMethodsStudy_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bu metot Hello world mesajı ile kullanıcıyı selamlar
        /// </summary>

        public void Selamla()
        {
           
        }

        public void Selamla(string isim)
        {

        }

        public void Selamla(string deneme,string test)
        {

        }

        /// <summary>
        /// Bu metot verdiginiz iki sayıyı toplayarak geriye sonucu döndürür
        /// </summary>
        /// <param name="sayi1">Vereceginiz ilk sayı</param>
        /// <param name="sayi2">Vereceginiz ikinci sayı</param>
        /// <returns>Sonuc string olarak döner ki rahatca yazdırın</returns>
        public string Topla(int sayi1, int sayi2)
        {
            return (sayi1 + sayi2).ToString();
        }


        /*
         
         
        ***************************Method Signature(Metot İmzası)***********************************
        *
        *Metot imzası iki kısımdan olusur... 1. Kısım => Metodun ismidir...2.Kısım => Metodun parametre kümesidir...Bunlardan herhangi biri degiştigi anda metot imzası degişir... 
        *
        *Aynı imzaya sahip iki metot olusturamazsınız
        *
        *!!!! Metot imzasına asla dönüs tipi dahil degildir!!!!!!
        *
        *Metot imzasının ikinci kısmını (parametre kısmını) degiştirerek (1. kısım yani isim aynı kalacak) method overloading yaparsınız.. Yani aynı isimde farklı farklı görevler yapacak metotlar olusturursunuz
         
         
         Metot imzasının ikinci kısmını sadece parametre ismini degiştirerek degiştiremezsiniz...Ya parametre tipinin degişmesi lazım veya parametre sayısının degişmesi lazım.
         
         
         
         
         
         
         
         
         */


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
