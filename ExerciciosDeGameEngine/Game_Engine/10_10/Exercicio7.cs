/*
Crie uma váriavel que receba um número de 1 a 10
Usuando for, imprima a tabuada desse número
*/

using System;

class Exericiio7 {
     static void Main (string[] args) {
         int numero = 5;
         for (int i = 1; i <= 10; i ++) {
          Console.WriteLine($"{numero} X {i} = {numero * i}.");
        }
    }
}