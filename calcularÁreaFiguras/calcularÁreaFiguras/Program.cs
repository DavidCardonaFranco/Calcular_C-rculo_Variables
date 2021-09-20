using System;

namespace calcularCírculo
{
    public static class Global
    {
        public static double pi = 3.1415;
    }

    class Program
    {
        static void Main(string[] args)
        {

            double radio;
            calcularCírculo figura = new calcularCírculo();

            Console.WriteLine("CÍRCULO");
            Console.WriteLine("Digite el valor de su radio. ");
            radio = double.Parse(Console.ReadLine());

            Console.WriteLine("CALCULAR ÁREA DEL CÍRCULO.");
            Console.WriteLine("El área del círculo es de {0} cm", figura.calcularÁrea(radio));

            Console.WriteLine("CALCULAR PERÍMETRO DEL CÍRCULO.");
            Console.WriteLine("El perímetro del círculo es de {0} cm", figura.calcularPerímetro(radio));


        }
    }

    public class calcularCírculo
    {
        public double calcularÁrea (double radio)
        {
            return (Global.pi * Math.Pow(radio,2));
        }

        public double calcularPerímetro(double radio)
        {
            return (2 * Global.pi * radio);
        }
    }

}
