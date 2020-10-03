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
            id = 0;
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
            return $"{name} {lastName}";
        }

        public virtual string sayPersonData(int id, string name, string lastName, int dni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(id.ToString());
            sb.AppendLine(name);
            sb.AppendLine(lastName);
            sb.AppendLine(dni.ToString());
            return sb.ToString();
        }
        #endregion
    }
}
