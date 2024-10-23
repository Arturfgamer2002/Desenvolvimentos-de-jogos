// Arrays são lists de valores

using System;

class Arrays {
     static void Main (string[] args) {
        string[] listaMercado = new string[3] {"pão", "arroz", "carne"};
        for (int i = 0; i < 3; i++) {
         Console.WriteLine(listaMercado[i]);
        }  
    }
}