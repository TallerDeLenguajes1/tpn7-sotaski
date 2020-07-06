using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDeCalculadora
{
    class Calculadora
    {
        private float num1;
        private float num2;

        public float Num1 { get => num1; set => num1 = value; }
        public float Num2 { get => num2; set => num2 = value; }

        public float Suma(float Numm, float Nummm)
        {
            return Numm + Nummm;
        }

        public float Resta(float Num1, float Num2)
        {
            return Num2 - Num1;
        }

        public float Multiplicaion(float Num1, float Num2)
        {
            return Num2 * Num1;
        }

        public float Divicion(float Num1, float Num2)
        {
            if (Num2 != 0)
            {
                return Num1 / Num2;
            }
            else
            {
                Console.WriteLine("no se puede realizar la divicion");
                return 0;
            }
        }
        public float Calculador(string numero)
        {
            string ecuacion = numero;
            int cont = 0;
            float n1, n2;
            float REsult = 0;
            string[] dividir;
            foreach (char car in ecuacion)
            {
                switch (car)
                {
                    case '+':
                        dividir = ecuacion.Split(car);
                        n1 = float.Parse(dividir[0]);

                        n2 = float.Parse(dividir[1]);
                        REsult = Suma(n1, n2);
                        break;
                    case '-':
                        dividir = ecuacion.Split(car);
                        n1 = float.Parse(dividir[0]);

                        n2 = float.Parse(dividir[1]);
                        REsult = Resta(n1, n2);
                        break;
                    case '*':
                        dividir = ecuacion.Split(car);
                        n1 = float.Parse(dividir[0]);

                        n2 = float.Parse(dividir[1]);
                        REsult = Multiplicaion(n1, n2);
                        break;
                    case '/':
                        dividir = ecuacion.Split(car);
                        n1 = float.Parse(dividir[0]);

                        n2 = float.Parse(dividir[1]);
                        REsult = Divicion(n1, n2);
                        break;
                    default: break;
                }
                cont++;
            }
            return REsult;
        }
    }
}
