using Entidades;
using System.Collections.Generic;
using System.IO;

namespace Interfaces
{
    public interface IPersistencia
    {
        public bool Grabar(Avatar avatar)
        {
            File.AppendAllLines("Avatar.txt", new List<string> { avatar.Nombre });
            return true;
        }
        public bool Grabar(Acciones acciones)
        {
            File.AppendAllLines("Acciones.txt", new List<string> { acciones.Accion1 });
            return true;
        }
        public bool Grabar(Nivel nivel)
        {
            File.AppendAllLines("Nivel.txt", new List<string> { nivel.Nivel1 });
            return true;
        }
        public bool Grabar(AvatarPorAccion avatarPorAccion)
        {
            File.AppendAllLines("AvatarPorAccion.txt", new List<string> { avatarPorAccion.ToString() });
            return true;
        }

    }
}
