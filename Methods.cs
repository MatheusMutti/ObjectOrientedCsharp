public class Conta {
    private string _nome;
    public string Nome 
    {
        get => Nome.ToUpper();
    
    set
    {
        if (value == "")
        {
            throw new ArgumentException ("Nome não pode ser vazio");
        };
}}
    public int CPF 
    {get; set;}        
    private static int _proximoNumeroConta = 1;
    public int NumeroConta { get; private set; }
    private int _saldo;
    List<string> ListaTransacoes = new List<string>();    //alterar forma de implementação para receber um tipo de entrada "transação" e não string, adicionar métodos para adicionar transação assim que feita

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
        public decimal Limite {get; set;}

        public ContaCorrente(int saldoInicial, string nomeInicial){
        
            _saldo = saldoInicial;
            Nome = nomeInicial;
        }}
public class ContaPoupança : Conta {     

    public ContaPoupança(int saldoInicial, string nomeInicial){

        _saldo = saldoInicial;
        Nome = nomeInicial;
    }}}