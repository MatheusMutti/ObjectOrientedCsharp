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
        Transferir ok
        Extrato ok

------------------------------------------------------------------------------------------------------------------ */

Conta ContaMatheus = new Conta.ContaCorrente (200, "Matheus");
Conta ContaJulia = new Conta.ContaPoupança (200, "Julia");

ContaMatheus.Transferencia(50, ContaJulia);
ContaMatheus.Saque(50);
ContaJulia.Saque(350);
ContaMatheus.Deposito(200);

ContaMatheus.Extrato();
