/* Exercícios 1: Variaveis
- Crie um novo arquirvo;
- Chame ele de Exrcicio1.cs;
- Coloque dntro dele o código base, conforme ensinei (using System, class, Main, etc)
- Crie 4 variáveis int, coloque valor diferente para cada uma, e faça a soa da primeira com a segunda, proimeira com a terceira, primeira com a quarta e imprime isso usando Consol.WriteLine()
*/

using System;

class Exrcicio1 {
     static void Main (string[] args) {
        int numeroUm = 4;
        int numeroDois = 3;
        int numeroTres = 15;
        int numeroQuatro = 8;
        int soma1 = numeroUm + numeroDois;
        int soma2 = numeroUm + numeroTres;
        int soma3 = numeroUm + numeroQuatro;
            Console.WriteLine($"A soma do resultado do {numeroUm} + {numeroDois} é {soma1}");
            Console.WriteLine($"A soma do resultado do {numeroUm} + {numeroTres} é {soma2}");
            Console.WriteLine($"A soma do resultado do {numeroUm} + {numeroQuatro} é {soma3}"); 
     }
}

