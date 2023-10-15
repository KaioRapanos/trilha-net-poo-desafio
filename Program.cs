using DesafioPOO.Models;

Console.WriteLine("************************");
Console.WriteLine("Smartphone Nokia: ");

Smartphone nokia = new Nokia("41-99876-5432","K500","123456789",128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("************************");
Console.WriteLine("Smartphone Iphone: ");

Smartphone iphone = new Iphone("41-99876-5432","Iphone15","123456789",256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

// TODO: Realizar os testes com as classes Nokia e Iphone