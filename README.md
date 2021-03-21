# Projeto - Programação Orientado a Objetos em C#

## :scroll: Sumário

- [Sobre](#about)
- [Estrutura](#structure)
- [Conceitos](#learned)

## :computer: Sobre <a name = "about"></a>

Projeto desenvolvido em console de aplicação de transferências bancárias aplicando o paradigma de orientação a objetos em prática.
Apliquei validação de contas ao realizar tentativas de utilização do sistema com indices não existentes.

> Bootcamp 🚀 = .Net Fundamentals
<p align="center">
<br>
  <a href="https://web.digitalinnovation.one/" rel="noopener">
 <img width=800px height=400px src="https://hermes.digitalinnovation.one/site/images/cover_dio.jpg" alt="Logo Digital Innovation One"></a>
</p>


### :mag: Imagens do projeto

<p align="center">
 :globe_with_meridians: DEPLOY
</p>

<p align="center">
<img width=683px height=384px src="https://image.shutterstock.com/image-vector/sample-stamp-grunge-texture-vector-260nw-1389188336.jpg" alt="Exemplo">
</p>

## :file_folder: Estrutura do projeto <a name = "structure"></a>

 ├── dio-project-poo                   
    ├── class                    # Arquivos com classes do programa.
    ├── enum                     # Arquivos com dados pré-definidos
    ├── Program.cs               # Main de app
    └── README.md

## :memo: Conceitos aprendidos <a name = "learned"></a>

### Orientação a objetos
O paradigma de orientação a objetos garante ao código:
- Melhor manuntenção
- Reaproveitamento

#### propriedades
Definir a forma do escopo da classe,
para garantir a forma no qual como são acessadas pelo restante do código.
Os tipos são:
- Public
- Protected
- Private

#### Métodos:

<acessibilidade> <sobrecarga> <retorno> <nomeFuncao>()

- Acessibilidade: public, protected, private
- Sobrecarga: override
- Retorno: Qual o tipo do retorno (int, double, string, ...)

Método Construtor: invocado como primeira função da instância de classe.

Enum - É um tipo de dado com uma série de valores pré-definidos.

### Formatação composta
```
  Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
```
[Microsoft]("https://docs.microsoft.com/pt-br/dotnet/standard/base-types/-composite-formatting")

### Armazenamento em memória
```
using System.Collections.Generic
static Lista<Conta> = listContas = new List<Conta>();
```
Útil para teste de dados sem banco de dados configurado.