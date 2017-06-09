using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        int contUM = 0, contDois = 0;
        int min, seg, mil;
        int po;
        public Form4()
        {
            InitializeComponent();
        }

        private void temp(object sender, EventArgs e)
        {
            contUM++;
            min = (contUM / 3600);
            if (min >= 25)
            {
                tempo.Stop();
                contUM = 0;
                contDois = 0;
                lbltempo.Text = contUM.ToString() + "0:00:00";
                btniniciar.Text = "iniciar";

                po = (po - 1);

            }
            seg = (contUM % 3600) / 60;
            mil = (contUM % 3600) % 60;
            lbltempo.Text = string.Format("{0:#,0#}:{1:#,0#}:{2:#,0#}:", min, seg, mil);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
           int po;
        }

        private void iniciar(object sender, EventArgs e)
        {

            contDois++;
            if (contDois % 2 == 1)
            {

                tempo.Start();
                btniniciar.Text = "Pausar";
               
            }
            

            else

            {

                tempo.Dispose();
                btniniciar.Text = "iniciar";
            }
                
            }

        

        private void button1_Click(object sender, EventArgs e)
        {
            tempo.Enabled = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
