using System;

namespace Entidades
{
    public class Nivel
    {
        public Nivel(string nivel1, string nivel2,string nivel3,string nivel4,string nivel5)
        {
            Nivel1 = nivel1;
            Nivel2 = nivel2;
            Nivel3 = nivel3;
            Nivel4 = nivel4;
            Nivel5 = nivel5;
            Id = new Random().Next();
        }
        public string Nivel1 { get; set; }
        public string Nivel2 { get; set; }
        public string Nivel3 { get; set; }
        public string Nivel4 { get; set; }
        public string Nivel5 { get; set; }
        public int Id { get; set; }

    }
}
