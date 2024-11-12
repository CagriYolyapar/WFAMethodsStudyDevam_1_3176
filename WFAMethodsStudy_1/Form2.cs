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
    public partial class Form2 : Form
    {
        /*
         
        Bir kod blogunu metodun icerisine almak istiyorsanız ilgili kod blogunu secin ve ctrl + r(efactor) + m(ethod) tus kombinasyonuna basın...CIkan pencereden yeni olusturulacak metodun ismini vererek apply'a basın...Kesinlikle private static keyword'leri aklınızı karıstırmasın...

        Eger dilerseniz local alanda yazdıgınız ve parantezlerini verdiginiz bir isme ctrl+. tus kombinasyonunu kullanarak ve generate method diyerek o isimde bir metot olusturabilirsiniz...
         
         
         
         
         */
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DonguBaslat();
        }

        private static void DonguBaslat()
        {
            for (int i = 0; i < 19; i++)
            {

            }

            Deneme();
        }

        private static void Deneme()
        {
            
        }
    }
}
