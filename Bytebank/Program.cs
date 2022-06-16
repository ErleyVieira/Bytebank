using Bytebank;

Console.WriteLine("Boas vindas ao seu banco, Bytebank!");

ContaCorrente conta = new ContaCorrente();
Console.WriteLine($"Titular da conta: {conta.titular}");
Console.WriteLine($"Número da conta: {conta.conta}");
Console.WriteLine($"Agência: {conta.nome_agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");




ContaCorrente conta1 = new();

conta1.titular = "André Silva";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();

conta2.titular = "Amanda Silva";
conta2.conta = "111999-X";
conta2.numero_agencia = 58;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

ContaCorrente conta3 = new ContaCorrente();

conta3.titular = "André Silva";
conta3.conta = "10123-X";
conta3.numero_agencia = 23;
conta3.nome_agencia = "Agência Central";
conta3.saldo = 100;




Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Numero Agência: " + conta1.numero_agencia);
Console.WriteLine("Nome Agência: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);