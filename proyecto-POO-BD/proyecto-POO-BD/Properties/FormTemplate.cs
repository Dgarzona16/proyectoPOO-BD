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
            CmbItems.Add("Fecha de inicio");
            CmbItems.Add("Fecha de fin");
            CmbItems.Add("Area");
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
            CmbItems.Add("Nombre de la coleccion");
            CmbItems.Add("Tipo de coleccion");
            CmbItems.Add("Genero");
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
            CmbItems.Add("Palabras Clave");
            CmbItems.Add("Autor");
            CmbItems.Add("Formato");
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
            CmbItems.Add("Usuario");
            CmbItems.Add("Fecha de prestamo");
            CmbItems.Add("Fecha de reserva");
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
            //
            //Añadir
            //
        }
    }
}
