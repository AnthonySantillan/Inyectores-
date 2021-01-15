using Interfaces;
using Entidades;
namespace Dato
{
    public class Datos
    {
        IPersistencia persistencia;
        IPersistenciaDos persistenciados;
        IPersistenciaTres persistenciatres;
        IPersistenciaCuatro persistenciacuatro;
        IPersistenciaCinco persistenciacinco;



        public Datos(IPersistencia persistencia, IPersistenciaDos persistenciados, IPersistenciaTres persistenciatres, IPersistenciaCuatro persistenciacuatro, IPersistenciaCinco persistenciacinco)
        {
            this.persistencia = persistencia;
            this.persistenciados = persistenciados;
            this.persistenciatres = persistenciatres;
            this.persistenciacuatro = persistenciacuatro;
            this.persistenciacinco = persistenciacinco;



        }
        public string Registar(Avatar avatar, Nivel nivel,Acciones acciones)
        {


            persistencia.Grabar(avatar);
            persistencia.Grabar(nivel);
            persistencia.Grabar(acciones);
            //avatar dos 
            persistenciados.Grabar(avatar);
            persistenciados.Grabar(nivel);
            persistenciados.Grabar(acciones);
            //avatar tres
            persistenciatres.Grabar(avatar);
            persistenciatres.Grabar(nivel);
            persistenciatres.Grabar(acciones);
            //avatar cuatro
            persistenciacuatro.Grabar(avatar);
            persistenciacuatro.Grabar(nivel);
            persistenciacuatro.Grabar(acciones);
            //avatar cinco 
            persistenciacinco.Grabar(avatar);
            persistenciacinco.Grabar(nivel);
            persistenciacinco.Grabar(acciones);

            persistencia.Grabar(new AvatarPorAccion { AvatarId = avatar.Id, NivelId = nivel.Id });
            return string.Format("El estudiante {0} {1} {2}"
                , avatar.Nombre     
                , nivel.Nivel1
                , acciones.Accion1);

        }
    }
}
// inventar un personaje de un juego e inyectar comportamientos para caminar o para trotar o para correr o pelear 