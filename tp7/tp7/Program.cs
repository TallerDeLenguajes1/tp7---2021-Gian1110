using System;
using System.Collections.Generic;

namespace tp7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Calculadora();
        }

        public static void Calculadora()
        {
            List<nodo> lista = new List<nodo>();
            int Operacion = 0, Numero1 = 0;
            float Numero2 = 0, Resultado = 0;
            char OtraOperacion = 'y', borrar;
            while (OtraOperacion == 'y')
            {
                while (Operacion < 1 || Operacion > 4)
                {
                    Console.WriteLine("Que operacion desea realizar ?\n1) Suma\n2) Resta\n3) Multiplicacion\n4) Division");
                    Operacion = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                Console.WriteLine("ingrese el primero numero:");
                Numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el segundo numero:");
                Numero2 = float.Parse(Console.ReadLine());
                Console.Write("el resultado de ");
                switch (Operacion)
                {
                    case 1:
                        Resultado = Numero1 + Numero2;
                        Console.WriteLine("la suma entre " + Numero1 + " y " + Numero2 + " es: " + Resultado);
                        break;
                    case 2:
                        Resultado = Numero1 - Numero2;
                        Console.WriteLine("la resta entre " + Numero1 + " y " + Numero2 + " es: " + Resultado);
                        break;
                    case 3:
                        Resultado = Numero1 * Numero2;
                        Console.WriteLine("la multiplicacion entre " + Numero1 + " y " + Numero2 + " es: " + Resultado);
                        break;
                    default:
                        Resultado = Numero1 / Numero2;
                        Console.WriteLine("la division entre " + Numero1 + " y " + Numero2 + " es: " + Resultado);
                        break;
                }
                nodo aux = new nodo(Numero1, Numero2, Operacion, Resultado, DateTime.Now);
                lista.Add(aux);
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.Write(i+1 + ")" + lista[i].Dia_hora.Day + "/" + lista[i].Dia_hora.Month + "/" + lista[i].Dia_hora.Year + " " + lista[i].Dia_hora.Hour + ":" + lista[i].Dia_hora.Minute + " ---> " + Numero1);
                    switch (lista[i].Operador)
                    {
                        case 1:
                            Console.Write("+");
                        break;
                        case 2:
                            Console.Write("-");
                        break;
                        case 3:
                            Console.Write("*");
                        break;
                        case 4:
                            Console.Write("/");
                        break;
                        default:
                        break;
                    }
                    Console.WriteLine(lista[i].Numero21 + "=" + lista[i].Resultado1);
                }
                Console.WriteLine("desea eliminar un elemento del historial ? (y/n)");
                borrar = char.Parse(Console.ReadLine());
                if (borrar == 'y' || borrar == 'Y')
                {
                    Console.WriteLine("elija el numero de fila de la operacion que desea borrar");
                    lista.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                }
                do
                {
                    Console.WriteLine("quiere realizar otra operacion (y/n)");
                    OtraOperacion = char.Parse(Console.ReadLine());
                } while (OtraOperacion != 'n' && OtraOperacion != 'N' && OtraOperacion != 'y' && OtraOperacion != 'Y');
                if (OtraOperacion == 'y' || OtraOperacion == 'Y')
                {
                    Operacion = 0;
                }
            } 
        }

    }
}
