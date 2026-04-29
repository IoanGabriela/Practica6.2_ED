using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadorNS
{
    public class Jugador
    {
        private string _nombre;
        private int _vida;
        private double _oro;
        private bool _npc;
        private int _resistencia;

        // Constructor por defecto
        public Jugador()
        {
        }

        // Constructor con nombre
        public Jugador(string nombre)
        {   
            _nombre = nombre;
            _vida = 100;
            _oro = 0;
            _npc = false;
            _resistencia = 50;
        }

        // Getters
        public string Nombre
        {
            get { return _nombre; }
        }

        public int Vida
        {
            get { return _vida; }
        }

        public double Oro
        {
            get { return _oro; }
        }

        public bool Npc
        {
            get { return _npc; }
        }

        public int Resistencia
        {
            get { return _resistencia; }
        }

        // Métodos
        public void cambiarNombre(string nuevoNombre)
        {
            if (nuevoNombre == null)
            {
                throw new NullReferenceException("El nombre no debe quedar vacío"); //He intentado usar NullPointerException como ponías en los apuntes pero me daba error CS0246.
            }
                
            _nombre = nuevoNombre;
        }

        public void quitarVida(int vida) //Método que no aparecía en los apuntes.
        {
            _vida -= vida;
        }

        public void anyadirOro(int cantidad)
        {
            _oro += cantidad;
        }

        public void quitarOro(int cantidad)
        {
            if (cantidad > _oro)
            {
                throw new ArgumentOutOfRangeException();
            }
                
            _oro -= cantidad;
        }

        public void asignarNPC()
        {
            _npc = true;
        }

        public void desasignarNPC()
        {
            _npc = false;
        }


        public void anyadirResistencia()
        {
            if (_npc == true)
            {
                throw new Exception("Error de resistencia, este personaje es un npc");
            }
            else
            {
                _resistencia += 10;
            }
        }

        public void quitarResistencia()
        {
            if (_resistencia <= 0)
            {
                throw new ArgumentOutOfRangeException("Resistencia agotada");
            }
            else
            {
                _resistencia -= 10;
            }   
        }
    }
}
