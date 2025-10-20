public class program
{
    public static void Main(string[] args)
    {
        var dataHora = DateTime.Now;

        var hora = 0;
        var minuto = dataHora.Minute;

        int valor;
        string[] nome = new string[100];
        string[] senha = new string[100];
        int[] cpf = new int[100];
        double[] saldo = new double[100];



        if (hora >= 0 & hora < 6)
        {
            Console.WriteLine("Você aqui essa hora? Vai dormir MISERA KKKKKK ");
        }
        Console.WriteLine("SEJA BEM VINDO AO BANCO FAZ DE CONTA - seu dinheiro so existe ma imaginaçao. \n ");

        if (hora >= 6 & hora <= 12)
        {

            Console.WriteLine("BOM DIA!!! \n");
        }
        else if (hora > 12 & hora <= 18)
        {
            Console.WriteLine("BOA TARDE!!! \n ");
        }
        else if (hora > 18 & hora <= 23)
        {
            Console.WriteLine("BOA NOITE \n !!!");
        }


        do
        {
            Console.WriteLine("Escolha uma opção abaixo \n ");
            Console.WriteLine("1 - CADASTRO");
            Console.WriteLine("2 - LOGIN");
            Console.WriteLine("3 - SAIR");
            valor = int.Parse(Console.ReadLine());

            if (valor <= 0 || valor >= 4)
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
                valor = int.Parse(Console.ReadLine());
            }

            if (valor == 1)
            {
                Console.WriteLine("VOCÊ ENTROU NO CADASTRO:");
                Console.WriteLine("Digite seu nome completo");
                nome[1] = Console.ReadLine();
                Console.WriteLine("Digite seu CPF");
                cpf[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite sua senha");
                senha[1] = Console.ReadLine();
                Console.WriteLine("Seu saldo inicial");
                saldo[1] = double.Parse(Console.ReadLine());

                Console.WriteLine("Cadastro realizado com sucesso! \n");

            }
            if (valor == 2)
            {
                Console.WriteLine("VOCÊ ENTROU NO LOGIN:");
                Console.WriteLine("Digite seu CPF");
                int cpfDigitado = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite sua senha");
                string senhaDigitada = Console.ReadLine();
                if (cpfDigitado != cpf[1] || senhaDigitada != senha[1])
                {
                    Console.WriteLine("CPF ou senha incorretos! Tente novamente.");
                    continue;
                }
                else if (cpfDigitado == cpf[1] && senhaDigitada == senha[1])
                {
                    int opcao;
                    do
                    {
                        Console.WriteLine($"Seja bem vindo {nome[1]}! \n");
                        Console.WriteLine("Escolha uma opção abaixo \n ");
                        Console.WriteLine("1 - DEPOSITAR");
                        Console.WriteLine("2 - SACAR");
                        Console.WriteLine("3 - VER SALDO");
                        Console.WriteLine("4 - TRANSFERIR");
                        Console.WriteLine("5 - SAIR");
                        opcao = int.Parse(Console.ReadLine());

                        if (opcao == 1)
                        {
                            Console.WriteLine("Digite o valor que deseja depositar:");
                            double valorDeposito = double.Parse(Console.ReadLine());
                            saldo[1] = saldo[1] + valorDeposito; // ou saldo[1] += valorDeposito;
                            Console.WriteLine("Seu valor foi depositado!");
                            Console.WriteLine("Seu saldo é de: " + saldo[1]);

                        }
                        if (opcao == 2)
                        {
                            Console.WriteLine("Digite o valor que você quer sacar: ");
                            double valorSacado = double.Parse(Console.ReadLine());
                            if (valorSacado > saldo[1])
                            {
                                Console.WriteLine("Saldo insuficiente!");
                                continue;
                            }
                            else
                            {
                                saldo[1] -= valorSacado;

                                Console.WriteLine("Saque realizado com sucesso!");
                                Console.WriteLine("Você sacou: " + saldo[1]);

                            }

                        }
                        if (opcao == 3)
                        {
                            Console.WriteLine("Seu saldo é de: " + saldo[1]);

                        }
                        if (opcao == 4)
                        {
                            Console.WriteLine("Digite o valor que você quer transferir: ");

                        }
                        if (opcao == 5)
                        {
                            Console.WriteLine("VOCÊ SAIU DA SUA CONTA, ATÉ LOGO!");
                            break;
                        }
                        opcao = 0;

                    } while (opcao <= 4 || opcao >= 6);


                }

            }
            if (valor == 3)
            {
                Console.WriteLine("VOCÊ SAIU DO SISTEMA, ATÉ LOGO!");
                break;
            }
            valor = 0;
        } while (valor > 0 || valor <= 2);

    }
}
