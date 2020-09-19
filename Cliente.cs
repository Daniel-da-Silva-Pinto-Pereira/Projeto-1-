using System;

class cliente{
  public string nome;
  public string endereço;
  
  public void Adcionado_no_Carrinho(string roupa, int quantidade, double valor){
   Console.WriteLine("Roupa Escolhida>> {0} - Quantidade>> {1} - Valor Total a Pagar>> {2} Reais", roupa, quantidade, valor);
  }
  
  public void Pagar(string roupa, int qtd, double valor){
   Console.WriteLine("Roupas Escolhidas>> {0} - Valor Total Pago  >> {1} Reais", roupa, Roupa.ValorTotalaPagar(qtd, valor));  
  }

  public void Dados_da_Entrega(string nome_entregador,string pacote_recebido, int tempo_de_entrega){
    Console.WriteLine("Entregador >> {0} - Pacote Recebido >> {1} - Entrega em {2} Dias",nome_entregador, pacote_recebido, tempo_de_entrega);
  }
  public void Dados_do_Cliente(string nome, string endereço){
    Console.WriteLine("Nome do Cliente >> {0} - Emdereço do Cliente >> {1}",nome, endereço);
  }
}