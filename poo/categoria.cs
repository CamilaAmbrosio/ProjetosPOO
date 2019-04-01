class Categoria{
    
    private string nome;
    private Veiculo[] veiculos = new Veiculo[5];
    private int f;

    public Categoria(){
    }
    public Categoria(string n){
        nome = n;
    }

    public string GetNome(){
        return nome;
    }
    public int GetTotalVeiculos(){
        int total = 0;
        for(int i=0; i<veiculos.Length; i++){
            if(veiculos[i] != null){
                total++;
            }
        }
        return total;
    }

    public void Inserir(Veiculo v){
        veiculos[f++] = v;

    }
    public Veiculo[] Listar(){
        return veiculos;
    }
    public Veiculo MaiorValor(){
        Veiculo v = new Veiculo("","",0,0,0);
        double maior = 0;
        for(int i=0; i<veiculos.Length; i++){
            if(veiculos[i] != null && veiculos[i].GetPreco() > maior){
                maior =  veiculos[i].GetPreco();
                v = veiculos[i];
            }   
        }
        return v;   
    }
}