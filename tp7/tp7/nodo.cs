using System;
namespace tp6
{
    public class nodo
    {
        private int Numero1;
        private int Numero2;
        private char operador;
        private int Resultado;
        private DateTime dia_hora;
        private nodo siguiente;

        public nodo(int numero1, int numero2, char Operador, int resultado, DateTime Dia_hora)
        {
            Numero1 = numero1;
            Numero2 = numero2;
            operador = Operador;
            Resultado1 = resultado;
            dia_hora = Dia_hora;
            siguiente = null;
        }

        public int Numero11
        {
            get => Numero1;
            set => Numero1 = value;
        }
        public int Numero21
        {
            get => Numero2;
            set => Numero2 = value;
        }
       
        public DateTime Dia_hora {
            get => dia_hora;
            set => dia_hora = value;
        }
        public nodo Siguiente {
            get => siguiente;
            set => siguiente = value;
        }
        public char Operador
        {
            get => operador;
            set => operador = value;
        }
        public int Resultado1
        {
            get => Resultado;
            set => Resultado = value;
        }
    }
}
