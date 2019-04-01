class Veiculo{
    private string nome;
    private string motor;
    private double comprimento;
    private double largura;
    private double preco;

    public Veiculo(string nome){
        this.nome = nome;
    }
    public Veiculo(string n, string m, double c, double l, double p){
        nome = n;
        motor = m;
        comprimento = c;
        largura = l;
        preco = p;
    }

    public string GetNome(){
        return nome;
    }
    public void SetNome(string nome){
        this.nome = nome;
    }
    public  string GetMotor(){
        return motor;
    }
    public void SetMotor(string motor){
        this.motor = motor;
    }
    public double GetComprimento(){
        return comprimento;
    }
    public void SetComprimento(double comprimento){
        this.comprimento = comprimento;
    }
    public double GetLargura(){
        return largura;
    }
    public void SetLargura(double largura){
        this.largura = largura;
    }
    public double GetPreco(){
        return preco;
    }
    public void SetPreco(double preco){
        this.preco = preco;
    }

}