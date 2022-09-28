using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("498787", "8 Plus", "987654321", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("993155", "G50", "123456789", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");