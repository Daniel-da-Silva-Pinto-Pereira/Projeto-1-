using System;


class Entregador{
  private string nome_entregador;
  private string pacote_recebido;
  public int tempo_de_entrega;

  public void setnome_entregador(string ne){
    nome_entregador = ne;
  }
  public void setpacote_recebido(string pr){
    pacote_recebido = pr;
  }
}