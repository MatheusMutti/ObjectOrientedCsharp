public class Conta {

    private int _saldo;
    public string Nome {get; set;}
    public int CPF {get; set;}
    public decimal Limite {get; set;}

    public Conta(int saldoInicial, string nomeInicial)
    {
        _saldo = saldoInicial;
        Nome = nomeInicial;
    }
    public virtual void ChecarSaldo()
    {
        Console.WriteLine($"O saldo da conta é de {_saldo}");
    }

}