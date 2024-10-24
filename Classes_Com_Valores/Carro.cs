namespace Classes_Com_Valores;

public class Carro
{
    // "get" usado para recuperar o valor da variavel "nome" e "set" para alterar o valor dessa variavel na Main.
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public DateOnly LançadoEm { get; set; } // usando o DateOnly para apenas aceitar data de calendarios
    public Cor Cor { get; set; }

    // poderiamos usar "required" depois do public para dizer que o conteudo a seguir é obrigatorio.
    // ou podemos usar o construtor, EXEMPLO:
    public Carro(string modelo)
    {
        Modelo = modelo;
    }
    //criando uma função para imprimir o modelo.
    public void NomeModelo()
    {
        Console.WriteLine(Modelo);
    }

}

