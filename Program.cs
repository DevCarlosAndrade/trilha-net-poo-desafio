using DesafioPOO.Models;

Smartphone nokia = new Nokia("12345", "Nokia XYZ", "111111111", 64);

Smartphone iphone = new Iphone("67890", "iPhone 12 pro MAX", "222222222", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.ReadLine();