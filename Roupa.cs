using System;


class Roupa{
  private string nome;
  private string caracteristicas;
  private double preço;

  public void Setnome(string n){
    nome = n;
  }
  public void Setpreço(double p){
    preço = p;
  }
  public void setcaracteristicas(string c){
    caracteristicas = c ;
  }
 
  public double ValorTotalaPagar(int qtd){
    return qtd*preço + qtd*preço + qtd*preço;
  }
  public static double ValorTotalaPagar(int qtd, double valor){
    return qtd*valor;
  }

 
}