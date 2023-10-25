public class Conta {
    private DateTime dataAtual;
    public string dataFormatada;
    private string _nome;
    public string Nome { get; set;}
    public int CPF 
    {get; set;}        
    private static int _proximoNumeroConta = 1;
    public int NumeroConta { get; private set; }
    private int _saldo;
    List<string> ListaTransacoes = new List<string>();    //alterar forma de implementação para receber um tipo de entrada "transação" e não string, adicionar métodos para adicionar transação assim que feita


    public Conta()
    {
        dataAtual = DateTime.Now;
        dataFormatada = dataAtual.ToString("HH:mm dd/MM/yyyy");
        NumeroConta = _proximoNumeroConta;
        _proximoNumeroConta++;        
    }

    // Atributos da Classe
    public virtual void ChecarSaldo(){
        
        Console.WriteLine($"O saldo da conta é de {_saldo}.");
    }
    public virtual void Transferencia(int valor, Conta destino)
    {
        if (valor > _saldo){
            Console.WriteLine("Saldo insuficiente!");
        }
        else {
            _saldo -= valor;
            destino._saldo += valor;
            //Adicionando transação a lista:
            destino.ListaTransacoes.Add($"Transferência: R$+{valor}");
            ListaTransacoes.Add($"Transferência: R$-{valor}");
        }
    }    
    public virtual void Saque(int valor)
    {
        if (valor > _saldo){
            Console.WriteLine("Saldo insuficiente!");
        }
        else {
            _saldo -= valor;
            ListaTransacoes.Add($"Saque: R$-{valor}");
        }        
    }
    public virtual void Deposito(int valor)
    {
        _saldo += valor;
        ListaTransacoes.Add($"Deposito R$+{valor}");
    }
    public virtual void Extrato(){
        
        Console.WriteLine("------------------------");

        Console.WriteLine($"Extrato da conta:\n");
        
        foreach (string item in ListaTransacoes)
        {
            Console.WriteLine($"{item} {dataFormatada} ");
        }
        Console.WriteLine("------------------------");
    }

   
   
   
   
    // Criação subclasse conta corrente
public class ContaCorrente : Conta {
    private double limiteConta;        
    public ContaCorrente(int saldoInicial, string nomeInicial){
        
        _saldo = saldoInicial;
        Nome = nomeInicial;}
    
    public double GetLimiteConta()
    {
        return limiteConta;
    }

    public void SetLimiteConta(double novoLimite)
    {
        limiteConta = novoLimite;
    }
    
}
   
   
   
   
    // Criação subclasse poupança
public class ContaPoupança : Conta {     

    public ContaPoupança(int saldoInicial, string nomeInicial){

        _saldo = saldoInicial;
        Nome = nomeInicial;
    }
    
}
}