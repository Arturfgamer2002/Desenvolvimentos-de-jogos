/*
Criar uma função que receba seu nome, sua idade e sua altura e imprime no terminal
*/

using System;

class Exercicio9 {
    public void meuNome(string nome, int idade, double altura){
    Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos e minha altura é {altura}")
    static void Main (string[] args) {
      Exercicio9 meuObj = new Exercicio9();
      meuObj.meuNome("Artur", 21, 1.70);
    }
// void - Quando nao retornar nada
// String, int, double, char - Quando precisar retornr algo
    public double conta (double num1, double num2){ 
    double resultado = num1 + num2;
    return resultado;
    }

    static void Main (string[] args) {
      Exercicio9 meuObj new Exercicio9();
      double numero = meuObj.conta(5,6);
      Console.WriteLine(numero + 10);
    }
}
}