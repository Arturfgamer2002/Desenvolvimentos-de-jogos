/*
 Uma contagem que vai ate 10 a 0
Se o segundo for par, imprime "TIC"
Se o segundo for ímpar, imprime "TAC"
Quando a contagem chegar a 0, imprime "BOOOM!"
*/

using System;

class Exericiio6 {
     static void Main (string[] args) {
         int segundo = 10;
         
         while (segundo >= 0){
            if (segundo == 0){
            Console.WriteLine("Booom!");
            } else if(segundo % 2 == 0){
              Console.WriteLine("TIC");
            }else {
              Console.WriteLine("TAC");
            }
            segundo --;
         }        
    }
}