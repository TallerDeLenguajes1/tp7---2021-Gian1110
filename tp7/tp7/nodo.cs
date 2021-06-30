using System;
namespace tp7
{
    public class nodo
    {
        private int Numero1;
        private float Numero2;
        private int operador;
        private float Resultado;
        private DateTime dia_hora;
        private nodo siguiente;

        public nodo(int numero1, float numero2, int Operador, float resultado, DateTime Dia_hora)
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
        public float Numero21
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
        public int Operador
        {
            get => operador;
            set => operador = value;
        }
        public float Resultado1
        {
            get => Resultado;
            set => Resultado = value;
        }
    }
}
