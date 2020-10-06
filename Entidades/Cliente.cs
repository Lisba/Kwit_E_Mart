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
        /// <summary>
        /// Instancia un cliente con todos sus datos (llama al constructor de la clase padre Persona).
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="email"></param>
        public Cliente(string nombre, string apellido, int dni, string email) : base(nombre, apellido, dni)
        {
            this.idPropio = id++;
            this.email = email;
        }

        /// <summary>
        /// Instancia un cliente con email vacío.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Cliente(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            this.idPropio = id++;
            this.email = string.Empty;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Devuelve el nombre y apellido en un mismo string de un cliente (sobreescritura del metodo de clase padre).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <returns>El string concatenando el tipo, nombre y apellido.</returns>
        public override string SayNameLastname(string name, string lastName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cliente: {name} {lastName}");
            return sb.ToString();
        }
        #endregion
    }
}
