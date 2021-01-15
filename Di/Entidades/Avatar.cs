using System;

namespace Entidades
{
    public class Avatar
    {
        public Avatar(string nombre,string nombre2,string nombre3,string nombre4,string nombre5)
        {
            Nombre = nombre; 
            Nombre2 = nombre2; 
            Nombre3 = nombre3; 
            Nombre4 = nombre4; 
            Nombre5 = nombre5; 

            Id = new Random().Next();
            
        }
        public string Nombre { get; set; }
        public string Nombre2 { get; set; }
        public string Nombre3 { get; set; }
        public string Nombre4 { get; set; }
        public string Nombre5 { get; set; }
        public int Id { get; set; }



    }
}
