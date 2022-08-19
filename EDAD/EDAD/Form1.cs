using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Persona unapersona = new Persona();

        private void Btn_Persona_Click(object sender, EventArgs e)
        {



            unapersona.p_nombre = Txt_Nombre.Text;
            unapersona.p_dni = double.Parse(Txt_Dni.Text);
            unapersona.p_fecha = DateTime.Parse(Txt_FechaNac.Text);
        }

        private void Btn_Edad_Click(object sender, EventArgs e)
        {
            Lbl_Edad.Text = unapersona.Edad().ToString();
        }

        private void Txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }


        }

        private void Txt_Dni_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Dni.Text.Length > 8)

                MessageBox.Show("Ingrese solo 7 digitos");
                
                        
        }



    }

}