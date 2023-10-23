public class Conta {

    private static int _proximoNumeroConta = 1;
    public int NumeroConta { get; private set; }
    private int _saldo;
    List<string> ListaTransacoes = new List<string>();    

    public Conta()
    {
        NumeroConta = _proximoNumeroConta;
        _proximoNumeroConta++;        
    }

    // Atributos da Classe
    public virtual void ChecarSaldo(){}
    public virtual void Transferencia(int valor, Conta destino)
    {
        if (valor > _saldo){
            Console.WriteLine("Saldo insuficiente!");
        }
        else {
            _saldo -= valor;
            destino._saldo += valor;
            //Adicionando transação a lista:
            destino.ListaTransacoes.Add($"Transferência: +{valor}");
            ListaTransacoes.Add($"Transferência: -{valor}");
        }
    }    
    public virtual void Saque(int valor)
    {
        if (valor > _saldo){
            Console.WriteLine("Saldo insuficiente!");
        }
        else {
            _saldo -= valor;
            ListaTransacoes.Add($"Saque: -{valor}");
        }        
    }
    public virtual void Deposito(int valor)
    {
        _saldo += valor;
        ListaTransacoes.Add($"Deposito +{valor}");
    }
    public virtual void Extrato(){
        
        Console.WriteLine($"Extrato da conta:\n");
        
        foreach (string item in ListaTransacoes)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------");
    }

    // Criação subclasse Conta
public class ContaCorrente : Conta {
    public string Nome {get; set;}
    public int CPF {get; set;}        
    public decimal Limite {get; set;}

    public ContaCorrente( int saldoInicial, string nomeInicial){
        
        this._saldo = saldoInicial;
        this.Nome = nomeInicial;
    }

    public override void ChecarSaldo(){

        Console.WriteLine($"Saldo da conta corrente: {_saldo}");

    } //pode-se implementar métodos específicos para get e set
    
}
public class ContaPoupança : Conta {
    public string Nome {get; set;}
    public int CPF {get; set;}        

    public ContaPoupança(int saldoInicial, string nomeInicial){

        this._saldo = saldoInicial;
        this.Nome = nomeInicial;
    }

    public override void ChecarSaldo(){

        Console.WriteLine($"Saldo da conta poupança: {_saldo}");
    }
}

}