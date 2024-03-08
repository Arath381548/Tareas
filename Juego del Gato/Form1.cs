using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//nombre del juego
namespace Juego_del_Gato
{
    public partial class Form1 : Form
    {
        int nr = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        {
            //cambio de jugador 1 y 2 con la x y el 0
            nr++;
            Button b = (Button)sender;
            if (nr%2!=0) 
            {
                b.Text = "x";
            }
            else
            {
                b.Text = "0";
            }
            b.Enabled = false;



            //validaciones de victoria del juego en horizontal

            if ((b1.Text == b2.Text && b2.Text == b3.Text && b1.Enabled==false) ||
                 (b4.Text == b5.Text && b5.Text == b6.Text && b4.Enabled == false) ||
                 (b7.Text == b8.Text && b8.Text == b9.Text && b7.Enabled == false) ||
                 //validaciones de victoria del juego en vertical
                 (b1.Text == b4.Text && b4.Text == b7.Text && b1.Enabled == false) ||
                 (b2.Text == b5.Text && b5.Text == b8.Text && b2.Enabled == false) ||
                 (b3.Text == b6.Text && b6.Text == b9.Text && b3.Enabled == false) ||
                 //validaciones de victoria del juego en diagonal
                 (b1.Text == b5.Text && b5.Text == b9.Text && b1.Enabled == false) ||
                 (b3.Text == b5.Text && b5.Text == b7.Text && b3.Enabled == false))
            {


                //mensaje para cuando gane el jugador 1 o jugador 2
                if (nr % 2 != 0)
                    MessageBox.Show("Jugador 1 Gana");
                else
                    MessageBox.Show("Jugador 2 Gana");
                this.Close();
            }

        }
        //codigo que no supe como borrar sin que se me borre el juego
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
