﻿Console.WriteLine("Digite sua placa:");
string placa = Console.ReadLine();

string final = placa.Substring(placa.Length - 3, 1);

if (final == "1" || final == "2") {
    Console.WriteLine("Você não pode sair em SP na segunda feira");
} else if (final == "3" || final == "4") {
    Console.WriteLine("Você não pode sair em SP na terça feira");
} else if (final == "5" || final == "6") {
    Console.WriteLine("Você não pode sair em SP na quarta feira");
} else if (final == "7" || final == "8") {
    Console.WriteLine("Você não pode sair em SP na quinta feira");
} else if (final == "9" || final == "0") {
    Console.WriteLine("Você não pode sair em SP na sexta feira");
}

