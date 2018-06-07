using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIRCULAR_AP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtRespuesta.Text = Trabajando();
        }

        public string Trabajando()
        {
            int maybe = 0,yesitwas=0,nothingHa=0,finished=0, dif =0;
            Proceso p = new Proceso();
            ClaseBase nuevo;
            Estructura folleto = new Estructura();
            Random r = new Random(DateTime.Now.Second);

            for (int i = 300; i > 1; i--)
            {
                maybe = r.Next(1,101);
                if(maybe < 36)
                {
                    nuevo = new ClaseBase (p.ProcesoSan());
                    folleto.agregar(nuevo);
                    yesitwas++;
                }

                if(folleto.ver() == 0)
                {
                    nothingHa++;
                }else
                {
                    folleto.reducir();
                    if(folleto.ver() == 0)
                    {
                        folleto.sacar();
                        finished++;
                        folleto.recorredor();
                    }
                    folleto.recorredor();
                }
            }
            dif = yesitwas - finished;
            return "Lista vacia por ciclo: " + nothingHa + "\r\n" +
                "Numero maximo de procesos formados: " + yesitwas + "\r\n" +
                "Proceso pendientes: " + dif +"\r\n" +
                "Sume de ciclos pendientes " + folleto.contador();
        }
    }
}
