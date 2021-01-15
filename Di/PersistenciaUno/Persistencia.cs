using System;
using System.Collections.Generic;
using System.IO;
using Entidades;
using Interfaces;

namespace PersistenciaUno
{
    public class Persistencia: IPersistencia
    {
       
        public bool Grabar(Avatar avatar)
        {
            File.AppendAllLines("Avatar.txt", new List<string> { avatar.Nombre });
            Console.WriteLine(avatar.Nombre);
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
            File.AppendAllLines("Nivel.txt", new List<string> { nivel.Nivel1 });
            Console.WriteLine("Se encuentra en el nivel: ");
            Console.WriteLine(nivel.Nivel1);
            return true;
        }
        public bool Grabar(AvatarPorAccion avatarPorAccion)
        {
            File.AppendAllLines("AvatarPorAccion.txt", new List<string> { avatarPorAccion.ToString() });
            return true;
        }
    }

}
