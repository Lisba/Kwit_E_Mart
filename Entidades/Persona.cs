using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Fields
        protected static int id;
        protected string nombre;
        protected string apellido;
        protected int dni;
        #endregion

        #region Constructors
        static Persona()
        {
            id = 1;
        }

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        #endregion

        #region Methods
        public virtual string SayNameLastname(string name, string lastName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{name} {lastName}");
            return sb.ToString();
        }
        #endregion
    }
}
