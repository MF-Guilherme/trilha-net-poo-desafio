using DesafioPOO.Models;

Nokia nokia = new Nokia("11988887777", "Nokia N2", "123456789987456", 16);
Iphone iphone = new Iphone("11933334444", "Iphone 9", "98765432145678", 32);

System.Console.WriteLine("Smartphone Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine();

System.Console.WriteLine("Smartphone Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
