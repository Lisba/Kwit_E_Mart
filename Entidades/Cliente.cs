using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        #region Fields
        string email;
        int idPropio;
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

        public string Email
        {
            get
            {
                return email;
            }
        }
        #endregion

        #region Constructors
        public Cliente(string nombre, string apellido, int dni, string email) : base(nombre, apellido, dni)
        {
            this.idPropio = id++;
            this.email = email;
        }
        #endregion
    }
}
