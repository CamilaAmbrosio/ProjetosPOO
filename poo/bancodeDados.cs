using System;
class BancoDeDados{

    int indiceCategoria;
    int indiceVeiculo;
    int indiceFabricante;

    private Categoria[] categorias = new Categoria[10];
    private Veiculo[] veiculos = new Veiculo[10];
    private Fabricante[] fabricantes = new Fabricante[10];
  
    public void InserirCategoria(Categoria c){
        categorias[indiceCategoria++] = c;
    }
    public void InserirVeiculo(Veiculo v){
        veiculos[indiceVeiculo++] = v;
    }
    public void InserirFabricante(Fabricante f){
        fabricantes[indiceFabricante++] = f;
    }
    public Categoria[] GetCategorias(){
        return categorias;
    }
    
    public Fabricante[] GetFabricantes(){
        return fabricantes;
    }

}