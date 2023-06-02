using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creaciondeempleado
{
    internal class MetodosPersona:Persona

    {
        public List<Persona> Listapersona;

        public MetodosPersona()
        {
            //indicar que listapersoan es una nueva lista de la clase persona
            Listapersona = new List<Persona>();
        }

        public void adicionar(Persona clie)
        {//adicionar a la lista indicada con .add
            Listapersona.Add(clie);


        }

        public Persona consultar(int IdClie)
        {//consultar de la lista indicada con el .find
            Persona objCli = new Persona();

            objCli = Listapersona.Find(c => c.Id == IdClie);

            return objCli;


        }
        public void EliminarPersona(int consultarPersona)
        //remover todo de una lista con removeall
        {
            Listapersona.RemoveAll(x => x.Id == consultarPersona);

        }

        public Persona ActualizarPersona(Persona actualizarPersona)
        {//actualizar lo indiicado
            //consultar de una lista con foreach
            Persona objPersona = new Persona();

            Listapersona.ForEach((personaList) =>
            {
                if (personaList.Id == actualizarPersona.Id)
                {
                    personaList.Nombre = actualizarPersona.Nombre;
                    personaList.Tdoc = actualizarPersona.Tdoc;
                    personaList.Apellido = actualizarPersona.Apellido;
                    personaList.Fecha = actualizarPersona.Fecha;
                    personaList.sexo = actualizarPersona.sexo;
                    personaList.Ecivil = actualizarPersona.Ecivil;
                    personaList.direccion = actualizarPersona.direccion;
                    personaList.telefono = actualizarPersona.telefono;
                    personaList.celular = actualizarPersona.celular;
                    personaList.correo = actualizarPersona.correo;

                }
                MessageBox.Show("persona actualizada");
            });
            return objPersona = consultar(actualizarPersona.Id);
        }

        public List<Persona> listametodos
        {// crear lista para el data gred vew 
            get

            {
                return Listapersona;
            }
        }

      
        























































    }
}
