using DesafioPOO.Models;


bool abrirMenu = true;

while(abrirMenu == true){
    Console.WriteLine("Escolha qual celular quer testar.");
    Console.WriteLine("1 - Nokia");
    Console.WriteLine("2 - IPhone");
    Console.WriteLine("3 - Sair");
    
    switch(Console.ReadLine())
    {
        case "1":
            Console.WriteLine("\nTestando Nokia\n");
            Nokia nokia = new Nokia(numero: "11111111111", modelo: "Modelo Nokia", imei: "222222222", memoria: 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            Console.WriteLine("\nQual aplicativo quer instalar?\n");
            nokia.InstalarAplicativo(Console.ReadLine());
            break;
        case "2":
            Console.WriteLine("\nTestando IPhone\n");
            Iphone iphone = new Iphone(numero: "33333333333", modelo: "Modelo IPhone", imei: "444444444", memoria: 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            Console.WriteLine("\nQual aplicativo quer instalar?\n");
            iphone.InstalarAplicativo(Console.ReadLine());
            break;
        case "3":
            Console.WriteLine("Encerrando...\n");
            abrirMenu = false;
            break;
        default:
            Console.WriteLine("\nEntrada inválida.\n");
            break;
    }
}