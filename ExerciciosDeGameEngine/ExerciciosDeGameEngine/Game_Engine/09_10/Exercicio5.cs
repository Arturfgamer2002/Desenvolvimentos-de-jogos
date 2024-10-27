/* 
Usando Switch, crie uma variavel chamada meuTime
Faça um Swith com cada casa representando um time, e imprima algo diferente para cada um
Não esqueça do defalt
*/

using System;

class Exercicio4 {
     static void Main (string[] args) {
            switch (nacionalidade) {
            case "Gremio":
            Console.WriteLine("É um time legal!");
            break;
            
            case "Inter":
            Console.WriteLine("É um time legal!");
            break;

             case "Palmeiras":
            Console.WriteLine("Não tem mundial!");
            break;

            default: 
            Console.WriteLine("Seu time não foi encontrado!");
            break;
         }
    }
}
