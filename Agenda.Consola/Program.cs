using Agenda.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaContactos agenda = new AgendaContactos("Diario", "Electrónica", 5);

            Contacto contacto1 = new Contacto("Cecilia","Lopez", "1234", "moldes 123", DateTime.Now.AddYears(-35));

            Contacto contacto2 = new Contacto("Carlos","Landa", "789456", "11 de septiembre", DateTime.Now.AddYears(-21));

            

            agenda.AgregarContacto(contacto1);

            agenda.AgregarContacto(contacto2);


        }
    }
}
