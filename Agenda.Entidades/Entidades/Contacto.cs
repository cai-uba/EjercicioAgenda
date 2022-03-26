using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Entidades.Entidades
{
    public class Contacto
    {
        public Contacto(string nombre, string apellido, string telefono, string direccion, DateTime fechaNaciemento) {
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _direccion = direccion;
            _fechaNacimiento = fechaNaciemento;
        }

        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _direccion;
        private string _log;
        private DateTime _fechaNacimiento;
        private int _llamadas;

        public string Nombre {
            get {
                return _nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return _apellido;
            }
        }
        public string Telefono
        {
            get
            {
                return _telefono;
            }
        }
        public string Direccion
        {
            get
            {
                return _direccion;
            }
        }

        //public string Nombre2
        //{
        //    get => _nombre;
        //    set => _nombre = value;
        //}


        public void AgregarLog(string nuevoEvento)
        {
            _log = _log + nuevoEvento;
        }
        public int Edad()
        {
            double edad = (DateTime.Now - _fechaNacimiento).Days / 365;
            return Convert.ToInt32(edad);
        }

        public void LLamar() {
            _llamadas++;
        }

    }
}
