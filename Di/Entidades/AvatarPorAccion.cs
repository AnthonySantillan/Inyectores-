using System;

namespace Entidades
{
    public class AvatarPorAccion
    {
        public int AvatarId { get; set; }

        public int NivelId { get; set; }

        public int Id { get; set; } = new Random().Next();

    }
}
