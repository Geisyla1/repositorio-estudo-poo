using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456","modelo 1","111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whtsapp");

Console.WriteLine("\n");
Smartphone iphone = new Iphone("123456","modelo 1","111111",64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");