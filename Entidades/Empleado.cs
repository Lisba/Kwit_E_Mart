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
        ECargos cargo;
        string usuario;
        string contrasenia;
        #endregion

        #region Properties
        public int Id
        {
            get
            {
                return id;
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
                return Constrasenia;
            }
        }
        #endregion

        #region Constructors
        static Empleado()
        {
            id = 0;
        }

        public Empleado(string nombre, string apellido, int dni, ECargos cargo, string usuario, string contrasenia) : base(nombre, apellido, dni)
        {
            id++;
            this.cargo = cargo;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }
        #endregion
    }
}
