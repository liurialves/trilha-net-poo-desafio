using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("smartphone Nokia");
Smartphone nokia = new Nokia (numero: "561920",  modelo: "Modelo 01", mei: "12345678", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("smartphone iphone");
Smartphone iphone = new Iphone (numero: "55555", modelo: "1234566", mei: "123678", memoria:500);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
