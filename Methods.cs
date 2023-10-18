public class Conta {

    private static int _proximoNumeroConta = 1;
    public int NumeroConta { get; private set; }    
    private int _saldo;    
    public string Nome {get; set;}
    public int CPF {get; set;}
    public decimal Limite {get; set;}

    public Conta(int saldoInicial, string nomeInicial)
    {
        _saldo = saldoInicial;
        Nome = nomeInicial;
        NumeroConta = _proximoNumeroConta;
        _proximoNumeroConta++;        
    }
    public virtual void ChecarSaldo()
    {
        Console.WriteLine($"Saldo da conta corrente: {_saldo}");
    }
    public virtual void Transferencia(int valor, Conta destino)
    {
        _saldo -= valor;
        destino._saldo += valor;
    }    
    public virtual void Saque(int valor)
    {
        _saldo -= valor;
    }    
    public virtual void Extrato(){}

public class ContaCorrente : Conta {

    public ContaCorrente( int saldoInicial, string nomeInicial) : base (saldoInicial, nomeInicial){}

    public override void ChecarSaldo(){}
}
public class ContaPoupança : Conta {

    public ContaPoupança(int saldoInicial, string nomeInicial) : base (saldoInicial, nomeInicial){}

    public override void ChecarSaldo(){}
}

}