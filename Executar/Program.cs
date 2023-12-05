using Cliente;

var Pessoas = new List<Pessoa>() 
{ 
    new Pessoa() { CPF = "12030926795", Nome = "Tiago Pereira Cardoso", Nascimento = DateTime.Parse("1989-12-26") },
    new Pessoa() { CPF = "12847566708", Nome = "Jhonathan Pereira", Nascimento = DateTime.Parse("1993-01-04") },
    new Pessoa() { CPF = "10198942702", Nome = "Ana Luiza Cortes", Nascimento = DateTime.Parse("1984-09-09") }
};

var Endereco = new List<PessoaEndereco>() 
{
    new PessoaEndereco() { CPF = "12030926795", Endereco = "Via Luigi Chiereguin", Numero = 27, Estado = "TV", Cidade = "Treviso", CEP = "31100" },
    new PessoaEndereco() { CPF = "12030926795", Endereco = "Av Cristovao Colombo", Numero = 75, Estado = "ES", Cidade = "Serra", CEP = "29163172" },
    new PessoaEndereco() { CPF = "12847566708", Endereco = "Vista do mestre", Numero = 167, Estado = "ES", Cidade = "Serra", CEP = "29163000" },
};

foreach (var pessoa in Pessoas)
{
    var End = Endereco.Where(x => x.CPF.Equals(pessoa.CPF));

    Console.WriteLine($"{pessoa.Nome} tem ( {End.Count()} ) enderecos cadastrados no sistema");

    int cnt = 1;
    foreach (var item in End)
    {
        Console.WriteLine($"{pessoa.Nome} - Endereco {cnt}: {item.Endereco} {item.Numero}, {item.Cidade} {item.Estado} - CEP/CAP: {item.CEP}");
        cnt++;
    }
}