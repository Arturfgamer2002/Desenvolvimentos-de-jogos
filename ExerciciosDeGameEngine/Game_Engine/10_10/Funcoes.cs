using System;

class Funcao {
      public void calculaAreaR(int baseR, int alturaR){
        
        int areaR = baseR * alturaR;
        Console.WriteLine(areaR);  
        }    

     static void Main (string[] args) {
        Funcao meuOBJ = new Funcao();

        meuOBJ.calculaAreaR(5,10);
        meuOBJ.calculaAreaR(7,19);
        meuOBJ.calculaAreaR(9,99);
    }
}