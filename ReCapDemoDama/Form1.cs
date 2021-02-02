using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCapDemoDama
{
    public partial class ReCapDemoDama : Form
    {
        public ReCapDemoDama()
        {
            InitializeComponent();
        }

        private void ReCapDemoDama_Load(object sender, EventArgs e)
        {
            //02,02,2021
            //uygulama ilk açıldığında çalışacak kısım.

            //her buton bir classtır.

            // aynı işlemden farklı nesneler oluşturup onları kontrol altında tutmak için array kullanılır.


            Button[,] buttons = new Button[8,8]; // button nesnesi oluşturuldu.

            int tops = 0;    // asagı olan uzaklık
            int lefts = 0; // sola olan uzaklık

            // GetUpperBound 0.boyutun en büyük alabileceği değerdir.buda 7'dir.
            // 8 satır için bir değer oluşturduk.
            for (int i = 0; i < buttons.GetUpperBound(0); i++) 
            {
                for (int j = 0; j <buttons.GetUpperBound(1) ; j++)  // her bir satır için buton oluşturulur. i=0 iken j=0 0.0 oluşturulur.
                {
                    buttons[i, j] = new Button(); // ilk buton bizim için yeni bir butondur.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = lefts; // sola olan uzaklık.
                    buttons[i, j].Top = tops; //top=0 ilk 8 buton için.
                    lefts += 50; // butonları yan yana dizdi.

                    if ((i+j)%2==0) // background algoritması..
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);  // butonu ekrana koyar.


                }
                tops += 50; // 2.satır için top her defasında 50,50 artar.
                lefts = 0; // ikinci satıra geçti.

                //8*8 button arrayi oluştu.


            }
            
            

           
        }
    }
}
