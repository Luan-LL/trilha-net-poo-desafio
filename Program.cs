using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia :");
Smartphone nokia = new Nokia(numero : "123456", modelo : "Modelo 1", imei:"9639966",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n\n");

Console.WriteLine("Smartphone Iphone :");
Smartphone iphone = new Iphone(numero: "5454448", modelo: "Modelo 2", imei: "528284", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

