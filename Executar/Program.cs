// See https://aka.ms/new-console-template for more information
using Cliente;

Console.WriteLine("Hello, World!");

var Pessoas = new List<Pessoa>() 
{ 
    new Pessoa() { CPF = "12030926795", Nome = "Tiago Pereira Cardoso", Nascimento = DateTime.Parse("1989-12-26") },
    new Pessoa() { CPF = "12847566708", Nome = "Jhonathan Pereira", Nascimento = DateTime.Parse("1993-01-04") }
};

var generica = "Tiago";

string texto = "1234 meu nome e qiwjeiqwjeip 4.1 true List";
int numero = 50;
bool verdairoOuFalso = true;

Console.WriteLine("oiaoisoaisoaisoias");
Console.WriteLine(123123123);
Console.WriteLine(generica + texto + numero + verdairoOuFalso);

Console.WriteLine($"Ola eu sou {generica}, recebo {numero} e nunca minto {verdairoOuFalso}.");

var minhaLista = new List<string>() { "ola", "ixi" };

minhaLista.Add("texto 1");
minhaLista.Add("Caramba muito legal");
minhaLista.Add("Lascou!!!");

for (var i = 0; i < minhaLista.Count; i++)
{
    if (minhaLista[i].Equals("ixi"))
    {
        Console.WriteLine($"O indice de {minhaLista[i]} e {i}");

        // Se o cliente tem saldo devedor, mostrar mensagem na tela de cobranca
        if(i == 1)
        {
            Console.WriteLine("Pague sua fatura em atraso");
        }
    }
}

foreach (var item in minhaLista)
{
    Console.WriteLine(item);
}

foreach (var pessoa in Pessoas)
{
    Console.WriteLine($"Meu nome e {pessoa.Nome} e meu CPF e {pessoa.CPF} e meu nascimento e {pessoa.Nascimento}.");
}

Console.WriteLine(Pessoas);

Console.WriteLine(minhaLista);