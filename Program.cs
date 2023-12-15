using DesafioPOO.Models;

Iphone iphone = new Iphone("960206533", "Iphone11", "1212123", "120gb");
Console.WriteLine("Smartphone Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Nokia nokia = new Nokia("960206522", "nokia 1", "5145454", "120gb");
Console.WriteLine("Smartphone Nokia: ");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");