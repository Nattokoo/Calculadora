// Introdução
Console.WriteLine("Deseja usar a Calculadora?");
Console.WriteLine("\"Sim\" para Confirmar");
Console.WriteLine("\"Não\" para Negar");
string ?escolha = Console.ReadLine();

while(1<2)
{

if(escolha == "Sim" || "sim".Equals(escolha) || "SIM".Equals(escolha))
{
    Console.WriteLine("\nPara calcular a Soma de dois numeros digite \n \"1\"");
    Console.WriteLine("Para calcular a Subtração de dois numeros digite \n \"2\"");
    Console.WriteLine("Para calcular a Multiplicação de dois numeros digite \n \"3\"");
    Console.WriteLine("Para calcular a Divisão de dois numeros digite \n \"4\"");
    Console.WriteLine("Para calcular a Potenciação de dois numeros digite \n \"5\"");
    Console.WriteLine("Para Sair da Calculadora digite \n \"0\"\n");

    string ?selecao = Console.ReadLine();

    if(selecao == "1")
    {
            Console.WriteLine("Digite o primeiro numero a ser Somado:");
            string ?entrada = Console.ReadLine();
            int numero1;

            if(int.TryParse(entrada, out numero1))
            {
                Console.WriteLine("Digite o segundo numero a ser Somado:");
                string ?entrada2 = Console.ReadLine();
                int numero2;

                if(int.TryParse(entrada2, out numero2))
                {
                    int resultado = numero1 + numero2;
                    Console.WriteLine("Resultado de "+numero1+" + "+numero2+" = "+resultado);
                }
                else
                {
                    Console.WriteLine("Você não digitou um numero!");
                }
            }
            else
            {
                Console.WriteLine("Você não digitou um numero!");
            }
    }
    else if(selecao == "2")
    {
        Console.WriteLine("Digite o primeiro numero a ser Subtraido:");
        string ?entrada = Console.ReadLine();
            int numero1;

            if(int.TryParse(entrada, out numero1))
            {
                Console.WriteLine("Digite o segundo numero a ser Subtraido:");
                string ?entrada2 = Console.ReadLine();
                int numero2;

                if(int.TryParse(entrada2, out numero2))
                {
                    int resultado = numero1 - numero2;
                    Console.WriteLine("Resultado de "+numero1+" - "+numero2+" = "+resultado);
                }
                else
                {
                    Console.WriteLine("Você não digitou um numero!");
                }
            }
            else
            {
                Console.WriteLine("Você não digitou um numero!");
            }
    }
    else if(selecao == "3")
    {
        Console.WriteLine("Digite o primeiro numero a ser Multiplicado:");
            string ?entrada = Console.ReadLine();
            int numero1;

            if(int.TryParse(entrada, out numero1))
            {
                Console.WriteLine("Digite o segundo numero a ser Multiplicado:");
                string ?entrada2 = Console.ReadLine();
                int numero2;

                if(int.TryParse(entrada2, out numero2))
                {
                    int resultado = numero1 * numero2;
                    Console.WriteLine("Resultado de "+numero1+" * "+numero2+" = "+resultado);
                }
                else
                {
                    Console.WriteLine("Você não digitou um numero!");
                }
            }
            else
            {
                Console.WriteLine("Você não digitou um numero!");
            }
    }
    else if(selecao == "4")
    {
        Console.WriteLine("Digite o primeiro numero a ser Dividido:");
            string ?entrada = Console.ReadLine();
            int numero1;

            if(int.TryParse(entrada, out numero1))
            {
                Console.WriteLine("Digite o segundo numero a ser Dividido:");
                string ?entrada2 = Console.ReadLine();
                int numero2;

                if(int.TryParse(entrada2, out numero2))
                {
                    int resto = numero1 % numero2;
                    int resultado = numero1 / numero2;
                    Console.WriteLine("Resultado de "+numero1+" / "+numero2+" = "+resultado);
                    Console.WriteLine("\nDeseja ver o resto da sua divisão?\n \"Sim\" para Confirmar\n \"Não\" para Negar\n");
                    string ?escolhaResto = Console.ReadLine();

                    if(escolhaResto == "Sim" || "sim".Equals(escolhaResto) || "SIM".Equals(escolhaResto))
                    {
                        Console.WriteLine("Resto da Divisão: "+resto);
                    }
                    else if(escolhaResto == "Não" || "não".Equals(escolhaResto) || "nao".Equals(escolhaResto) || "NAO".Equals(escolhaResto) || "NÃO".Equals(escolhaResto))
                    {
                        Console.WriteLine("Calculo encerrado");
                    }
                    else
                    {
                        Console.WriteLine("valor não computado");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Você não digitou um numero!");
                }
            }
            else
            {
                Console.WriteLine("Você não digitou um numero!");
            }
    }
    else if(selecao == "5")
    {
        Console.WriteLine("Digite o primeiro numero para ser a Base da potenciação:");
            string ?entrada = Console.ReadLine();
            double numero1;

            if(double.TryParse(entrada, out numero1))
            {
                Console.WriteLine("Digite o segundo numero para indicar o Expoente:");
                string ?entrada2 = Console.ReadLine();
                double numero2;

                if(double.TryParse(entrada2, out numero2))
                {
                    double resultado = Math.Pow(numero1, numero2);
                    Console.WriteLine("Resultado de "+numero1+" elevado a "+numero2+"º = "+resultado);
                }
                else
                {
                    Console.WriteLine("Você não digitou um numero!");
                }
            }
            else
            {
                Console.WriteLine("Você não digitou um numero!");
            }
    }
    else if(selecao == "0")
    {
        Console.WriteLine("Saindo da Calculadora");
        Environment.Exit(0);    
    }
    else
    {
        Console.WriteLine("Valor desconhecido");
        Environment.Exit(0);    
    }
}
else if(escolha == "Não" || "não".Equals(escolha) || "nao".Equals(escolha) || "NAO".Equals(escolha) || "NÃO".Equals(escolha))
{
    Console.WriteLine("Saindo da Calculadora");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("Escolha não computada");
    Environment.Exit(0);
}
}