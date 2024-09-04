# Playground e Cheatsheet Para Aprender Csharp

> Essa é uma coleção de projetos Csharp dividida em [tópicos](#índice) que contém
> exemplos de código com explicações, diferentes usos e links para outras leituras.

> _Ler em:_ [_English_](README.en-US.md), [_Español_](README.es-ES.md), [_Traditional Chinese_](README.zh-TW.md).

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

Cada projeto neste repositório é estruturado para facilitar a aprendizagem e experimentação dos tópicos de C#. Aqui está um exemplo de como um projeto típico está organizado:

```csharp
    // Nome do tópico
    // Exemplo: Lists (Listas em C#)

    // Link para leituras adicionais
    // @see: https://www.learncs.org/en/Lists

    // Descrição do Tópico
    // Uma explicação mais detalhada sobre o tópico atual, como listas (Lists) em C#.
    // Exemplo: As listas em C# são semelhantes às listas em outras linguagens, como Java, oferecendo um objeto que pode conter múltiplos elementos em uma ordem específica.

    // Exemplo de Código
    List<int> numbers = new List<int>(); // Declaração de uma lista de inteiros

    // Explicação do Subtópico
    // Cada arquivo contém exemplos e funções de teste que ilustram subtópicos (ex.: tipos de lista, métodos de lista).
```

### Exemplo: Trabalhando com Listas em C#

As listas em C# são muito semelhantes às listas em outras linguagens, como Java. Elas são objetos que contêm variáveis em uma ordem específica. O tipo de variável que a lista pode armazenar é definido usando a sintaxe genérica (`<T>`). Veja abaixo um exemplo de como declarar e manipular listas em C#:

```csharp
// Declaração de uma lista de inteiros chamada "numbers"
List<int> numbers = new List<int>();

// Adicionando elementos à lista
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

// Imprimindo os elementos da lista
Console.WriteLine(string.Join(", ", numbers)); // Saída: 1, 2, 3

// Adicionando um array inteiro à lista usando o método AddRange
int[] array = new int[] { 4, 5, 6 };
numbers.AddRange(array);

// Imprimindo os elementos atualizados da lista
Console.WriteLine(string.Join(", ", numbers)); // Saída: 1, 2, 3, 4, 5, 6
```

Diferença entre Listas e Arrays

- **Listas**: São de tamanho dinâmico, ou seja, podem crescer e diminuir conforme necessário. Elas são úteis quando você não sabe o número exato de elementos que precisará armazenar.
- **Arrays**: Têm tamanho fixo, definido no momento da criação, e são melhores para quando o número de elementos é conhecido e fixo.

### Então você pode querer fazer o seguinte:

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
   - [byte](src/data_types/test_byte.cs)
   - [sbyte](src/data_types/test_sbyte.cs)
   - [short](src/data_types/test_short.cs)
   - [ushort](src/data_types/test_ushort.cs)
   - [int](src/data_types/test_numbers-int.cs)
   - [uint](src/data_types/test_uint.cs)
   - [long](src/data_types/test_long.cs)
   - [ulong](src/data_types/test_ulong.cs)
   - [float](src/data_types/test_numbers-float.cs)
   - [double](src/data_types/test_double.cs)
   - [decimal](src/data_types/test_decimal.cs)
   - [char](src/data_types/test_char.cs)
   - [bool](src/data_types/test_bool.cs)
   - [string](src/data_types/test_strings.cs)
   - [object](src/data_types/test_object.cs)
4. **Controles de Fluxo**
   - [A declaração `if`](src/control_flow/test_if.cs)
   - [A declaração `if-else`](src/control_flow/test_if_else.cs)
   - [A declaração `else if`](src/control_flow/test_else_if.cs)
   - [A declaração `foreach`](src/control_flow/test_foreach.cs)
   - [A declaração `switch`](src/control_flow/test_switch.cs)
   - [A declaração `for`](src/control_flow/test_for.cs)
   - [A declaração `while`](src/control_flow/test_while.cs)
   - [A declaração `do-while`](src/control_flow/test_do_while.cs)
   - [A declaração `try-catch`](src/control_flow/test_try_catch.cs)
   - [A declaração `break`](src/control_flow/test_break.cs)
   - [A declaração `continue`](src/control_flow/test_continue.cs)
   - [A declaração `return`](src/control_flow/test_return.cs)
   - [A declaração `using`](src/control_flow/test_using.cs)
   - [A declaração `yield`](src/control_flow/test_yield.cs)
   - [A declaração `async/await`](src/control_flow/test_async_await.cs)
   - [A declaração `goto`](src/control_flow/test_goto.cs)
5. **Funções**
   - [Aguarde](src/metodos/test_metodos.cs)
6. **Classes**
   - [Definição de Classe](src/classes/test_class_definition.cs) (declaração `class`)
   - [Classes dos Objetos](src/classes/test_class_objects.cs)
   - [Instância dos Objetos](src/classes/test_instance_objects.cs)
   - [Métodos de Objetos](src/classes/test_method_objects.cs)
   - [Variável de Classe e Instância](src/classes/test_class_and_instance_variables.cs)
   - [Herança](src/classes/test_inheritance.cs)
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
    - [Tempo e Datas](src/standard_libraries/test_datetime.cs) (bibliotecas `TimeSpan` e `DateTime`)

## Pré-requisitos

**Instalando o Dotnet**

Certifique-se de ter o [SDK Dotnet instalado](https://dotnet.microsoft.com/en-us/download) em sua máquina.

Você pode ver a versão do Dotnet executando:

```bash
dotnet --version
```

Observe que neste repositório sempre que você vê o `dotnet`, será assumido que é o Dotnet **6**.

**Instalando dependências**

Instale todas as dependências necessárias para o projeto executando:

1. Abra o terminal ou prompt de comando.
2. Navegue até a pasta raiz do seu projeto, onde o arquivo .csproj está localizado.
3. Execute o seguinte comando:

```bash
dotnet restore
```

O comando dotnet restore irá baixar todas as dependências listadas no arquivo .csproj do seu projeto, utilizando o NuGet como gerenciador de pacotes.

💡**Dica Adicional**

Se precisar atualizar as dependências para as versões mais recentes disponíveis, você pode usar o comando:

```bash
dotnet restore --force
```

Isso força uma nova restauração, baixando as versões mais recentes dos pacotes, conforme especificado nas configurações do projeto.

## Testando o Código

Testes são feitos usando os frameworks [Xunit](https://xunit.net/), [NUnit](https://nunit.org/) e [MSTest](https://github.com/microsoft/testfx).

Para executar todos os testes, execute o seguinte comando na pasta raiz do projeto:

```bash
dotnet test
```

Para executar testes específicos, execute:

```bash
dotnet test <caminho_do_projeto>
```

Para executar um teste específico por nome:

```bash
dotnet test --filter FullyQualifiedName~Namespace.TestClass.TestMethod
```
