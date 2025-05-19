// Console.WriteLine("---- Groot Chatbot ----");

// string pergunta = "";

// while (true)
// {
//     Console.Write("Pergunta:");
//     pergunta = Console.ReadLine()!;
//     if (pergunta == "Tchau")
//     {
//         Console.WriteLine("Eu sou Groot.");
//         break;
//     }

//     Console.WriteLine("Eu sou Groot.");

// }

﻿Console.Clear();
string pergunta = "";
bool respostaEhTchau = false;
Console.WriteLine("--- Groot Chatbot ---");
while (!respostaEhTchau)
{
    Console.Write("Pergunta: ");
    pergunta = Console.ReadLine()!;
    respostaEhTchau = pergunta == "Tchau";
    Console.WriteLine($"                          Resposta: Eu sou Groot{(respostaEhTchau ? "!" : ".")}");
}