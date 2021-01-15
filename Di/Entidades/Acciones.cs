using System;

namespace Entidades
{
    public class Acciones 
    {
        public Acciones(string accion1, string accion2, string accion3)
        {
            Accion1 = accion1;
            Accion2 = accion2;
            Accion3 = accion3;
            Id = new Random().Next();

        }
        public string Accion1 { get; set; }
        public string Accion2 { get; set; }
        public string Accion3 { get; set; }
        public int Id { get; set; }



    }
}

