// Loops são estruturas de repetião

// Loop while
// While -- enquanto

using System;

class Loops {
     static void Main (string[] args) {
        /*
        
        int voltas = 0;
        
        while(voltas <= 10) {
        
        Console.Writeline($"Você já deu {voltas} voltas. Pedale");
        voltas = voltas + 1;
        // voltas += 1
        // viltas ++
        }      
        
        */
        
        for (int voltas = 0; voltas < 10; voltas ++) {
          Console.WriteLine($"Você pedalou {voltas} voltas.");
        }

    }
}