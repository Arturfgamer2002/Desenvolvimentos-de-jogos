using System;

class Comparadores {
     static void Main (string[] args) {
          int numero1 = 10;
          int numero2 = 3;

          //Verifica se um é igual ao outro
          Console.WriteLine(numero1 == numero2); //False

          //Verifica se um é diferente do outro
          Console.WriteLine(numero1 != numero2); //True

          //Verifica se um é meior que o outro
          Console.WriteLine(numero1 > numero2); //True

          //Verifica se um é maior ou igual ao outro
          Console.WriteLine(numero1 >= numero2); //True

          //Verifica se um é menor que o outro
          Console.WriteLine(numero1 < numero2); //False 

          //Verifica se um é menor ou igual ao outro
          Console.WriteLine(numero1 <= numero2); //False
          }
}

