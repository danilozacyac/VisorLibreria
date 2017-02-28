using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisorLibreria
{
    public class Asistencia
    {
        private int idAsistencia;
        private int idUsuario;
        private string usuario;
        private int idLibreria;
        private string libreria;
        private DateTime? fecha;
        private DateTime? entrada;
        private DateTime? salida;
        private string obsUser;
        private string obsChief;

        public int IdAsistencia
        {
            get
            {
                return this.idAsistencia;
            }
            set
            {
                this.idAsistencia = value;
            }
        }

        public int IdUsuario
        {
            get
            {
                return this.idUsuario;
            }
            set
            {
                this.idUsuario = value;
            }
        }

        public string Usuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }
        }

        public int IdLibreria
        {
            get
            {
                return this.idLibreria;
            }
            set
            {
                this.idLibreria = value;
            }
        }

        public string Libreria
        {
            get
            {
                return this.libreria;
            }
            set
            {
                this.libreria = value;
            }
        }

        public DateTime? Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        public DateTime? Entrada
        {
            get
            {
                return this.entrada;
            }
            set
            {
                this.entrada = value;
            }
        }

        public DateTime? Salida
        {
            get
            {
                return this.salida;
            }
            set
            {
                this.salida = value;
            }
        }

        public string ObsUser
        {
            get
            {
                return this.obsUser;
            }
            set
            {
                this.obsUser = value;
            }
        }

        public string ObsChief
        {
            get
            {
                return this.obsChief;
            }
            set
            {
                this.obsChief = value;
            }
        }
    }
}
