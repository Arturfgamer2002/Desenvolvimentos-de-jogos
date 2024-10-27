/*
Criar uma classe chamada Inimigo.Pense em quais atributos o inimigo deve ter, e o que ele deve fazer (ou seja, seus métodos).Depois que criar esta classe, crie um objeto com ela, dentro da classe jogo e chame os métados.
*/

using System;

class Inimigo {
public string nome;
public int forca;
public int vida;

public Inimigo(string nomeInicial, int forcaInicial, int vidaInicial){
      nome = nomeInicial;
      forca = forcaInicial;
      vida = vidaInicial;
}

public void Atacar(Personagem meuPersonagem){
    Console.WriteLine($"{nome} ataca Personagem com {forca} pontos de força");
}

public void Andar(){
    Console.WriteLine($"{nome} esta andando até o Personagem.");
}
}

class Jogo {
   static void Main(string[] args){
    Inimigo inimigo1 = new Inimigo("Clabison", 8, 100);
    inimigo1.Atacar();
    inimigo1.Andar();
   }
}