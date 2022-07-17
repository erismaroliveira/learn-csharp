# Playground e Cheatsheet Para Aprender Csharp

> Essa é uma coleção de projetos Csharp dividida em [tópicos](#índice) que contém 
exemplos de código com explicações, diferentes usos e links para outras leituras.

> _Ler em:_ [_English_](README.md), [_Español_](README.es-ES.md), [_Traditional Chinese_](README.zh-TW.md).

É um **playground** porque você pode fazer alterações no código para ver como ele se comporta,
além de [testá-lo](#testando-o-código) usando asserções. Também é possível 
[revisar o código](#revisando-o-código) que você escreveu automaticamente e verificar se ele se encaixa
no guia de estilo de código Csharp.
Isso tudo pode tornar seu processo de aprendizagem mais interativo e ajudar a manter a qualidade
do código bastante alta desde o início.

É um **cheatsheet** porque você pode voltar a esses exemplos de código quando quiser recapitular a sintaxe das 
[estruturas padrão do Csharp](#índice). O código está cheio de asserções, então você poderá ver o retorno dos métodos sem precisar executá-los.

> _Você pode se interessar também por 🤖 [Gravatar Extensions](https://github.com/erismaroliveira/Gravatar)_

## Como Usar Esse Repositório

Nesse repositório, cada projeto Csharp possui a seguinte estrutura:

```c#
"""Lists  <--- Nome do tópico

# @see: https://www.learncs.org/en/Lists  <-- Link para outras leituras.

A seguir, uma explicação mais detalhada do tópico atual (ex, informações gerais sobre listas (Lists)).
"""


List<int> numbers = new List<int>();
    """Explicação do subtópico.
    
    Cada arquivo contém funções de teste que ilustram subtópicos (ou seja, tipo de lista, métodos de lista).
    """
    
    # As listas em C# são muito semelhantes às listas em Java. Uma lista é um objeto que contém variáveis ​​em uma ordem específica. O tipo de variável que a lista pode armazenar é definido usando a sintaxe genérica. Aqui está um exemplo de definição de uma lista chamada numbersque contém números inteiros.  <-- Comentários explicam a ação.
    List<int> numbers = new List<int>();

    A diferença entre uma lista e um array é que as listas são de tamanho dinâmico, enquanto os arrays têm um tamanho fixo. Quando você não souber a quantidade de variáveis ​​que seu array deve conter, use uma lista.

    Uma vez que a lista é inicializada, podemos começar a inserir números na lista.
    List<int> numbers = new List<int>();
    numbers.Add(1);
    numbers.Add(2);
    numbers.Add(3);
    
    # Também podemos adicionar um array inteiro a uma lista usando a AddRange função:
    List<int> numbers = new List<int>();
    int[] array = new int[] { 1, 2, 3 };
    numbers.AddRange(array);
```

Então você pode querer fazer o seguinte:

- [Encontrar o tópico](#índice) que deseja aprender ou recapitular.
- Ler os comentários e/ou a documentação vinculada em cada projeto (como no exemplo acima).
- Analisar os exemplos e asserções para ver exemplos de uso e saída esperada dos métodos.
- Alterar o código ou adicionar novas asserções para ver o que acontece.
- [Executar testes](#testando-o-código) e [revisar o código](#revisando-o-código) para ver se ele
funciona e para saber se está escrito corretamente. 

## Índice

1. **Começando**
    - [O que é Csharp](src/getting_started/what_is_csharp.md)
    - [Sintaxe Csharp](src/getting_started/csharp_syntax.md)
    - [Variáveis](src/getting_started/test_variables.cs)
2. **Operadores**
    - [Operadores Aritméticos](src/operators/test_arithmetic.cs) (`+`, `-`, `*`, `/`, `%`)
    - [Operadores Bitwise](src/operators/test_bitwise.cs) (`&`, `|`, `^`, `>>`, `<<`, `~`)
    - [Operadores de Atribuição](src/operators/test_assigment.cs) (`=`, `+=`, `-=`, `*=`, `/=`, `%=` etc.)
    - [Operadores de Relacionais](src/operators/test_relation.cs) (`==`, `!=`, `>`, `<`, `>=`, `<=`)
    - [Operadores Lógicos](src/operators/test_logical.cs) (`&&`, `||`, `!`)
3. **Tipos de Dados**
    - [Int](src/data_types/test_numbers-int.cs)
    - [Float](src/data_types/test_numbers-float.cs)
    - [Decimal](src/data_types/test_decimal.cs)
    - [Double](src/data_types/test_double.cs)
    - [String](src/data_types/test_strings.cs)
    - [Char](src/data_types/test_char.cs)
4. **Controles de Fluxo**
    - [A declaração `if`](src/control_flow/test_if.cs)
    - [A declaração `for`](src/control_flow/test_for.cs)
    - [A declaração `while`](src/control_flow/test_while.cs)
    - [A declaração `try`](src/control_flow/test_try.cs)
    - [A declaração `break`](src/control_flow/test_break.cs)
    - [A declaração `continue`](src/control_flow/test_continue.cs)
5. **Funções**
    - [Aguarde](src/metodos/test_metodos.cs)
6. **Classes**
    - [Definição de Classe](src/classes/test_class_definition.cs) (declaração `class`)
    - [Classes dos Objetos](src/classes/test_class_objects.cs)
    - [Instância dos Objetos](src/classes/test_instance_objects.cs)
    - [Métodos de Objetos](src/classes/test_method_objects.cs)
    - [Variável de Classe e Instância](src/classes/test_class_and_instance_variables.cs)
    - [Herança](src/classes/test_inheritance.cs)
    - [Herança Múltipla](src/classes/test_multiple_inheritance.cs)
7. **Módulos**
    - [Módulos](src/modules/test_modules.cs) (declaração `using`)
    - [Pacotes](src/modules/test_packages.cs)
8. **Erros e Exceções**
    - [Tratando Exceções](src/exceptions/test_handle_exceptions.cs) (declaração `try`)
9. **Arquivos**
    - [Lendo e Escrevendo](src/files/test_file_reading.cs) (declaração `StreamWriter writer = new StreamWriter("erismar.txt")`)
10. **Adicional**
    - [Aguarde](src/additions/test_additions.cs)
11. **Algumas Bibliotecas Padrão**
    - [Tempo e Datas](src/standard_libraries/test_datetime.cs) (biblioteca `DateTime`)

## Pré-requisitos

**Instalando o Dotnet**

Certifique-se de ter o [Sdk Dotnet instalado](https://dotnet.microsoft.com/en-us/download) em sua máquina.

Você pode ver a versão do Dotnet executando:

```bash
dotnet --version
```

Observe que neste repositório sempre que você vê o `dotnet`, será assumido que é o Dotnet **6**.

**Instalando dependências**

Instale todas as dependências necessárias para o projeto executando:

```bash
dotnet restore
```

## Testando o Código

Testes são feitos usando o framework [Xunit](https://xunit.net/).

Para executar todos os testes, execute o seguinte comando na pasta raiz do projeto:

```bash
dotnet test
```

Para executar testes específicos, execute:

```bash
dotnet test teste.cs
```

 
