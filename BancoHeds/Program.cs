public class Program
{
    public static void Main(string[] args)
    {
       
        var dataHora = DateTime.Now;

        var hora = dataHora.Hour;
        var minuto = dataHora.Minute;
        int valor;
        string[ ] nome = new string[100];
        string[ ] senha = new string[100];
        double[ ] saldo = new double[100];




        Console.WriteLine(hora + ":" + minuto);
        

        if (hora >= 0 & hora <= 6)
        {
           Console.WriteLine("VOCÊ ESTÁ MUITO CEDO AQUI NÃO ACHA? VAI DORMI MISERA KKKK!!!");
        }

        if (hora >= 6 & hora <= 12)
        {
          Console.WriteLine("BOM DIA! \n");
        }
        else if (hora > 12 & hora <= 18)
        {
          Console.WriteLine("BOA TARDE! \n");
        }
        else if (hora > 18 & hora <= 23)
        {
            Console.WriteLine("BOA NOITE! \n");
        }
        Console.WriteLine("SEJA BEM VINDO AO BANCO FAZ DE CONTA – Seu dinheiro só existe na imaginação. \n ");
        do
        {           
            Console.WriteLine("Escolha uma opção abaixo:");
            Console.WriteLine("1 - CADASTRO");
            Console.WriteLine("2 - LOGUIN");
            Console.WriteLine("3 - SAIR");
            valor = int.Parse(Console.ReadLine());

            if (valor <= 0 || valor >=4 )
            {
                Console.WriteLine("OPÇÃO INVÁLIDA, TENTE NOVAMENTE! \n");
                valor = int.Parse(Console.ReadLine());  
            }
            if (valor == 1)
            {
                Console.WriteLine("VOCÊ ENTROU NO CADASTRO: \n");
                Console.WriteLine("Digite seu nome completo:");
                nome[0] = Console.ReadLine();
            }

        } while (valor <= 0 || valor >=4);
        Console.Clear();


       

    }
}