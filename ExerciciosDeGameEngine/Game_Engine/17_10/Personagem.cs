using System;

class Personagem {
// Atributos - variaveis que a classe usa
public string nome;
public int forca;
public int vida;
// Construtor - é uma função/métado que define como os objetos sao criados. ela é chamada toda vez que criamos um objeto com essa classe.
public Personagem(string nomePersonagem, int forcaInicial, int vidaInicial){
      nome = nomePersonagem;
      forca = forcaInicial;
      vida = vidaInicial;
}

// Métodos - são as funções que representam o que o objeto dessa classe pode fazer
public void Atacar(){
    Console.WriteLine($"{nome} ataca com {forca} pontos de força");
}

public void Andar(){
    Console.WriteLine($"{nome} esta andando.");
}
}

class Jogo {
   static void Main(string[] args){
    // Criar um personagem
    //Instanciar o objeto/Criae o objetio
    Personagem personagem1 = new Personagem("Robison", 20, 600);

    //Usando os métodos do persogem
    personagem1.Atacar();
    personagem1.Andar();
   }
}