using DesafioPOO.Models;

// Console.WriteLine("NOKIA");
// Smartphone nokia = new Nokia("4002-8922", "modelo 1", "456789", 16);
// nokia.Ligar();
// nokia.Numero = "9278-4931";
// nokia.InstalarAplicativo("Netflix");
// nokia.ReceberLigacao();
// Console.WriteLine(nokia);

// Console.WriteLine("IPHONE");
// Smartphone iphone = new Iphone("4002-8922", "modelo 1", "456789", 16);
// iphone.Ligar();
// iphone.Numero = "9278-4931";
// iphone.InstalarAplicativo("Disney+");
// iphone.ReceberLigacao();

//TESTE COM A CLASSE NOKIA

Console.WriteLine("Olá! Esse é um Smartphone da NOKIA.");
Console.WriteLine("Para que você tenha uma melhor experiência vamos configurar seu Smartphone!\n");
Console.WriteLine("Digite seu número:");
string numero = Console.ReadLine();
Console.WriteLine("Digite o modelo do seu Smartphone:");
string modelo = Console.ReadLine();
Console.WriteLine("Digite seu IMEI:");
string imei = Console.ReadLine();
Console.WriteLine("Digite a quantidade de GB (mémoria) do seu Smarphone:");
int memoria = Convert.ToInt16(Console.ReadLine());

Smartphone nokia02 = new Nokia(numero, modelo, imei, memoria);
Console.WriteLine(nokia02);

bool condicao = true;
do 
{
    Console.WriteLine("Selecione uma opção:\n[1] Ligar\n[2] Receber Ligação\n[3] Instalar Aplicativo\n[4] Alterar número\n[5] Exibir informações do Smartphone\n[6] Encerrar o Uso");
    string opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            nokia02.Ligar();
            break;

        case "2":
            nokia02.ReceberLigacao();
            break;

        case "3":
            Console.WriteLine("Qual App você deseja instalar?");
            string aplicativo = Console.ReadLine();
            nokia02.InstalarAplicativo(aplicativo);
            break;

        case "4":
            Console.WriteLine("Digite seu novo número:");
            nokia02.Numero = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine(nokia02);
            break;

        case "6":
            condicao = false;
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar\n");
    Console.ReadLine();
    
}while(condicao);

Console.WriteLine("O uso do Nokia se encerrou\n\n");



//TESTE COM A CLASSE IPHONE

Console.WriteLine("Olá! Esse é um Smartphone da APPLE.");
Console.WriteLine("Para que você tenha uma melhor experiência vamos configurar seu Smartphone!\n");
Console.WriteLine("Digite seu número:");
numero = Console.ReadLine();
Console.WriteLine("Digite o modelo do seu Iphone:");
modelo = Console.ReadLine();
Console.WriteLine("Digite seu IMEI:");
imei = Console.ReadLine();
Console.WriteLine("Digite a quantidade de GB (mémoria) do seu Smarphone:");
memoria = Convert.ToInt16(Console.ReadLine());

Smartphone iphone02 = new Iphone(numero, modelo, imei, memoria);
Console.WriteLine(iphone02);

condicao = true;
do 
{
    Console.WriteLine("Selecione uma opção:\n[1] Ligar\n[2] Receber Ligação\n[3] Instalar Aplicativo\n[4] Alterar número\n[5] Exibir informações do Smartphone\n[6] Encerrar o Uso");
    string opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            iphone02.Ligar();
            break;

        case "2":
            iphone02.ReceberLigacao();
            break;

        case "3":
            Console.WriteLine("Qual App você deseja instalar?");
            string aplicativo = Console.ReadLine();
            iphone02.InstalarAplicativo(aplicativo);
            break;

        case "4":
            Console.WriteLine("Digite seu novo número:");
            iphone02.Numero = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine(iphone02);
            break;

        case "6":
            condicao = false;
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar\n");
    Console.ReadLine();
    
}while(condicao);

Console.WriteLine("O uso do Iphone se encerrou");