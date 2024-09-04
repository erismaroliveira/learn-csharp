# Sintaxe em C#

A sintaxe de C# é projetada para ser clara e fácil de entender, especialmente para desenvolvedores que já estão familiarizados com outras linguagens baseadas em C, como C++ ou Java. Abaixo está um resumo da sintaxe básica de C#, incluindo como declarar variáveis, escrever estruturas de controle, definir métodos e trabalhar com classes.

## 1. Estrutura Básica de um Programa em C#

Todo programa em C# começa com uma classe contendo um método `Main`, que é o ponto de entrada do aplicativo.

```csharp
using System;

namespace MeuPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo!");
        }
    }
}
```

## 2. Declaração de Variáveis

Variáveis em C# devem ser declaradas com um tipo específico. A declaração inclui o tipo de dado seguido pelo nome da variável.

```csharp
int numero = 10;
string mensagem = "Olá, C#!";
bool isCsharpFun = true;
```

## 3. Estruturas de Controle

### Condicionais

#### `if`, `else if`, `else`

```csharp
int idade = 20;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}
```

#### `switch`

```csharp
char opcao = 'A';

switch (opcao)
{
    case 'A':
        Console.WriteLine("Você escolheu a opção A.");
        break;
    case 'B':
        Console.WriteLine("Você escolheu a opção B.");
        break;
    default:
        Console.WriteLine("Opção desconhecida.");
        break;
}
```

### Laços de Repetição

#### `for`

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

#### `while`

```csharp
int contador = 0;

while (contador < 5)
{
    Console.WriteLine(contador);
    contador++;
}
```

#### `do-while`

```csharp
int contador = 0;

do
{
    Console.WriteLine(contador);
    contador++;
} while (contador < 5);
```

#### `foreach`

```csharp
string[] frutas = { "Maçã", "Banana", "Laranja" };

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}
```

## 4. Definição de Métodos

Métodos são blocos de código que executam tarefas específicas e podem ou não retornar um valor.

```csharp
// Método sem retorno
void ExibirMensagem()
{
    Console.WriteLine("Esta é uma mensagem.");
}

// Método com retorno
int Somar(int a, int b)
{
    return a + b;
}
```

## 5. Classes e Objetos

Em C#, tudo é um objeto. Classes definem o comportamento e as propriedades dos objetos.

```csharp
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
    }
}

// Usando a classe
Pessoa pessoa = new Pessoa();
pessoa.Nome = "Maria";
pessoa.Idade = 30;
pessoa.Apresentar();
```

## 6. Modificadores de Acesso

Modificadores de acesso controlam a visibilidade dos membros de uma classe.

- `public`: Acessível de qualquer lugar.
- `private`: Acessível apenas dentro da mesma classe.
- `protected`: Acessível dentro da mesma classe e classes derivadas.
- `internal`: Acessível dentro do mesmo assembly.

## 7. Propriedades e Métodos Estáticos

Membros estáticos pertencem à classe em vez de instâncias específicas.

```csharp
class Calculadora
{
    public static int Somar(int a, int b)
    {
        return a + b;
    }
}

// Chamando um método estático
int resultado = Calculadora.Somar(3, 4);
```

## 8. Tratamento de Exceções

Exceções são tratadas usando blocos `try`, `catch`, e `finally`.

```csharp
try
{
    int divisor = 0;
    int resultado = 10 / divisor;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro: divisão por zero.");
}
finally
{
    Console.WriteLine("Execução concluída.");
}
```

Essa visão geral cobre os conceitos básicos da sintaxe de C#. A linguagem oferece muitos recursos avançados para desenvolver aplicativos robustos e eficientes.
