/* Teste de estágio - Target Sistemas
    Jaqueline Rossetto Scagliante
    github: https://github.com/jaquerossetto/target-sistemas
    Resolução das questões feitas em C# 

 
//---------------------------------------------------------------------------------------------------------------------
1) Observe o trecho de código abaixo:
int INDICE = 13, SOMA = 0, K = 0;
    enquanto K < INDICE faça
    {
        K = K + 1;
        SOMA = SOMA + K;
    }
    imprimir(SOMA);

Ao final do processamento, qual será o valor da variável SOMA? 
*/

//Resolução:
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Questão 1:");

int indice = 13;
int soma = 0;
int k = 0;

while (k < indice)
{
    k = k + 1;
    soma = soma + k;
}

Console.WriteLine("Variável 'soma' tem o valor " + soma);


//---------------------------------------------------------------------------------------------------------------------
/*
2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, 
ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código; 
*/

//Resolução:
Console.WriteLine(Environment.NewLine + "Questão 2:");
int numAnterior = 0;
int numAtual = 1;
int fibonacci;
int test;

//captura o número a ser testado
Console.WriteLine("Informe um número para saber se ele pertence à sequência de Fibonacci: ");
int numTeste = int.Parse(Console.ReadLine());


//loop percorre a sequencia de fibonacci comparando os numeros ao que foi informado
for (int i = 0; i < 100; i++)
{
    fibonacci = numAnterior + numAtual;
    //Console.WriteLine(fibonacci);     *essa linha é só para printar todos os numeros da sequencia fibonacci caso precise
    numAnterior = numAtual;
    numAtual = fibonacci;

    if (numTeste == fibonacci)
    {
      Console.WriteLine("O número " + numTeste + " pertence à sequência de Fibonacci!");
    }
}


//---------------------------------------------------------------------------------------------------------------------
/*
3) Descubra a lógica e complete o próximo elemento:

a) 1, 3, 5, 7, ___
b) 2, 4, 8, 16, 32, 64, ____
c) 0, 1, 4, 9, 16, 25, 36, ____
d) 4, 16, 36, 64, ____
e) 1, 1, 2, 3, 5, 8, ____
f) 2,10, 12, 16, 17, 18, 19, ____
*/

//Resolução:
Console.WriteLine(Environment.NewLine + "Questão 3:");
Console.WriteLine("a) 9   | Lógica: Sequência de números ímpares");
Console.WriteLine("b) 128 | Lógica: Os números estão sendo multiplicados por 2");
Console.WriteLine("c) 49  | Lógica: São os números naturais elevados ao quadrado. Ou seja: 1²=1  2²=4  3²=9 e assim sucessivamente");
Console.WriteLine("d) 100 | Lógica: São os números naturais pares elevados ao quadrado. Ou seja: 2²=4 4²=16 e assim sucessivamente");
Console.WriteLine("e) 13  | Lógica: O próximo número é o resultado da soma dos dois últimos");
Console.WriteLine("f) 200 | Lógica: Todos os números se iniciam com a letra 'd'");


//---------------------------------------------------------------------------------------------------------------------
/*
4 - Dois veículos (um carro e um caminhão) saem respectivamente de cidades opostas pela mesma rodovia. O carro de Ribeirão Preto 
em direção a Franca, a uma velocidade constante de 110 km/h e o caminhão de Franca em direção a Ribeirão Preto a uma 
velocidade constante de 80 km/h. Quando eles se cruzarem na rodovia, qual estará mais próximo a cidade de Ribeirão Preto?

IMPORTANTE:
a) Considerar a distância de 100km entre a cidade de Ribeirão Preto <-> Franca.
b) Considerar 2 pedágios como obstáculo e que o caminhão leva 5 minutos a mais para passar em cada um deles e o carro 
possui tag de pedágio (Sem Parar)
c) Explique como chegou no resultado.
*/

//Resolução:
Console.WriteLine(Environment.NewLine + "Questão 4:");
Console.WriteLine("Ambos estarão à mesma distância de 60,9km de Ribeirão Preto." + Environment.NewLine +
    "Explicação: É necessário conhecimento prévio sobre movimento retilíneo uniforme." + Environment.NewLine +
    "Começamos definindo um ponto de referência (Ribeirão Preto), faz-se a equação horária do carro (x1 = v1*t). " + Environment.NewLine +
    "Em seguida usamos a mesma fórmula para fazer a equação horária do caminhão, porém como ele inicia a 100km distante do ponto de referência, " +
    "sua equação será (x2 = 100km-v2*t)." + Environment.NewLine +
    "**Vale ressaltar que estamos usando 'x1' e 'v1' para o carro e 'x2' e 'v2' para o caminhão**" + Environment.NewLine +
    "Feito isso vamos calcular o tempo de viagem do caminhão -sem os obstáculos e depois descontamos os pedágios- (tso = 100km/80km|h), que resulta em 1,25h." + Environment.NewLine +
    "Como o caminhão passa por 2 pedágios perdendo 5 minutos em cada um, soma-se isso ao resultado obtido (é necessário converter de minutos para hora, para ter todos os valores na mesma unidade de medida)." + Environment.NewLine +
    "Então o tempo total do caminhão é de (1,25+0,17 = 1,42h)." + Environment.NewLine +
    "Agora vamos calcular a velocidade média (v2 = 100km/1,42h) que resulta em 70,6 km|h. Com as equações horárias conseguimos limpar " +
    "o tempo e igualar ambas para achar o ponto em que se cruzaram. Em sequência as formulas são: " + Environment.NewLine +
    "(t=x1/v1) -> (t=x2-100km/-v2) -> (x1=x2 => x/v1 = x-100km/-v2) -> (-v2*x = v1*x - v1*100km) -> (x=v1*100km/v1+v2 = 110km|h*100km / 110km|h+70,6km|h)" + Environment.NewLine +
    "E isso nos dá o resultado de x= 60,9km");


//---------------------------------------------------------------------------------------------------------------------
/*
5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;
*/

//Resolução:
Console.WriteLine(Environment.NewLine + "Questão 5:");
Console.WriteLine("Escreva uma string para ser invertida:");
string strOriginal = Console.ReadLine();
string strInvertida = "";  //a string é criada vazia para receber os caracteres invertidos do array

//neste loop o incremento é "invertido", pois percorre o array da string digitada do último para o primeiro elemento e os coloca no array novo
for (int i = strOriginal.Length - 1; i >= 0; i--)
{
    strInvertida += strOriginal[i];
}

Console.WriteLine("Nova string: " + strInvertida);