using System;

class MainClass {
  public static void Main (string[] args) {
    cliente Daniel= new cliente();
    Daniel.nome="Daniel da Silva";
    Daniel.endereço="Avenida Região Sudeste,N 400";
   

    Roupa CalçaJeans= new Roupa();
    CalçaJeans.Setnome("Calça Black Jeans Slim");
    CalçaJeans.setcaracteristicas("Preto"); 
    CalçaJeans.Setpreço(100);
    Roupa Camisa= new Roupa();
    Camisa.Setnome("Camisa Social");
    Camisa.setcaracteristicas("Branco");
    Camisa.Setpreço(150);
    Roupa Bermuda= new Roupa();
    Bermuda.Setnome("Bermuda de Moletom");
    Bermuda.setcaracteristicas("Cinza");
    Bermuda.Setpreço(120);
    Entregador Dados= new Entregador();
    Dados.setnome_entregador("Carlinhos");
    Dados.setpacote_recebido("Sim");
    Dados.tempo_de_entrega= 7;
    
    
    Daniel.Dados_do_Cliente("Daniel da Silva", "Avenida Região Sudeste,N 400");
    Daniel.Adcionado_no_Carrinho("Calça Black Jeans Slim", 2, 200 );
    Daniel.Adcionado_no_Carrinho("Camisa Social", 4, 600);
    Daniel.Adcionado_no_Carrinho("Bermuda de Moletom", 2, 240);
    Daniel.Pagar("Calça Black Jeans(2)/Camisa Social(4)/Bermuda de Moletom(2)", 2,520);
    

    Daniel.Dados_da_Entrega("Carlos", "Sim", 7);
    



  }
}