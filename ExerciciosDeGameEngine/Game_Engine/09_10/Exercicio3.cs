/* 
Para entrar na faculdade, uma pessoa precisa:
1 - Ter 18 ano ou mais
2 - Ter concluído o ensino médio
3 - Não estar em outra faculdade

Faça um Console.WriteLine que contenha a equação, usado operadores lógicos, que diz se uma pessoa pode ou não entrar na faculdade
*/

using System;

class Exercicio3 {
     static void Main (string[] args) {
         bool estaEmOutraFaculdade = false;
          int idade = 21;
          bool maiorIdade = idade >= 18;
          bool ensinoMedio = true;

          Console.WriteLine($"Para entrar na faculdade, uma pessoa precisa: Ter 18 ano ou mais,Ter concluído o ensino médio,Não estar em outra faculdade");
          Console.WriteLine($"Você esta em outra faculde? {estaEmOutraFaculdade}.");
          Console.WriteLine($"Você tem ensino médio completo? {ensinoMedio}.");
           Console.WriteLine($"Você é  de maior? {maiorIdade}.");
            Console.WriteLine(ensinoMedio && maiorIdade && !estaEmOutraFaculdade);
    }
}
