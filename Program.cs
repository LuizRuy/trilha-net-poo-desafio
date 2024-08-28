using DesafioPOO.Models;

Console.WriteLine("Celular Nokia.");
Nokia nokia = new Nokia("4343243", "verde", "2222222", 123);
nokia.Ligar();
nokia.InstalarAplicativo("X");

Console.WriteLine(" ");

Console.WriteLine("Celular Iphone.");
Iphone iphone = new Iphone("4324332456", "Azul", "11111111", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");