/*
Crie um array que contenha seus 5 jogos favoritos
Imprima todo o array
Depois, imprima um por um
*/

using System;

class Exercicio8 {
     static void Main (string[] args) {
        string[] listaDeJogos = new string[5] {"Cult of the Lamb", "Cyberpunk 2077", "The last Grardians", "Ghostrunner 2", "Stray"};
        
        listaDeJodos[4] = "Stray";

        for (int i = 0; i < listaDeJodos.Length; i++) {
         Console.WriteLine(listaDeJodos[i]);
        }  
        Console.WriteLine(listaDeJodos[0]);
        Console.WriteLine(listaDeJodos[1]);
        Console.WriteLine(listaDeJodos[2]);
        Console.WriteLine(listaDeJodos[3]);
        Console.WriteLine(listaDeJodos[4]);
    }
}