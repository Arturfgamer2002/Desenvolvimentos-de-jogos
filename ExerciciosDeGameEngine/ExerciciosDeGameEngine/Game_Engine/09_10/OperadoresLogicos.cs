using System;

class OperadoresLogicos {
     static void Main (string[] args) {
          bool temCarteira = true;
          int idade = 21;
          bool maiorIdade = idade >= 18;

          Console.WriteLine($"Para poder dirigir, uma pessoa precisa ter uma carteira e ter 18 anos ou mais.");
          Console.WriteLine($"Você tem carteira: {temCarteira}.");
           Console.WriteLine($"Você é  de maior {maiorIdade}.");
           // Operador Lógico e(and): retorna true apenas se todos forem true
           // Apenas um único false já é suficiente para que a equação retorne false
            Console.WriteLine(temCarteira == true && maiorIdade == true);

        /*
        true && false // false
        false && true // false
        false && false // false
        */

            // Operador Lógico ou(or): retorna false apenas se todos forem false. Apenas um único true já é suficiente para que a equação retorne true.

            bool temTrabalho= true;
            bool economiza = true;
            bool investe = true;
            bool nasceuHerdeiron = false;

            Console.WriteLine((temTrabalho && economiza && investe) || nasceuHerdeiron)

        /*
        true || true // true
        true || false // true
        false || true // true
        false || false // false
        */

            // Operador Lógico nao/negacao(not): inverte o estado. Se algo retorna em true, ele transforma true, ele transforma em false e vice-versa
            
        /*
        !true //false
        !false //true 
        */

            bool ligado = true;
            Console.WriteLine(!ligado); // false
    }
}
