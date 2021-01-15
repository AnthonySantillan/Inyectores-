using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Entidades;

namespace Interfaces
{
   public  class IPersistenciaCuatro
    {

        public bool Grabar(Avatar avatar)
        {
            File.AppendAllLines("Avatar.txt", new List<string> { avatar.Nombre4 });
            Console.WriteLine("EL jugador: ");
            Console.WriteLine(avatar.Nombre4);
            return true;
        }
        public bool Grabar(Acciones acciones)
        {
            File.AppendAllLines("Acciones.txt", new List<string> { acciones.Accion1 });
            Console.WriteLine("Realiza la accion de : ");
            Console.WriteLine(acciones.Accion1);
            return true;
        }
        public bool Grabar(Nivel nivel)
        {
            File.AppendAllLines("Nivel.txt", new List<string> { nivel.Nivel4});
            Console.WriteLine("Se encuentra en el nivel: ");
            Console.WriteLine(nivel.Nivel4);
            return true;
        }
        public bool Grabar(AvatarPorAccion avatarPorAccion)
        {
            File.AppendAllLines("AvatarPorAccion.txt", new List<string> { avatarPorAccion.ToString() });
            return true;
        }
    }
}
