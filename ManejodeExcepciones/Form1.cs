using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejodeExcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;
            try
            {   
                a = int.Parse(txtBox1.Text);
                b = int.Parse(txtBox2.Text);
                r = a + b;
                lblResultado.Text = "= " + r;

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Solo puede cargar numeros.."); 
                
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero.."); 
            }
            catch(OverflowException ex)
            {
                MessageBox.Show("Ingresó un valor demasiado alto para el tipo de dato que es..");
                //Excepcion para el desarrollador.. 
            }
            
        }
        
    }
}
