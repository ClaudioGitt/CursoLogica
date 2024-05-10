using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class EstudoLogica
{
    static void Main(string[] args)
    {
        /* Treinar a forma de pensar no problema, é a chave para um algoritmo
         * bem construído. Jamais programe diretamente sem pensar um pouco antes.
         * Tentativa e erro nao é a resposta, mas sim saber pensar. /*

        ///* Ok....existem as entradas de dados , e a saída de dados, no caso do Console
        // * Write ou writeLine ( o line pula linha e isso eu já sei)
        // * ele exibe uma mensagem na tela apenas.
        // * nao estou armazenando nada na memória, só quando atribuímos "=" */

        //Console.WriteLine("olá mundo feio"); // pula linha
        //Console.Write("Olá denovo"); // nao pula linha

        ////existem os tipos de dados, ex: bola é um brinquedo, é um tipo de brinquedo.
        ////e existe outro tipo de dado, ex: um tênis é um calçado.
        ////e existe um gato, que é um tipo de animal.
        ////Cada variável armazena um tipo de dado apenas.

        ////tipos:
        //int //ex 1,2,3, -1 pode ter negativo
        //    double // 0.5,4.7 esses são numeros com vírgulas digamos assim
        //    float // segue o mesmo jeito do double
        //    string // Caracteres dentro de " " podem conter até acentos como nos comentários
        //    bool // Esse verifica se é verdadeiro ou falso, true or false

        //    /* Armazenando na memória, vai ficar assim...estou armazenando
        //     */
        //    int numero = 0; // aqui eu armazeno na memoria que é do tipo inteiro e se chama
        //// numero e atribui um valor a ela, que vale 0 e pode ser qualquer valor inteiro.
        //double numero2 = 20.8d; // aqui armazenei um double, que aceita numeros fracionados.
        //// tipo 1,5/35,2. só que na programação, as vírgulas viram um ponto. e double termina com
        //// D no final.
        //float numero3 = 10.7f;// lembrando que em float, preciso adicionar o f no final do
        ////numero, para dizer que é um ponto flutuante.
        //string nome = "qualquer coisa"; // esse armazena texto entre aspas.
        //bool verdadeiro = true;

        //string msg = "esta";
        //Console.WriteLine($"sua mensagem é {msg}");
        ///* neste exemplo acima, o que eu fiz? Bem, eu criei na memória ram do pc, uma variável do tipo string
        // * "texto", armazenei o texto dentro da variável msg, e criei uma exibição na tela, que mostra o que está
        // * armazenado dentro da variável msg. E pode ser feito de outra forma, eu posso apenas deixar dentro dos
        // * parenteses, a variável msg, que irá mostrar o texto armazenado. */

        //int numero1 = 0;
        //int numero2 = 0;

        //Console.WriteLine("Digite o primeiro número: ");
        //numero1 = int.Parse(Console.ReadLine());

        //Console.WriteLine("Digite o segundo número: ");
        //numero2 = int.Parse(Console.ReadLine());
        //// Math.pow faz calculos de exponenciação e as variáveis precisam estar entre parenteses.
        //var resultado = numero1 + numero2;
        //Console.WriteLine($"A soma de {numero1} e {numero2} é {resultado}");

        //Console.ReadKey();
        ///* Outra observação no caso da precedencia em c#, eu queira somar dois numeros para
        // * depois dividir, preciso colocar eles entre parênteses primeiro.
        // Se nao fizer desta forma, o operador irá apenas dividir o numero 2 no caso, e depois somar com
        //o numero 1. Prestar atenção e estudar os precedentes matemáticos.*/

        //Operadores lógicos

        //int A = 2;
        //int B = 3;
        //int C = 5;
        //// Linha que verifica se é verdadeiro ou falso.
        //bool rese = !((A == B) && (C > A));
        //// No operador acima com "!", eu só preciso colocar uma exclamação e adicionar os parenteses, igual na linha acima
        //// Isso inverte o operador, se for verdadeiro, vira falso e vice versa.
        //bool res = (A == B) && (C > A);
        ////operador lógico acima " && ", que verifica se as duas informações são verdadeiras.
        //bool re = (A > B) || (C > A);
        ////operador lógico acima " || ", que verifica se uma das duas condições são verdadeiras, ou um ou outro.
        //Console.WriteLine(res);
        ////Aqui abaixo verifica se C é menor ou igual C resto da divisão por 2
        ////Console.Write(A <= C % 2);

        //Agora se quero conferir a potencia, devo utilizar o Math.Pow.
        //lembrar que preciso criar um objeto com "bool" para verificar se é verdadeiro ou falso.
        //int A = 2;
        //int B = 3;
        //int C = 5;
        //bool resultado = C <= Math.Pow(B, A);
        //Console.WriteLine(resultado);

        //Calculando o triangulo

        //double L1 = 0;
        //double L2 = 0;
        //double L3 = 0;

        //bool tri;
        //bool equilatero;
        //bool escaleno;
        //bool continuar = true;

        //while (continuar)
        //{
        //    Console.WriteLine("digite o primeiro lado: ");
        //    L1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Digite o segundo lado: ");
        //    L2 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Digite o terceiro lado: ");
        //    L3 = Convert.ToDouble(Console.ReadLine());
        //    tri = (L1 < L2 + L3) && (L2 < L1 + L3) && (L3 < L1 + L2);
        //    Console.WriteLine("Pode formar um triangulo?: " + tri);
        //    if (equilatero = L1 == L2 && L2 == L3)
        //    {
        //        Console.WriteLine(" O triangulo é Equilatero? " + equilatero);
        //    }
        //    else if (escaleno = L1 != L2 && L2 != L3 && L1 != L3)
        //    {
        //        Console.WriteLine("O triangulo é ecaleno? " + escaleno);
        //    }
        //    Console.WriteLine(" sair? (S/N) ");
        //    string resposta = Console.ReadLine().ToUpper();
        //    if (resposta != "N")
        //    {
        //        Console.WriteLine("Saindo...");
        //        Console.ReadKey();
        //        continuar = false;
        //    }
        //}

        //Console.WriteLine("Em que ano estamos? ");
        //int Data = int.Parse(Console.ReadLine());
        //Console.WriteLine("Qual data eu nasci? ");
        //int Nascimento = int.Parse(Console.ReadLine());
        //var resposta = (Data - Nascimento);
        //Console.WriteLine($"Eu tenho {resposta} anos");
        //Console.ReadKey();
        //if (resposta >= 21)
        //{
        //    Console.WriteLine(" Voce é maior de idade! ");
        //}
        //else
        //{
        //    Console.WriteLine(" voce é menor de idade!");
        //}

        ///* este código vai calcular e exibir a quantidade de dólar a ser comprado
        // */
        //Console.WriteLine("Quantos Reais eu tenho? ");
        //double Real = double.Parse(Console.ReadLine());
        //Console.WriteLine("Quanto tá custando o dolar? ");
        //double Dolar = double.Parse(Console.ReadLine());
        //double Resultado = Real / Dolar;
        //// Esta parteformatedResult tostring, instrui que a saída a ser
        //// exibida, irá ter apenas 3 casas decimais, importante para o código não
        //// ter um monte de números desnecessários.
        //string formatedResult = Resultado.ToString("0.00");
        //Console.WriteLine($"Posso ter U$$: {formatedResult}");
        //Console.ReadKey();

        ///*Converter celsius para Fahrenheit*/
        //float Fahrenheit = 0f;

        //Console.WriteLine("Qual é a temperatura aqui? ");
        //Fahrenheit = float.Parse(Console.ReadLine());
        //float resposta = (float)((Fahrenheit - 32) / 1.8);
        //string teste = resposta.ToString("0.00");
        //Console.WriteLine($"Está fazendo {teste} no Brasil");
        ///* Código MUITO INTERESSANTE DE CONVERSÃO DE CELSIUS PARA FARENHEIT.
        // * NÃO ESQUECER DE SEMPRE PROCURAR COMO OS CÁLCULOS PRÉ DEFINIDOS SÃO 
        // * ELABORADOS.*/

        ///* Conversão de imposto*/


        //double Imposto = 0d;
        //double Preco = 0d;
        //Console.WriteLine("Qual é o valor do produto? ");
        //Preco = Convert.ToDouble(Console.ReadLine());
        //Imposto = (Preco * 60) / 100;
        //string Calculo_Imposto = Imposto.ToString("000.00");
        //Console.WriteLine($"O imposto será de U$: {Calculo_Imposto} em Reais a serem pagos! ");

        ///* Calculando empréstimo */

        ///* Usuário irá pegar um empréstimo, e deverá pagar juros de 20%
        // * podendo parcelar.
        // * Os juros são acrescentados em 20% do valor desejado, e depois parcela
        // * em quantas vezes deseja pagar. */

        //double TaxaJuros = 20;
        //double Emprestimo = 0;
        //double Parcelas = 0;
        //double TaxaJurosDecimal = 0;

        ///* Foi criado, variáveis para a entrada de empréstimo e quantas parcelas
        // * irá pagar. */
        //Console.WriteLine("Quanto deseja pegar de empréstimo? ");
        //Emprestimo = double.Parse(Console.ReadLine());
        //Console.WriteLine(" Em quantas parcelas deseja pagar? ");
        //Parcelas = double.Parse(Console.ReadLine());
        ///* Foi usada outra variável para calcular a taxa de juros, dividida por 100
        // */
        //TaxaJurosDecimal = TaxaJuros / 100;
        ///* O valorParcela, está recebendo a multiplicação do empréstimo com
        // * taxa decimal em seguida, ele multiplica com a soma interna
        // * de 1 + taxajuros decimal, que é os juros, divididos por 100, e parcelas.
        // */
        //double ValorParcela = (Emprestimo * TaxaJurosDecimal * Math.Pow(1 + TaxaJurosDecimal, Parcelas)) / (Math.Pow(1 + TaxaJurosDecimal, Parcelas) - 1);
        //// Formatação "C2", formata como uma string monetária.
        //Console.WriteLine("Valor de cada parcela: " + ValorParcela.ToString("C2"));



        //double N1 = 0;
        //double N2 = 0;
        //int Contator = 0;
        //bool E = true;

        //while (true)
        //{
        //    Console.WriteLine(" Digite um número: ");
        //    N1 = double.Parse(Console.ReadLine());
        //    Console.WriteLine(" Digite mais um número: ");
        //    N2 = double.Parse(Console.ReadLine());

        //    double Resultado = (N1 + N2);
        //    string EB = Resultado.ToString();

        //    Console.WriteLine($"Tentativas: {Contator}");
        //    Console.WriteLine($" resuldado deu : {EB}");
        //    Console.WriteLine(" Sair? (S)/(N)");
        //    string Letra = Console.ReadLine();
        //    if (Contator <= 10)
        //    {
        //        Contator++;
        //    }
        //    E = false;
        //    if (Letra == "S")
        //    {
        //        Console.WriteLine(" Saindo...");
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine(" Retornando.");
        //    }
        //}

        //string Usuario = "Ana";
        //int Senha = 123;
        //int Contador = 0;
        //bool Verificar = false;
        ///* Aqui, consegui autenticar um looping, no qual se o usuário errar a senha mais de 3 vezes
        // * o programa é fechado com a mensagem de erro exibindo bloqueio de conta */
        //while (true)
        //{
        //    Console.WriteLine(" Digite um usuário: ");
        //    string User = Console.ReadLine();
        //    Console.WriteLine(" Digite sua senha: ");
        //    int Passwrd = int.Parse(Console.ReadLine());

        //    if (User == Usuario && Passwrd == Senha)
        //    {
        //        Console.WriteLine("Login efetuado com sucesso! ");
        //        break;
        //    }
        //    else if (User != Usuario || Passwrd != Senha)
        //    {
        //        Console.WriteLine(" Usuário ou senha incorretos. ");
        //        Contador++;

        //    }
        //    if (Contador >= 3 && !Verificar)
        //    {
        //        Console.WriteLine(" Numero de tentativas excedidas, conta bloqueada.");

        //        Verificar = true;
        //        break;

        //    }

        //    Console.WriteLine(" Tentar novamente? (s)/(n) ");
        //    string C = Console.ReadLine();
        //    if (C == "s")
        //    {
        //        Console.WriteLine("Retornando...");
        //    }
        //    else
        //    {
        //        Console.WriteLine(" Saindo...");
        //        Console.ReadKey();
        //        break;
        //    }
        //}



        //Console.WriteLine(" Quanto dinheiro eu tenho? ");
        //double B = double.Parse(Console.ReadLine());

        //if (B >= 10000)
        //{
        //    Console.WriteLine(" Partiu Disney! ");
        //}
        //if (B >= 5000 && B < 10000)
        //{
        //    Console.WriteLine(" Vou visitar minha cidade natal e ver a família. ");
        //}
        //else
        //{
        //    Console.WriteLine(" Sou pobre e ficarei em casa. ");
        //}

        ///* Verificando se o número é par ou ímpar */

        //int Numero = 0;

        //Console.WriteLine(" Digite um número: ");
        //Numero = int.Parse(Console.ReadLine());



        //if (Numero % 2 == 0)
        //{
        //    Console.WriteLine($"o numero {Numero} é par!");
        //}
        //else
        //{
        //    Console.WriteLine($"numero {Numero} é impar.");
        //}

        ///* Como é feito o calculo IMC ( índice de massa corpórea */


        //Console.WriteLine(" Massa (KG): ");
        //double MassaCorporea = double.Parse(Console.ReadLine());
        //Console.WriteLine(" Altura (M): ");
        //double Altura = double.Parse(Console.ReadLine());
        //double IMC = MassaCorporea / Math.Pow(Altura, 2);
        //string CC = IMC.ToString("00.00");
        //Console.WriteLine($" IMC: {CC}");
        //if (IMC < 17)
        //{
        //    Console.WriteLine(" Muito abaixo do peso. ");

        //}
        //else if (IMC >= 17 && IMC < 18.5)
        //{
        //    Console.WriteLine(" Abaixo do peso. ");

        //}
        //else if (IMC >= 18.5 && IMC < 25)
        //{
        //    Console.WriteLine(" Peso ideal. ");

        //}
        //else if (IMC >= 25 && IMC < 30)
        //{
        //    Console.WriteLine(" Sobrepeso. ");

        //}
        //else if (IMC >= 30 && IMC < 35)
        //{
        //    Console.WriteLine(" Obesidade ");

        //}
        //else if (IMC >= 35 && IMC < 40)
        //{
        //    Console.WriteLine(" Obesidade severa.");

        //}
        //else
        //{
        //    Console.WriteLine(" Paciente está em obesidade mórbida. ");

        //}

        ///* Exercícios para amanhã */
        //Apto a dirigir?
        // Programa que verifica se o usuário é maior de 18 anos para tirar a carteira de 
        // motorista.

        //DateTime Data=DateTime.Now;
        //DateOnly Nascimento = DateOnly.MaxValue;

        //Console.WriteLine(" Informe a data de nascimento: (dd/mm/yyyy) ");
        //Nascimento = DateOnly.Parse(Console.ReadLine());
        //double E = Data.Year - Nascimento.Year;

        //if (E > 18)
        //{
        //    Console.WriteLine($" Voce tem {E} anos, e pode tirar sua carteira de motorista! ");
        //}
        //else
        //{
        //    Console.WriteLine($" Voce tem {E} anos de idate, portanto nao pode tirar sua carteira de motorista! ");
        //}

        ///* Segundo exercicio */
        //Aluno aprovado ou reprovado.
        // calcular a média do aluno e dizer se ele está ou não reprovado.

        //string Nome = "";
        //double Nota1 = 0;
        //double Nota2 = 0;
        //double Media = 2;

        //Console.WriteLine(" Nome do aluno: ");
        //Nome = Console.ReadLine();
        //Console.WriteLine(" Nota do aluno: ");
        //Nota1 = double.Parse(Console.ReadLine());
        //Console.WriteLine(" Segunda nota do aluno: ");
        //Nota2 = double.Parse(Console.ReadLine());
        //double Calculo = (Nota1 + Nota2) / Media;

        //if (Calculo >= 7)
        //{
        //    Console.WriteLine($" O aluno {Nome} foi aprovado, pois tirou {Calculo} de média.");
        //}
        //else if (Calculo >= 5 && Calculo < 7)
        //{
        //    Console.WriteLine($" Aluno {Nome} Está em recuperação, pois sua média foi de {Calculo}  ");
        //}
        //else
        //{
        //    Console.WriteLine($" O aluno {Nome} foi reprovado, pois sua nota foi {Calculo}");
        //}

        ///* programa criança esperança guanabara */

        //Console.WriteLine("--------------------");
        //Console.WriteLine(" CRIANÇA ESPERANÇA  ");
        //Console.WriteLine("--------------------");
        //Console.WriteLine(" Obrigado por ajudar ");

        //int Escolha = 0;

        //Console.WriteLine(" [1] para doar R$ 10 ");

        //Console.WriteLine(" [2] para doar R$ 25 ");

        //Console.WriteLine(" [3] para doar R$ 50 ");

        //Console.WriteLine(" [4] para doar outros valores ");

        //Console.WriteLine(" [5] para cancelar ");
        //Escolha = int.Parse(Console.ReadLine());


        //switch (Escolha)
        //{
        //    case 1:
        //        Console.WriteLine(" Voce doou 10 Reais ");
        //        break;
        //    case 2:
        //        Console.WriteLine(" Voce doou 25 Reais ");
        //        break;
        //    case 3:
        //        Console.WriteLine(" Voce doou 50 Reais ");
        //        break;
        //    case 4:
        //        Console.WriteLine(" Qual valor da doação? ");
        //        Escolha = int.Parse(Console.ReadLine());
        //        Console.WriteLine($" Voce doou R$:{Escolha} Reais ");
        //        break;
        //    case 5:
        //        Console.WriteLine(" Cancelado! ");
        //        break;
        //}


        ///* Dependentes funcionário */
        //int Dependentes = 0;
        //double Salario = 0;
        //string Nome = "";
        //double NovoSalario = 0;

        //Console.WriteLine(" Qual é o nome do funcionário? ");
        //Nome = Console.ReadLine();
        //Console.WriteLine(" Qual é o salário do funcionário? ");
        //Salario = double.Parse(Console.ReadLine());
        //Console.WriteLine(" Qual é a quantidade de dependentes? ");
        //Dependentes = int.Parse(Console.ReadLine());

        ///* No caso do switch case, ele seleciona um ou outro bloco seguido de um break, se for aquele o selecionado,
        // * ele para o código ali sem continuar para outro.
        // * é como diz o código, ( caso ) seja esse numero selecionado, o código para. */



        //switch (Dependentes)
        //{
        //    case 0:
        //        NovoSalario = Salario + (Salario * 5 / 100);
        //        break;
        //    case 1:
        //    case 2:
        //    case 3:
        //        NovoSalario = Salario + (Salario * 10 / 100);
        //        break;
        //    case 4:
        //    case 5:
        //    case 6:
        //        NovoSalario = Salario + (Salario * 15 / 100);
        //        break;
        //    default:
        //        NovoSalario = Salario + (Salario * 18 / 100);
        //        break;

        //}
        //Console.WriteLine($" O novo salário do(a): {Nome}, será de RS: {NovoSalario}");

        ///* Exercicios para amanhã */

        ///* Aproveitamento do aluno: Considerar a média de um aluno, olhar na wikpedia sobre
        // * nota escolar de A até F
        // * Calcular a média de um aluno, e de acordo com a nota dele, mostrar se tirou A ou F */

        //string Nome = "";
        //double Nota1 = 0;
        //double Nota2 = 0;

        //Console.WriteLine(" Nome do aluno: ");
        //Nome = Console.ReadLine();
        //Console.WriteLine(" Nota do aluno: ");
        //Nota1 = double.Parse(Console.ReadLine());
        //Console.WriteLine(" Segunda nota do aluno: ");
        //Nota2 = double.Parse(Console.ReadLine());
        //double Calculo = (Nota1 + Nota2) / 2;

        //if (Calculo == 10 || Calculo >= 9)
        //{
        //    Console.WriteLine($" O aluno {Nome} tirou {Calculo} de média e teve apriveitamento A ");
        //}
        //else if (Calculo == 8 || Calculo >= 7)
        //{
        //    Console.WriteLine($" O aluno {Nome} tirou {Calculo} de média e teve aproveitamento B ");
        //}
        //else if (Calculo == 6 || Calculo >= 5)
        //{
        //    Console.WriteLine($" O aluno {Nome} tirou {Calculo} de média e teve aproveitamento C ");
        //}
        //else if (Calculo == 4 || Calculo >= 3)
        //{
        //    Console.WriteLine($" O aluno {Nome} tirou {Calculo} de média e teve aproveitamento D ");
        //}
        //else if (Calculo == 2 || Calculo >= 1)
        //{
        //    Console.WriteLine($" O aluno {Nome} tirou {Calculo} de média e teve aproveitamento E ");
        //}
        //else
        //{
        //    Console.WriteLine($" O aluno {Nome} tirou {Calculo} de média e teve aproveitamento F e foi REPROVADO. ");
        //}

        ///* Exercicio 2: partida de futebol
        // * analisar uma partida de futebol, de acordo com a quantidade de gols feito por cada
        // * time. Bamgu e madoreira
        // * calcular a diferença entre gols de cada time e definir se a partida foi normal,
        // * empate ou GOLEADA, caso o time tenha uma diferença grande de gols. */

        //string Time1 = "";
        //string Time2 = "";
        //int Diferenca = 0;
        //int Gols1 = 0;
        //int Gols2 = 0;


        //Console.WriteLine(" A partida acabou! ");
        //Console.WriteLine(" Nome do primeiro time: ");
        //Time1 = Console.ReadLine();
        //Console.WriteLine(" Nome do segundo time: ");
        //Time2 = Console.ReadLine();
        //Console.WriteLine(" Gols do time 1: ");
        //Gols1 = int.Parse(Console.ReadLine());
        //Console.WriteLine(" Gols do time 2: ");
        //Gols2 = int.Parse(Console.ReadLine());

        //Diferenca = Math.Abs(Gols1 - Gols2);

        ///* Lembrando que no caso do if e else if, o if verifica aquela linha de código e parte pro proximo
        // * o else if ele verifica aquela parte do código e se for verdadeiro, ele para ali mesmo sem continuar pro
        // * próximo */

        //if (Diferenca == 0)
        //{
        //    Console.WriteLine(" Resultado: Empate! ");
        //}
        //else if (Diferenca <= 3)
        //{
        //    Console.WriteLine(" Resultado Vitória normal! ");
        //}
        //else
        //{
        //    Console.WriteLine(" Resultado: Goleada! ");
        //}

        //if (Gols1 > Gols2)
        //{
        //    Console.WriteLine($"O time {Time1} fez mais gols ({Gols1}) do que o time {Time2} ({Gols2}) Gols.");
        //}
        //else if (Gols2 > Gols1)
        //{
        //    Console.WriteLine($"O time {Time2} fez mais gols ({Gols2}) do que o time {Time1} ({Gols1}) Gols.");
        //}
        //else
        //{
        //    Console.WriteLine($"Ambos os times fizeram o mesmo número de gols ({Gols1}) Gols.");
        //}

        //Console.WriteLine(" Digite [1],[2],[3] ");
        //int Entrada = int.Parse(Console.ReadLine());

        //if (Entrada == 1)
        //{
        //    Console.WriteLine("Esse código 1 rodou! ");

        //}
        //else if (Entrada == 2)
        //{
        //    Console.WriteLine("Esse código 2 rodou também ");
        //}
        //else
        //{
        //    Console.WriteLine(" Esse também rodou? ");
        //}

        //int Mao = 0;
        //while (Mao <= 5)
        //{
        //    Console.WriteLine($" temos o valor {Mao} de mao.");
        //    Mao++;
        //}

        ///* se dentro de writeline o "++" estiver antes do contador, ex: "++contador" ele irá contar de zero para
        // * 1, e irá contar no looping, e em seguida ele ira começar contar numeros impares, ex :1,3,5,7
        // * portanto, é importante pensar em por o contator antes, se quer contar numeros impares, 
        // * ou se quer por os ++ depois da palavra contador, para contar numeros pares de 2 em 2 nesse caso.*/


        //int Contador = 0;

        //while (Contador <= 20)
        //{
        //    Console.WriteLine($"valor de contador em cada looping {++Contador}");
        //    Contador++;
        //}

        ///* Cara, que louco, neste código abaixo, dá para pedir ao usuário digitar quanto quer contar
        // * foi criado uma variável chamada salto, e ela recebe a informação.
        // * logo após os prompts, no while, tem o enquanto contador for menor que a escolha
        // * ele vai exibir o numero de contagens, e a variavel contador que começa com zero, vai receber, a soma de 
        // * contador que é zero, mas o numero fornecido em saltos */

        //int Salto = 0;
        //int Contador = 0;

        //Console.WriteLine(" Quer que conte até quanto? ");
        //int Escolha = int.Parse(Console.ReadLine());
        //Console.WriteLine(" Qual será o valor do salto? ");
        //Salto = int.Parse(Console.ReadLine());

        //while (Contador <= Escolha)
        //{
        //    Console.WriteLine($" Voce contou ate {Contador}");
        //    Contador = Contador + Salto;

        //}
        ///* Então foi criado uma variável de nome "N", que vai receber o valor do usuário
        // * em seguida, foi atribuído a somador, a soma dele mesmo por estar em um looping, mais o valor da variável
        // * "N", que foi fornecida pelo o usuário.
        // * o looping vai repetir 10 vezes pois eu defini assim.
        // * o contador=contador+1, significa que a variável contadora, está dentro do console.writeline, sendo exibida
        // * o número de vezes em que ela se repete.
        // * logo abaixo em contador sendo atribuida a ela mesma +1, quer dizer que a cada looping, ela vai interagir consigo
        // * mesma e vai acrescentar mais 1 nela mesma.
        // * fora do looping while, criei uma int resuldado, que recebe os valores acumulados de somador e numero.
        // * que resulta em um resultado dessas somas exibindo o que tá contido dentro da variável Resultado.
        // * E assim é que funciona o looping while, enquanto uma condição nao for atendida, ele vai se repetir.
        // * no caso é a contagem até 10, e dentro disso, a expressão faz a soma desses números e no fim, exibe na tela.
        // * E dá pra por um if dentro de um looping, para verificar algo, no caso é verificar se o numero digitado
        // * "N" em alguma das vezes, é maior do que a variável Maior, e se for maior que a variável que tem o valor de 
        // * zero, a variável Maior, vai receber o valor de N, e isso vai mostrar o maior número.
        // */

        //int N = 0;
        //int Somador = 0;
        //int Contador = 1;
        //int Maior = int.MinValue; // Inicializa Maior com o menor valor possível
        //int Menor = int.MaxValue; // Inicializa Menor com o maior valor possível
        //Então colocando a variável como minvalue e maxvalue, faz com que essa lógica funcione, mas por que funciona?
        ///* Funciona por que foram criadas duas variáveis: int maior com int.minvalue, que percorre do menor numero inteiro
        // * possível ( do negativo ), e a outra variável int menor com int.maxvalue ( que percorre do maior positivo ), ao
        // * menor negativo. ( tipo de trás para frente ). */
        //while (Contador <= 5)
        //{
        //    Console.WriteLine("Digite o " + Contador + "º valor:");
        //N = int.Parse(Console.ReadLine());
        //Somador += N;

        //if (N > Maior)
        //{
        //    Maior = N;
        //}

        //if (N < Menor) // Compara com o menor número atual
        //{
        //    Menor = N;
        //}

        //Contador++;
        //}

        //Console.WriteLine($"Este é o valor da soma: {Somador}\nMaior número digitado: {Maior}\nMenor número digitado: {Menor}");


        ///* PRIMEIRO EXERCÍCIO PARA AMANHÃ 24/03/2024 */
        ///* "Contagem inteligente" */
        ///* Se o usuário digitar que quer contar de 1 a 6, o programa irá contar de 1 a 6
        // * Se o usuário digitar que quer contar de 10 até 0, ele detecta se é decrescente, e conta de 10 a 0. */

        //int inicio, fim;

        //Console.WriteLine("Digite o número inicial da contagem:");
        //inicio = int.Parse(Console.ReadLine());

        //Console.WriteLine("Digite o número final da contagem:");
        //fim = int.Parse(Console.ReadLine());

        //if (inicio < fim)
        //{
        //    Console.WriteLine($"Contagem crescente de {inicio} até {fim}:");
        //    for (int i = inicio; i <= fim; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //else if (inicio > fim)
        //{
        //    Console.WriteLine($"Contagem decrescente de {inicio} até {fim}:");
        //    for (int i = inicio; i >= fim; i--)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Os números são iguais, não há contagem a ser feita.");
        //}

        ///* EXERCÍCIO 2 */
        ///* Melhor aluno da turma */

        ///* O programa irá querer saber quantos alunos tem dentro de uma turma
        // * ele irá por exemplo dizer que tem 4 alunos
        // * o programa irá exibir aluno 1, perguntar o nome do aluno, e a nota do mesmo
        // * e depois o aluno 2, e o 3, e o quarto.
        // * Depois exibir na mensagem quem foi o aluno com a melhor nota, e mostrar a nota dele. */

        //int QuantidadeAlunos = 0;
        //string NomeMaiorNota = "";
        //double MaiorNota = double.MinValue;
        //int Contar = 0;
        //string NomeAtual = "";
        //double NotaAtual = 0;

        //Console.WriteLine(" Quantos alunos tem na turma? ");
        //QuantidadeAlunos = int.Parse(Console.ReadLine());

        //while (Contar < QuantidadeAlunos)
        //{
        //    Console.WriteLine($"Digite o nome do {++Contar}º Aluno:");
        //    NomeAtual = Console.ReadLine();

        //    Console.WriteLine($"Nota do {Contar} º Aluno: ");
        //    NotaAtual = double.Parse(Console.ReadLine());

        //    if (NotaAtual > MaiorNota)
        //    {
        //        MaiorNota = NotaAtual;
        //        NomeMaiorNota = NomeAtual;
        //    }
        //}
        //Console.WriteLine($"O aluno {NomeMaiorNota} teve a maior nota, com o aproveitamento de {MaiorNota}");

        //int QuantidadeCorredores = 0; // para perguntar quantos corredores irão correr.
        //int Contar = 0; // loop
        //double TempoFinal = double.MaxValue; // para comparar o tempo inicial com o tempo inicial.
        //double TempoInicial = 0; // Para comparar com o tempo final.
        //string NomeMenorTempo = "";
        //string NomeAtual = "";


        //Console.WriteLine(" Quantos corredores irão participar? ");
        //QuantidadeCorredores = int.Parse(Console.ReadLine());

        //for (Contar = 0; Contar < QuantidadeCorredores;)
        //{
        //    Console.WriteLine($" Nome do {++Contar} º Corredor: ");
        //    NomeAtual = Console.ReadLine();
        //    Console.WriteLine($" Tempo do {Contar} º Corredor: ");
        //    TempoInicial = double.Parse(Console.ReadLine());

        //    if (TempoInicial < TempoFinal)
        //    {
        //        TempoFinal = TempoInicial;
        //        NomeMenorTempo = NomeAtual;
        //    }
        //}
        //Console.WriteLine($" O corredor com o menor tempo foi {NomeMenorTempo}, com o tempo de {TempoFinal}");

        ///* Este caso, que preciso comparar valores.
        // lembre-se cláudio: Sempre que precisar comparar valores, seja nota, resultados, letras, números
        //o ideal é criar duas variáveis para fazer esta comparação.
        //notou que foi criado nomemaiornota, para receber o nome do estudante com a maior nota, e depois
        //a maiornota, começa com double.minvalue por que ela busca do menor, e armazena até a maior nota
        //o contar é óbvio para o looping, o nomeatual ele vai receber a entrada com o nome do aluno
        //e vai ser armazenada em nomemaiornota. 
        //depois a notaatual ela vai ser comparada com maiornota double.minvalue, e depois no looping while que o contador
        //precisa ser menor que a quantidade de alunos que quer cadastrar, isso garante que o looping funcione 3, 4 ou 5 vezes
        //pois quantidadedealunos é a entrada de quantos alunos tem na turma.
        //dois consoles sao exibidos pedindo os nomes, e notas dos alunos, no caso nomeatual e notaatual, logo abaixo foi criado apenas
        //uma condição "if" que diz que se notaatual for maior que maiornota que tem double.minvalue, maiornota vai ser substituida por 
        //notaatual e nomemaiornota, vai receber nomeatual.

        // isso funciona bem, pois é uma comparação de resultados, em que existe uma partida e um fim, no caso notaatual e maiornota
        //posso por como exemplo, uma corrida, em que corredores competem, os nomes deles sao cadastrados, e o tal corredor, chegou
        //em menor tempo. tem que ter um tempoinicial, e tempochegada para comparar, pois se tempoinicial for menor que tempochegada, 
        //tal jogador é o mais rapido.*/
        //string Nome = "";
        //int Tentativas = 0;
        //string User = "Admin";
        //int Pass = 123;

        ///* Neste caso o, declarei as variáveis, logo em seguida um loop for é iniciado, que para cada
        // * iteração na variável Tentativas, e se a tentativas for menor que 3 ele repete o loop
        // * ele é parecido com o while, a diferença é que o while é quando eu sei a quantidade de loops que quero efetuar.
        // * Como por exemplo no loop for, ele percorre um numero fixo de iterações, como um array :
        // * Loop For: O loop for é geralmente usado quando você sabe o número de iterações de antemão. Por exemplo, para percorrer
        // * um array de 10 elementos, você pode usar o loop for e incrementar o contador de 0 a 9 (ou 1 a 10). Aqui está um exemplo
        // * em C#:
        // * for (int i = 0; i < 10; i++)
        //    {
        //         Console.WriteLine(i);
        //    }

        // * Loop While: Por outro lado, o loop while é usado quando você tem uma ideia sobre a faixa de valores em que para fazer uma 
        // * iteração, mas não sabe o número exato de iterações que ocorrerão. Por exemplo:
        // * int i = 0;
        //    while (i < 10)
        //    {
        //        Console.WriteLine(i);
        //        i++;
        //    }
        // * 
        // */

        //Console.WriteLine(" Digite seu nome: ");
        //Nome = Console.ReadLine();

        //for (Tentativas = 0; Tentativas < 3;)
        //{
        //    Console.WriteLine(" Digite seu nome de usuário: ");
        //    string Usuario = Console.ReadLine();
        //    Console.WriteLine(" Digite sua senha: ");
        //    int Senha = int.Parse(Console.ReadLine());

        //    if (Senha == Pass && Usuario == User)
        //    {
        //        Console.WriteLine($" Login efetuado com sucesso! Bem vindo {Nome}. ");
        //        break;
        //    }
        //    else
        //    {

        //        Console.WriteLine($" Usuário ou senha incorretos, Tentativas restantes  {++Tentativas} ");

        //    }
        //}
        //if (Tentativas == 3)
        //{
        //    Console.WriteLine(" Numero maximo de tentativas alcançado, tente novamente mais tarde. ");
        //}

        //int Soma = 0;
        //int Numero = 0;
        //int Contar = 0;

        ///* A estrutura while, ela efetua o loop, até que a condição seja verdadeira, ou seja;
        // * até que contar atinja 5
        // */

        //while (Contar < 5)
        //{
        //    Console.WriteLine($" Digite o {++Contar}º numero");
        //    Numero = int.Parse(Console.ReadLine());
        //    Soma = Soma + Numero;
        //}
        //Console.WriteLine($"A soma dos números é igual a {Soma}");

        ///*Mas a estrutura do while, é um pouco inversa, pois enquanto uma condição nao for verdadeira,
        // * o laço de repetição irá repetir até chegar lá.
        // * mas o do while, ele é como se fosse um faça enquanto, repita até no visualg.
        // * ele vai rodar o loop até que a condição seja verdadeira.
        // */

        //TABUADA PERSONALIZADA //

        //int N = 0;
        //int Contador = 1;
        //int R = 0;

        ///* Cara que MÁXIMO, então eu preciso lembrar das variáveis necessárias, e nesse caso, foram
        // * apenas 3. Uma par contar o loop, outra para receber input, e a outra para armazenar um 
        // * resultado. */

        //Console.WriteLine(" Quer ver a tabuada de qual número? ");
        //N = int.Parse(Console.ReadLine());
        ///* O console pede o input, o usuário digita, e o loop faça enquanto, ele vai verificar
        // * a condição só no fim do loop, no while ele verifica no começo.
        // * Foi inserida uma variável R de resposta, para armazenar a multiplicação do input N com
        // * a variável Contadora, e nisso, o console exibe o resultado , junto da linha de baixo
        // * que o Contador itera consigo mesmo, armazenando valor de contagem para cada loop.
        // * programação É INCRÍVEL */
        //do
        //{
        //    R = N * Contador;
        //    Console.WriteLine($" {N} X {Contador} = {R} ");
        //    Contador = Contador += 1;
        //}
        //while
        //(Contador <= 10);


        //string Usuario = "usuario";
        //int Minimo = 8;
        //int Pass;
        //int Contar = 1;

        //do
        //{
        //    Console.WriteLine(" Digite seu usuário: ");
        //    Usuario = Console.ReadLine();

        //    Console.WriteLine(" Digite sua senha: ");
        //    Pass = int.Parse(Console.ReadLine());
        //    /* .Lenght só pode ser utulizado em strings, portando, é recomendável usar o método
        //     * ToString para converter o int ou double ou float em strings e ler como caractere.
        //     * o .Lenght é o numero de caracteres , nesse caso comparado a mínimo. */

        //    if (Pass.ToString().Length >= Minimo)
        //    {
        //        Console.WriteLine(" Login efeituado com sucesso");
        //        break;
        //        // o Break é para cessar o loop caso o usuário acerte login e senha.
        //    }
        //    else
        //    {
        //        Console.WriteLine(" A senha deve conter No minimo 8 caracteres ");
        //        Contar++;
        //    }
        //}
        //while
        //(Contar <= 3);
        //if (Contar >= 3)
        //{
        //    Console.WriteLine(" Numero maximo de tentativas atingidas, tente novamente mais tarde.");
        //}

        //Int64 pode ser simplificado mudando para long, que tem o mesmo modo. 64 bits


        //int QuantidadeProduto = 0;
        //double PrecoUnitario = 0;
        //double ValorTotal = 0;
        //int Loop = 1;
        //string Decisao = "S";

        //do
        //{
        //    Console.WriteLine(" Bem vindo as compras! ");
        //    Console.ReadKey();
        //    Console.Clear();
        //    Console.WriteLine(" Onde temos os melhores preços. ");
        //    Console.ReadKey();
        //    Console.Clear();
        //    Console.WriteLine(" Quantos itens gostaria de comprar? ");
        //    QuantidadeProduto = Convert.ToInt32(Console.ReadLine());

        //    if (QuantidadeProduto >= 4)
        //    {
        //        Console.WriteLine(" Só é permitido 3 compras por vez.");
        //        continue;
        //    }

        //    ValorTotal = 0;
        //    Loop = 1;

        //    do
        //    {
        //        Console.WriteLine($" Valor do {Loop} ° produto R$: ");
        //        PrecoUnitario = double.Parse(Console.ReadLine());
        //        ValorTotal += PrecoUnitario;
        //        Loop++;
        //    }
        //    while (Loop <= QuantidadeProduto);

        //    Console.WriteLine($" Voce comprou {QuantidadeProduto} de itens, valor total R$: {ValorTotal} ");

        //    Console.WriteLine(" Gostaria de continuar comprando? (S/N) ");
        //    Decisao = Console.ReadLine();
        //}
        //while (Decisao.ToUpper() == "S");
        //Console.WriteLine(" Obrigado por comprar conosco! ");

        // Mostrando números negativos//

        //int Numero; int Contador = 1; int TotalNegativo =0;

        //do
        //{
        //    Console.WriteLine($"Digite o {Contador} 0 numero: ");
        //    Numero = Convert.ToInt32(Console.ReadLine());

        //    if (Numero < 0)
        //    {
        //        TotalNegativo = TotalNegativo + 1;

        //    }
        //    Contador += 1;
        //}
        //while ( Contador <= 5);
        //Console.WriteLine($"Foram digitados {TotalNegativo} valores negativos!" );

        // Verificar se um número é ou não primo//
        /* numero primo é o que divide até ele, somente por 2 numeros */

        //int N;
        //int Cont = 1;
        //int ContDiv = 0;

        //Console.WriteLine(" Digite um número: ");
        //N = int.Parse(Console.ReadLine());

        //do
        //{
        //    // operador % calcula o resto de uma divisão
        //    Console.WriteLine(Cont);
        //    if (N % Cont == 0)
        //    {
        //        ContDiv ++ ;          
        //    }
        //    Cont++;
        //}
        //while (Cont <= N);
        //if (ContDiv == 2)
        //{
        //    Console.WriteLine($" O número {N} é primo. ");
        //}
        //else
        //{
        //    Console.WriteLine($" O número {N} não é primo. ");
        //}

        /* Exercicios para depois */
        // Criar um super contador: com um menu 1, se for selecionado, ele conta
        // até 10, se for o numero 2, ele conta de 10 até 1, de trás p frente e 3 sai do menu.

        //int N1;
        //Console.WriteLine(" Contar na ordem:\n\n [1]-Crescente\n [2]-Decrescente\n [3]-Sair\n ");
        //N1 = Convert.ToInt32(Console.ReadLine());
        //// Então posso por um loop for dentro dos ifs.. bom saber.
        //if (N1 == 1 )
        //{
        //    for (int i = 0; i < 10;)
        //    {
        //        Console.WriteLine(++i);
        //    }
        //}
        //else if (N1 == 2)
        //{
        //    for (int a = 10; a > 0;)
        //    {
        //        Console.WriteLine(a--);
        //    }
        //}
        //else 
        //{ 
        //    Console.WriteLine(" Saindo...");
        //}

        //string Nome = "Claudio";
        //int Pass = 123;

        //for (int i = 1; i <= 3; i++)
        //{
        //    Console.WriteLine(" Digite seu Nome: ");
        //    string Name = Console.ReadLine();
        //    Console.WriteLine(" Digite sua Senha: ");
        //    int Senha = Convert.ToInt32(Console.ReadLine());

        //    if (Senha == Pass && Name == Nome)
        //    {
        //        Console.WriteLine($"Bem-vindo(a) {Nome} .");
        //        return;
        //    }
        //    else 
        //    {
        //        Console.WriteLine(" Usuário ou senha inválidos, tente novamente.");

        //    }
        //    Console.Clear();
        //}
        //Console.WriteLine(" Numero máximo de tentativas atingido.\n Por favor, redefina sua senha.");

        /* O conceito de return, significa que voce cria uma função, passa os parâmetros ( entre
         * parenteses ) ex: (int A, int B ), executa alguma ação dentro do bloco do código com 
         * essas variáveis dentro do parametro, as variaveis executam uma soma, ou multiplicação
         * e no momento que eu precisar dela em um código, vou poder usar pois ela retorna essa 
         * operação, para fora do bloco.
         * tipo somar, dividir, verificar.
         * o return deixa que eu pegue essa função, e utilize essa ação dentro do código com A e B.
        */

        // Fatorial de numeros.

        //int Contar;
        //int Numero;
        //int Fatorial = 1;

        //Console.WriteLine(" Digite um número: ");
        //Numero = Convert.ToInt32(Console.ReadLine());
        //Contar = Numero;
        //Fatorial = 1;
        //do
        //{
        //    Fatorial = Fatorial * Contar;
        //    Contar = Contar - 1;
        //} while (Contar > 1);
        //Console.WriteLine($" O valor do fatorial de {Numero} é igual a {Fatorial} ");

        /* Exercicio 2, escolhendo pessoas */
        //int ContarHomem = 0;
        //int ContarMulher = 0;
        //string Continuar = "S";
        //int Contar = 0;
        //string Sex;
        //int Idade;
        //int Cabelo;

        //while (Continuar == "S")
        //{
        //    Console.WriteLine(" Qual o sexo: [M/F] ");
        //    Sex = Console.ReadLine().ToUpper();
        //    Console.WriteLine(" Qual a idade? ");
        //    Idade = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(" Qual a cor do cabelo? ");
        //    Console.WriteLine(" [1] Preto ");
        //    Console.WriteLine(" [2] Castanho ");
        //    Console.WriteLine(" [3] Loiro ");
        //    Console.WriteLine(" [4] Ruivo ");
        //    Cabelo = Convert.ToInt32(Console.ReadLine());

        //    switch (Cabelo)
        //    {
        //        case 1:
        //            Console.WriteLine(" Preto ");
        //            break;
        //        case 2:
        //            Console.WriteLine(" Castanho ");
        //            break;
        //        case 3:
        //            Console.WriteLine(" Loiro ");
        //            break;
        //        case 4:
        //            Console.WriteLine(" Ruivo ");
        //            break;
        //        default:
        //            Console.WriteLine(" Alternativa inválida.");
        //            break;
        //    }
        //    /* no caso do if e else if, lembre-se.....o if verifica um primeiro parametro, que foi o homem
        //     * depois um else if para verificar o outro que é a mulher.
        //     * não é necessário criar vários else ifs, pois as duas condições verdadeiras já foram estabelecidas.
        //     * o else trata qualquer coisa que nao for acima.
        //     * por ex: o usuario é homem e tem 18 anos e o cabelo é preto? o if verifica.
        //     * o usuário nao tem isso? ele pula pro else, e nao preciso especificar o por que, apenas sei que 
        //     * um dos dois nao atende aos requisitos.
        //     * no caso da mulher, vai um else if, pois ele vai verificar se a mulher é ou nao loira, e se tem
        //     * entre 25 e 30 anos.
        //     * é bom entender a diferença do "e" e "ou", pois o o "e", precisa que todas as informações sejam
        //     * verdadeiras, o "ou", qualquer um que for verdadeiro, ele aceita o código e valida. */
        //    if (Sex == "M" && Idade > 18 && Cabelo == 2)
        //    {
        //        Console.WriteLine(" O codigo rodou o primeiro if e aceitou o homem");
        //        ContarHomem++;
        //    }
        //    else if (Sex == "F" && Idade >= 25 && Idade <= 30 && Cabelo == 3)
        //    {
        //        Console.WriteLine(" O codigo rodou o primeiro else if e aceitou a mulher");
        //        ContarMulher++;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nao prenche os requisitos");
        //    }
        //    Contar++;
        //    Console.WriteLine(" Quer continuar? [S/N] ");
        //    Continuar = Console.ReadLine().ToUpper();
        //}
        //Console.WriteLine($" Total de homens com 18 e cabelos castanhos: {ContarHomem} !");
        //Console.WriteLine($" Total de mulheres entre 25 e 30 anos com cabelos loiros : {ContarMulher} !");

        //int C = 0;
        //int V = 0;
        //int Tot010 = 0;
        //int SImp = 0;

        //for (C = 1; C <= 6; C++)
        //{
        //    Console.WriteLine(" Digite um valor: ");
        //    V = int.Parse(Console.ReadLine());

        //    // Adicionar o || V > 10 caso eu queira fazer contar os numeros acima de 10.
        //    if (V >= 0 && V <= 10)
        //    {
        //        Tot010 += 1;
        //        if (V % 2 == 1)
        //        {
        //            SImp = SImp + V;
        //        }
        //    }
        //}
        //Console.WriteLine($" Ao toto foram {Tot010} valores entre 0 e 10. ");
        //Console.WriteLine($" Nesse intervalo, a soma de ímpares foi {SImp} ");

        //int Input;
        //int Count = 1;
        ///* Então ao exibir um resultado, posso fazer igual abaixo em writeline, colocar a soma ou multiplicação
        // * com o resultado . */
        //Console.WriteLine(" Digite o número da tabuada de soma: ");
        //Input = int.Parse(Console.ReadLine());

        //while (Count <= 10)
        //{
        //    Console.WriteLine($"{Input}+{Count}={Input + Count}");

        //    Count += 1;
        //}

        /* Então a estrutura do..while ela nao serve quando nao se sabe o valor que quer atingir.
         * o recomendável seria um while no lugar pois nele sabemos o valor.
         * loop while: sabemos quantas vezes o loop vai repetir.
         * do... while: não sabemos quantas vezes o loop irá repetir.
         * Basicamente o while ele repete enquanto a condição for verdadeira ( while true ) 
         * mas se a condição for falsa, o bloco nao vai ser executado.
         * Enquanto o do...while ele é útil quando preciso que o bloco seja executado ao menos uma vez, independente
         * da condição de parada. Se for verdadeiro, ele continua a executar, mas se for falso, o loop é encerrado. */
        // Aninhamento de estruturas de repetição

        //int C1 = 0;
        //int C2 = 0;


        //for ( C1 = 1; C1 <= 3; C1++ )
        //{
        //    /* Esse aninhamento de estruturas de repetição funciona da seguinte forma:
        //     * O primeiro for começa contando como 1, e ele passa para o próximo for que é o interno.
        //     * como o loop for interno começa com 1 mas precisa terminar, ele vai contar até 3
        //     * e só assim vai para o loop externo, conta mais 1, e o próximo conta 2 e assim por diante.*/

        //    for ( C2 = 1;C2 <= 3; C2++ )   
        //    Console.WriteLine($"{C1},{C2}");
        //}

        // Fórmula for para tabuada, que coisa linda kkkk 

        //int Num = 0;

        //Console.WriteLine(" Quer ver a tabuada de multiplicação do 1 até qual número? ");
        //Num = Convert.ToInt32(Console.ReadLine());
        ///* Então basicamente o loop for dentro do loop for, ele espera o loop interno terminar
        // * para assim iterar mais um externamente, e ele sempre executa tudo internamente primeiro. */

        //for (int i = 1; i <= Num; i++) 
        //{
        //    Console.WriteLine($"Tabuada de {i}");
        //    for (int j = 1; j <= 10; j++)
        //    {

        //        Console.WriteLine($"\n{i}x{j}={i*j}.");
        //    }
        //}

        // Exercicio 1: Sequencia de Fibonacci
        /* Criar um algorítmo que soma dois números, o terceiro número é a soma do primeiro com o segundo, o 
         * terceiro número é a soma é a soma do primeiro com o segundo e por aí vai.
         Lembrar que vou ter que contar até 15 nesse exercício. */

        //int Num = 1;
        //int Num2 = 0;
        //int Resp = 0;

        //for (int k = 1; k < 15; k++)
        //{
        //    Resp = Num2 + Num;
        //    // Resp ele começa somando...
        //    Num2 = Num;
        //    // E por último o num...
        //    Num = Resp;
        //    // por segundo o num....
        //    Console.WriteLine(Num2);
        //}
        /* Então na lógica acima,neste caso, o Resp ele começa somando as variáveis num2 e num.
         * Em seguida, ele armazena em num2 o valor de 1 pois num2 pega o que foi armazenado em resp que é 0+1*/
        // Exercício 2: Analisador de valores
        /* Vou digitar 5 valores, e no final vou exibir a soma dos valores, média entre os valores,
         * quantos são divisoes por 5, quantos são nulos e a soma dos pares.
         * tirar a média entre os valores significa somar todos e dividir pelos numeros somados, ex 5 numeros.*/
        //int Input = 0;
        //int Cont = 1;
        //double SomaTotal = 0;
        //double Media = 0;
        //int Nulos = 0;
        //int Pares = 0;
        //int Divporcinco = 0;

        //while (Cont <= 5)
        //{
        //    Console.WriteLine($"Digite o {Cont}º numero: ");
        //    Input = Convert.ToInt32(Console.ReadLine());
        //    SomaTotal = SomaTotal + Input;
        //    if (Input % 2 == 0 && Input != 0)
        //    {
        //        Divporcinco++;
        //    }
        //    else if (Input == 0)
        //    {
        //        Nulos++;
        //    }
        //    if ( Input % 2 == 0)
        //    {
        //        Pares += Input;
        //    }   
        //    Cont++;
        //}
        //Media = (double)SomaTotal / 5;
        //Console.WriteLine($" Soma total : {SomaTotal}");
        //Console.WriteLine($" Média:{Media}");
        //Console.WriteLine($" Soma dos numeros pares {Pares}");
        //Console.WriteLine($" Total de números nulos {Nulos}");

        /* Basicamente então, a forma de pensar aqui é que eu criei corretamente as
         * variáveis para interação no código.
         * neste caso, foi importante lembrar de alguns pontos:
         * 1º- Quando se diz %2, quer dizer que: Se o resultado dos números dividido por
         * 2 for igual a zero, então os números darão como PAR e nisso, a varável contaria
         * 2º- No caso de ser divisível por cinco, o raciocinio no código é:
         * o mesmo para verificar se é par, e a condição && que diz que o input tem q 
         * ser diferente de zero.
         * 3º- O input for igual a zero, então entra o número nulo.
         * 4º- E por fim, se o número for divisivel por 2 e o resultado for zero, o número
         * se torna par e as variáveis contam em cada condição correspondente.
         * 5º Calcular a média foi feita após as condições e fora do loop, pois se for 
         * pensar que calcular a média, consite em somar os números e depois dividir todos 
         * pela quantidade de números somados, ex: somei 3+3+3+3, a média é dividir essa 
         * soma, por 4, pois somei 4 algarismos. */

        // Procedimentos e funções, acontece rotineiramente, constantemente.

        //int i = 0;
        //string n = "";
        //string Pesado = "";
        //double P = 0;
        //double Mai = 0;
        //Console.Clear();
        //Console.WriteLine(" Detector de pesado! ");
        //Console.WriteLine($" Maior peso até agora :{Mai} Kg:");

        //for (i = 1; i < 5; i++)
        //{
        //    Console.WriteLine(" Digite o nome: ");
        //    n = Console.ReadLine();
        //    Console.WriteLine($" Digite o peso de {n}: ");
        //    P=Convert.ToDouble(Console.ReadLine());
        //    if ( P > Mai ) 
        //    {
        //        Mai = P;
        //        Pesado = n;
        //    }
        //    Console.Clear();

        //}
        //Console.WriteLine($" Maior peso até agora {Mai} Kg");
        //Console.WriteLine($" A pessoa mais pesada foi {Pesado}, com {Mai} quilos");

        // Aprendendo sobre procedimentos ( métodos )

        //int a = 0;     
        //int Cont = 0;
        //do
        //{
        //    Console.WriteLine(" Digite um numero: ");
        //    int Numeros = Convert.ToInt32(Console.ReadLine());
        //    a = Somar(a, Numeros);
        //    Cont++;
        //} while (Cont < 3);
        //Console.WriteLine(" O resultado dos dois números foi " + a);

        //int E = 1;
        //int Caunt = 0;

        //do
        //{
        //    Console.WriteLine(" Digite um numero: ");
        //    int Multi=Convert.ToInt32(Console.ReadLine());
        //    E = Multiplicar(E, Multi);
        //    Caunt++;
        //} while (Caunt < 2);
        //Console.WriteLine($" O resultado da multiplicação é: {E}");

        /* Então o conceito de procedimento ou métodos ou funções, consiste na idéia de que eu posso criar 
         * uma classe com uma função fora do main e reutilizar ela em outras partes do código. Como aqui
         * eu criei uma função que efetua uma soma de duas variáveis, e no outro uma multiplicação.
         * lembrando que preciso passar as variáveis como parâmetro para serem usadas.
         * Observação: Se eu passar 4 parâmetros, eu vou ter que usar os 4 parâmetros referente ao método que
         * criei. */
        
    }
    //public static int Somar(int A, int B)
    //{
    //    return A + B;
    //}
    //public static int Multiplicar(int D, int C)
    //{
    //    return D * C;
    //}
}
