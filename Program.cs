using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Modelo 1", "123443422", 90);
nokia.Ligar();
nokia.InstalarAplicativo("Discord");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("12332212", "Modelo 2", "123456789", 160);
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");
