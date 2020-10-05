using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Kwit_E_Mart
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Empleado> listaEmpleados = Comercio.GetListaDeEmpleados();
            bool findValue = false;
            
            foreach(Empleado empleado in listaEmpleados)
            {
                if(this.txtUsuario.Text.ToString() == empleado.Usuario)
                {
                    findValue = true;
                    
                    if(this.txtContrasenia.Text.ToString() == empleado.Constrasenia)
                    {
                        HomeForm homeForm = new HomeForm();
                        homeForm.lblEmpleadoHome.Text = empleado.SayNameLastname(empleado.Nombre, empleado.Apellido);
                        homeForm.SetEmpleadoSesionActual(empleado);
                        homeForm.ShowDialog();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta!");
                    }
                }
            }

            if (!findValue)
            {
                MessageBox.Show("Usuario Incorrecto!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Comercio.ListaPersonas.Add(new Empleado("Lisbaldy", "Ojeda", 12345678, ECargos.VendedorSenior, "lisba", "1234"));
            Comercio.ListaPersonas.Add(new Empleado("Jesus", "Leon", 12345687, ECargos.VendedorSemiSenior, "jesus", "5678"));
        }
    }
}
