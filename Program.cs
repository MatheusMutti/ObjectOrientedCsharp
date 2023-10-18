/* 

Projeto para exemplificar o uso de orientação a objeto

Encapsulamento:

    Expor somente o necessário através de interfaces definidas.
        Atributo ser privado, mas ele ser acessado através de métodos.

Henrança:

    Criar nova classe baseada em uma classe existente.
        Cachorro : Animal

Polimorfismo:

    Objetos de classes diferentes sejam tratados como objetos da mesma classe base.

Abstração:

    Modelar objetos do mundo real como classes e objetos no código.
        A classe veículo tem objetos e métodos, porém para criar uma instância precisa de mais informações
        que são definnidar a partir de outras classes.

------------------------------------------------------------------------------------------------------------------


Aplicativo de Gerenciamento de Contas Bancárias

Classe Conta

    Atributos

        CPF ok
        Nome ok
        Saldo ok
        Limite ok 
        Cartão de Crédito        

    Métodos
        Saque
        Deposito
        Consulta Saldo
        Rendimento
        Transferir
        Extrato

TODO:

Classe Conta Corrente
Classe Conta Poupança
Métodos da classe base

------------------------------------------------------------------------------------------------------------------ */

Conta ContaMatheus = new Conta(1000, "Matheus");
Conta ContaJulia = new Conta(2000, "Julia");

ContaMatheus.ChecarSaldo();

ContaMatheus.Transferencia(500, ContaJulia);

ContaMatheus.ChecarSaldo();
ContaJulia.ChecarSaldo();

