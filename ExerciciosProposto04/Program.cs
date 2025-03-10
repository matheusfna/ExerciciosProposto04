using System;
using System.Globalization;

namespace ExerciciosProposto04 {
    class URI {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            //Vetor e sua instacia
            double[] vet = new double[n];


            string[] s = Console.ReadLine().Split(' ');

            //Calculo da soma
            double media = 0;
            double soma = 0;
            for(int i = 0; i < n; i++) {
                vet[i] = double.Parse(s[i],CultureInfo.InvariantCulture);
                soma = soma + vet[i];
                media = soma / n;
            }
            Console.WriteLine(media.ToString("F3",CultureInfo.InvariantCulture));

            for(int i = 0; i < n; i++) {
                if(vet[i] < media) {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
            }
        }
    }
}



