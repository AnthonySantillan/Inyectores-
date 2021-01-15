using Entidades;
using Interfaces;
using System;
using Dato;
using PersistenciaUno;
using PersistenciaDos;
using PersistenciaTres;
using PersistenciaCuatro;
using PersistenciaCinco;
using LightInject;
using Di.LightInject;

namespace Di
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tu camino empieza aqui");
            Console.WriteLine("Empezemos");
            Console.WriteLine("EL jugador: ");
            var container = new LightInject.ServiceContainer();

            container.Register<IPersistencia, Persistencia>();
            var instanceUno = container.GetInstance<IPersistencia>();
            //Assert.IsInstanceOfType(instance, typeof(Foo));
            container.Register<IPersistenciaDos, Persistencia2>();
            var instanceDos = container.GetInstance<IPersistenciaDos>(); 
            
            container.Register<IPersistenciaTres, Persistencia3>();
            var instanceTres = container.GetInstance<IPersistenciaTres>();

            container.Register<IPersistenciaCuatro, Persistencia4>();
            var instanceCuatro = container.GetInstance<IPersistenciaCuatro>();

            container.Register<IPersistenciaCinco, Persistencia5>();
            var instanceCinco = container.GetInstance<IPersistenciaCinco>();
            
            //IPersistencia persistencia = new Persistencia();
            //IPersistencia persistencia = new Persistencia2();
            //IPersistencia persistencia = new Persistencia3();
            //IPersistencia persistencia = new Persistencia4();
            //IPersistencia persistencia = new Persistencia5();

            Datos dato = new Datos(instanceUno,instanceDos,instanceTres,instanceCuatro,instanceCinco);

            Acciones acciones = new Acciones("Comer","Correr","Saltar");

            Avatar avatar = new Avatar("Anthony","Francisco","Michael","Kevin","Brayan");

            Nivel nivel = new Nivel("Facil","Medio","Intermedio","Dificil","Experto");

            dato.Registar(avatar, nivel, acciones);

        }

    }
}

