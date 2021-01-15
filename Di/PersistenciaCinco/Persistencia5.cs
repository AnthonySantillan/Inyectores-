using System;
using System.Collections.Generic;
using System.IO;
using Entidades;
using Interfaces;
namespace PersistenciaCinco
{
    public class Persistencia5 : IPersistenciaCinco
    {

        public new bool Grabar(Avatar avatar)
        {
            File.AppendAllLines("Avatar.txt", new List<string> { avatar.Nombre5 });
            Console.WriteLine("EL jugador: ");
            Console.WriteLine(avatar.Nombre5);
            return true;
        }
        public new bool Grabar(Acciones acciones)
        {
            File.AppendAllLines("Acciones.txt", new List<string> { acciones.Accion1,acciones.Accion2,acciones.Accion3 });
            Console.WriteLine("Realiza la accion de : ");
            Console.WriteLine(acciones.Accion1);
            Console.WriteLine(acciones.Accion2);
            Console.WriteLine(acciones.Accion3);
            return true;
        }
        public new bool Grabar(Nivel nivel)
        {
            File.AppendAllLines("Nivel.txt", new List<string> { nivel.Nivel5 });
            Console.WriteLine("Se encuentra en el nivel: ");
            Console.WriteLine(nivel.Nivel5);
            return true;
        }
        public new bool Grabar(AvatarPorAccion avatarPorAccion)
        {
            File.AppendAllLines("AvatarPorAccion.txt", new List<string> { avatarPorAccion.NivelId.ToString() });
            return true;
        }
    }
}

