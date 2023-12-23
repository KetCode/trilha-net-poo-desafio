using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\nSmartphone Nokia:");
Smartphone nokia = new Nokia(numero: "40028922", modelo: "X30", imei:"353612653779459", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "993919231", modelo: "iPhone 14 Pro", imei:"354627901371270", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("dio.me");