namespace Classes_Com_Valores;

internal class Program
{
    static void Main()
    { // Criando um ojeto chamado "meuCarro"
        // atribuindo o modelo OBRIGATORIAMENTE graças ao contrutor "Carro" que precisa passar uma string como parametro.
        var meuCarro = new Carro("Suzuki");

        /* 
           atribuindo um valor ao "Modelo" graças ao "set;" do arquivo "Carro.cs".
           meuCarro.Modelo = "Suzuki";  
           essa é uma forma de fazer.
        */

        // escolhendo a cor do Carro.
        meuCarro.Cor = Cor.Roxo;
        // criando uma instância da "DateOnly" para o "LançadoEm" receber a data do lançamento.
        meuCarro.LançadoEm = new DateOnly(2024, 12, 24);
        //imprimindo o modelo do carro
        meuCarro.NomeModelo();
        //imprimindo a Cor.
        Console.WriteLine(meuCarro.Cor);
        //imprimindo a data.
        Console.WriteLine(meuCarro.LançadoEm);

    }
}