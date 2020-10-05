using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        #region Fields
        int idPropio;
        ECargos cargo;
        string usuario;
        string contrasenia;
        #endregion

        #region Properties
        public int IdPropio
        {
            get
            {
                return idPropio;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public int Dni
        {
            get
            {
                return dni;
            }
        }

        public ECargos Cargo
        {
            get
            {
                return cargo;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }
        }

        public string Constrasenia
        {
            get
            {
                return contrasenia;
            }
        }
        #endregion

        #region Constructors
        public Empleado(string nombre, string apellido, int dni, ECargos cargo, string usuario, string contrasenia) : base(nombre, apellido, dni)
        {
            this.idPropio = id++;
            this.cargo = cargo;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }
        #endregion
    }
}
