using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JugadorNS;

namespace JugadorTests
{
    [TestClass]
    public class JugadorTests
    {
        //Assert.AreEqual(esperado, obtenido)



        //1. Verificar que al crear un jugador con nombre "Ash", el nombre se asigna correctamente.
        [TestMethod]
        public void CrearJugador_NombreCorrecto()
        {
            // preparación del caso de prueba
            string nombre = "Ash";

            // acción a probar
            Jugador j = new Jugador(nombre);

            // comprobación
            string actual = j.Nombre;
            Assert.AreEqual(nombre, actual, "El nombre no se asigna correctamente");
        }


        //2. Comprobar que al añadir oro, la cantidad se incrementa correctamente.
        public void AnyadirOro_IncrementoCorrecto()
        {
            // preparación del caso de prueba
            int cantidad = 100;
            Jugador j = new Jugador("Ash");

            // acción a probar
            j.anyadirOro(cantidad);

            // comprobación
            double actual = j.Oro;
            Assert.AreEqual(cantidad, actual, 0.001, "El oro no se incrementa correctamente");
        }


        //3. Comprobar que al quitar vida, la cantidad se reduce correctamente.
        [TestMethod]
        public void QuitarVida_ReduceCorrectamente()
        {
            // preparación del caso de prueba
            int quitar = 20;
            int esperado = 80;
            Jugador j = new Jugador("Ash");

            // acción a probar
            j.quitarVida(quitar);

            // comprobación
            int actual = j.Vida;
            Assert.AreEqual(esperado, actual, "La vida no se reduce correctamente");
        }


        //4. Verificar que inicialmente el atributo npc es false.
        [TestMethod]
        public void NPC_InicialmenteFalse()
        {
            // preparación del caso de prueba
            Jugador j = new Jugador("Ash");

            // acción a probar
            bool actual = j.Npc;

            // comprobación
            Assert.AreEqual(false, actual, "NPC debería ser false inicialmente");
        }


        //5. Comprobar que al llamar a asignarNPC(), el atributo npc pasa a ser true.
        [TestMethod]
        public void AsignarNPC_PasaATrue()
        {
            // preparación del caso de prueba
            Jugador j = new Jugador("Ash");

            // acción a probar
            j.asignarNPC();

            // comprobación
            bool actual = j.Npc;
            Assert.AreEqual(true, actual, "NPC no pasa a true");
        }


        //6. Comprobar que al asignar y luego desasignar NPC, el atributo npc vuelve a ser false.
        [TestMethod]
        public void AsignarYDesasignarNPC_VuelveAFalse()
        {
            // preparación del caso de prueba
            Jugador j = new Jugador("Ash");

            // acción a probar
            j.asignarNPC();
            j.desasignarNPC();

            // comprobación
            bool actual = j.Npc;
            Assert.AreEqual(false, actual, "NPC no vuelve a false");
        }


        //7. Verificar que al intentar quitar más oro del disponible, se lanza una excepción (ExpectedException y ArgumentOutOfRangeException).
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void QuitarOro_MasQueDisponible()
        {
            // preparación del caso de prueba
            Jugador j = new Jugador("Ash");

            // acción a probar
            j.quitarOro(10);

            // comprobación manejada por el atributo ExpectedException
        }


        //8. Verificar que al intentar quitar resistencia cuando no es posible, se lanza una excepción(ExpectedException y ArgumentOutOfRangeException).
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void QuitarResistencia_NoPosible_LanzaExcepcion()
        {
            // preparación del caso de prueba
            Jugador j = new Jugador("Ash");

            // acción a probar, forzando
            while (j.Resistencia > 0)
            {
                j.quitarResistencia();
            }

            j.quitarResistencia();
            
            // comprobación manejada por el atributo ExpectedException
        }


        //9. Verificar que al intentar cambiar el nombre del jugador a null, se lanza una excepción NullPointerException.
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IntentarNombreNull()
        {
            // preparación del caso de prueba
            Jugador j = new Jugador("Ash");

            // acción a probar
            j.cambiarNombre(null);

            // comprobación manejada por el atributo ExpectedException
        }


        //10. Verificar que al crear un jugador con nombre null, se lanza una excepción NullPointerException.
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CambiarNombreNull()
        {
            // preparación del caso de prueba
            Jugador j = new Jugador("Ash");

            // acción a probar
            j.cambiarNombre(null);

            // comprobación manejada por el atributo ExpectedException
        }

        // ¿La 9 y la 10 no son lo mismo? He puesto distinto método con lo mismo dentro pq yo lo entiendo igual. ¿O en el hecho de intentarlo hay alguna diferencia?

        //11. Verificar que si npc es true y se intenta añadir resistencia lanza una excepción.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NPCTrueAnyadirResistencia()
        {
            // preparación
            Jugador j = new Jugador("Ash");
            j.asignarNPC();

            // acción a probar
            j.anyadirResistencia();
        }


















    }
}