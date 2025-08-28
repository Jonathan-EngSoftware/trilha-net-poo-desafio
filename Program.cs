using DesafioPOO.Models;
using trilha_net_poo_desafio.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123456789", 16);
Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI987654321", 64);
Samsung samsung = new Samsung("456789123", "Samsung Galaxy S21", "IMEI456789123", 128);

Console.WriteLine($"Nokia - Modelo:{nokia.Modelo}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("'WhatsApp'");

Console.WriteLine("\n-----\n");

Console.WriteLine($"iPhone - Modelo:{iphone.Modelo}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("'Telegram'");

Console.WriteLine("\n-----\n");

Console.WriteLine($"Samsung - Modelo:{samsung.Modelo}");
samsung.Ligar();
samsung.ReceberLigacao();
samsung.InstalarAplicativo("'Facebook'");
