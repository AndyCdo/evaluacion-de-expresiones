using System;

namespace evaluacion_de_expresiones
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                var resultado = 2+3;
                Console.WriteLine("Resultado 1: " + resultado); 
            } catch (Exception e) {
               Console.WriteLine("Resultado 1: " + e.Message); 
            }
            /*
            try {
                var resultado = 4/0;
                Console.WriteLine("Resultado 2: " + resultado); 
            } catch (Exception e) {
               Console.WriteLine("Resultado 2: " + e.Message); 
            }*/

            try {
                var resultado = 5+3*2;
                Console.WriteLine("Resultado 3: " + resultado); 
            } catch (Exception e) {
               Console.WriteLine("Resultado 3: " + e.Message); 
            }
            /*
            try {
                var resultado = "5"+"3"*2;
                Console.WriteLine("Resultado 4: " + resultado); 
            } catch (Exception e) {
               Console.WriteLine("Resultado 4: " + e.Message); 
            }*/

            try {
                var resultado = Math.Pow(2,10) == 1000 || Math.Pow(2,7) == 100;
                Console.WriteLine("Resultado 5: " + resultado); 
            } catch (Exception e) {
               Console.WriteLine("Resultado 5: " + e.Message); 
            }
            /*
            try {
                var resultado = int("cuarentena");
                Console.WriteLine("Resultado 6: " + resultado); 
            } catch (Exception e) {
               Console.WriteLine("Resultado 6: " + e.Message); 
            }
*/
            try {
                var resultado = 70/16 + 100/24;
                Console.WriteLine("Resultado 7: " + resultado); 
            } catch (Exception e) {
               Console.WriteLine("Resultado 7: " + e.Message); 
            }
/*
            try {
                var resultado = 200 + 19%;
                Console.WriteLine("Resultado 8: " + resultado); 
            } catch (Exception e) {
               Console.WriteLine("Resultado 8: " + e.Message); 
            }
*/
/*
            try {
                var resultado = 3 < (1024 % 10) < 6;
                Console.WriteLine("Resultado 9: " + resultado); 
            } catch (Exception e) {
               Console.WriteLine("Resultado 9: " + e.Message); 
            }
*/
            try {
                var resultado = "six" + "eight";
                Console.WriteLine("Resultado 10: " + resultado); 
            } catch (Exception e) {
               Console.WriteLine("Resultado 10: " + e.Message); 
            }
/*
            try {
                var resultado = "six" * "eigth";
                Console.WriteLine("Resultado 11: " + resultado); 
            } catch (Exception e) {
               Console.WriteLine("Resultado 11: " + e.Message); 
            }
            */
            /*
            try {
                var resultado = float(-int("5") + int("10"));
                Console.WriteLine("Resultado 12: " + resultado); 
            } catch (Exception e) {
               Console.WriteLine("Resultado 12: " + e.Message); 
            }*/
            /*
            try {
                var resultado = abas(len("ocho") - len("cinco"));
                Console.WriteLine("Resultado 13: " + resultado);
            } catch (Exception e) {
               Console.WriteLine("Resultado 13: " + e.Message); 
            }*/
            /*
            try {
                var resultado = bool(14) || bool(-20);
                Console.WriteLine("Resultado 14: " + resultado);
            } catch (Exception e) {
               Console.WriteLine("Resultado 14: " + e.Message); 
            }
*/
/*
            try {
                var resultado = float(string(int("5" * 4) / 3)[2]);
                Console.WriteLine("Resultado 15: " + resultado);
            } catch (Exception e) {
               Console.WriteLine("Resultado 15: " + e.Message); 
            }
*/
        }
    }
}
