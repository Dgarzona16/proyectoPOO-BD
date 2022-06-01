using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_POO_BD.Properties
{
    public class FormTemplate
    {
        public List<string> CmbItems = new List<string>();
        public SQLReaderWriter consulta;
        public FormTemplate()
        {
            
        }
        
    }

    public class EventComplement : FormTemplate
    {

        public EventComplement()
        {
            //
            //Buscar
            //
            CmbItems.Add("Nombre de Evento");
            CmbItems.Add("Area");
            consulta = new EventSQL();
            //
            //Añadir
            //

        }
    }

    public class ColectionComplement : FormTemplate
    {
        public ColectionComplement()
        {
            //
            //Buscar
            //
            CmbItems.Add("Nombre de coleccion");
            CmbItems.Add("Tipo de coleccion");
            CmbItems.Add("Genero");
            consulta = new CollectionSQL();
            //
            //Añadir
            //
        }
    }

    public class MaterialComplement : FormTemplate
    {
        public MaterialComplement()
        {
            //
            //Buscar
            //
            CmbItems.Add("Nombre del material");
            CmbItems.Add("Palabras clave");
            CmbItems.Add("Autor");
            CmbItems.Add("Formato");
            consulta = new MaterialSQL();
            //  
            //Añadir
            //
        }
    }

    public class ReserveComplement : FormTemplate
    {
        public ReserveComplement()
        {
            //
            //Buscar
            //
            CmbItems.Add("Reserva / Usuario");
            CmbItems.Add("Prestamo / Usuaraio");
            consulta = new ReserveSQL();
            //
            //Añadir
            //
        }
    }

    public class UserComplement : FormTemplate
    {
        public UserComplement()
        {
            //
            //Buscar
            //
            CmbItems.Add("Nombre");
            CmbItems.Add("Ocupacion");
            consulta = new UserSQL();
            //
            //Añadir
            //
        }
    }
}
