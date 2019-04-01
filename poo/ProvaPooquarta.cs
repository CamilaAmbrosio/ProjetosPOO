using System;

class Prova{

    private static Fabricante[] fabricantes = new Fabricante[3];
    private static BancoDeDados bd = new BancoDeDados();
    public static void Main(string[] args)
    {
        Console.WriteLine("1: Inserir fabricante \n2: Inserir categoria \n3: Inserir veículo \n4: Listar veículos \n5: Listar categorias e veiculos por fabricantes \n0: Fim");
        int menu = int.Parse(Console.ReadLine());
        while(menu != 0){
            switch(menu){
                case 1: 
                InserirFabricante();
                break;
                case 2:
                CriarCategoria();
                break;
                case 3:
                InserirVeiculo();
                break;
                case 4:
                ListarVeiculos();
                break;
                case 5:
                ListarCategoriasVeiculosPorFabricante();
                break;
            }
            Console.WriteLine("1: Inserir fabricante \n2: Inserir categoria \n3: Inserir veículo \n4: Listar veículos \n5: Listar categorias e veiculos por fabricantes \n0: Fim");
            menu = int.Parse(Console.ReadLine());
        }
    }
    public static void InserirFabricante(){
        Console.WriteLine("Digite nome do fabricante");
        string nomeFabricante = Console.ReadLine();
        Console.WriteLine("Digite país do fabricante");
        string paisFabricante = Console.ReadLine();
        Fabricante f = new Fabricante(nomeFabricante, paisFabricante);
        bd.InserirFabricante(f);
    }
    public static void CriarCategoria(){
        Console.WriteLine("Digite nome da categoria");
        string nomeCategoria = Console.ReadLine();
        Categoria c = new Categoria(nomeCategoria);
         bd.InserirCategoria(c);

         Fabricante[] fabricantes = bd.GetFabricantes();

        Console.WriteLine("Digite o número da fabricante");
        for(int i = 0; i < fabricantes.Length; i++){
            Fabricante fabric = fabricantes[i];
            if(fabric != null){
            Console.WriteLine($"{i} = {fabric.GetNome()} ");
            }
            
        }
        int menu = int.Parse(Console.ReadLine());
        Fabricante fabricanteSelecionada = fabricantes[menu];
        fabricanteSelecionada.Inserir(c);

    }
    public static void InserirVeiculo(){
        Console.WriteLine("Digite o nome do veículo");
        string nome = Console.ReadLine();
        Veiculo v = new Veiculo(nome);
        Console.WriteLine("Digite o nome do motor");
        v.SetMotor(Console.ReadLine());
        Console.WriteLine("Digite o comprimento do veículo");
        v.SetComprimento(double.Parse(Console.ReadLine()));
        Console.WriteLine("Digite a largura do veículo");
        v.SetLargura(double.Parse(Console.ReadLine()));
        Console.WriteLine("Digite o preço do veículo");
        v.SetPreco(double.Parse(Console.ReadLine()));
        

        bd.InserirVeiculo(v);
        Categoria[] categorias = bd.GetCategorias();

        Console.WriteLine("Digite o número da categoria");
        for(int i = 0; i < categorias.Length; i++){
            Categoria cate = categorias[i];
            if(cate != null){
            Console.WriteLine($"{i} = {cate.GetNome()} ");
            }
            
        }
        int menu = int.Parse(Console.ReadLine());
        Categoria categoriaSelecionada = categorias[menu];
        categoriaSelecionada.Inserir(v);
    }
    public static void ListarVeiculos(){
        Categoria[] cats = bd.GetCategorias();
         Console.WriteLine("Categorias: ");
        for (int j = 0; j < cats.Length; j++)
        {
            Categoria c = cats[j];
            if (c != null)
            {

                Console.WriteLine($"{c.GetNome()}");
                Veiculo[] veiculos = c.Listar();
                for (int g = 0; g < veiculos.Length; g++)
                {
                    Veiculo b = veiculos[g];
                    if (b != null)
                    {
                        Console.WriteLine($"Veículos: {b.GetNome()}");
                    }
                
                }
            }            
        }
    }
    
    public static void ListarCategoriasVeiculosPorFabricante(){
         Fabricante[] fabricantes = bd.GetFabricantes();
         for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante f = fabricantes[i];
            if(f != null){
                int total = 0;
                Console.WriteLine($"Fabricante: {f.GetNome()} País: {f.GetPais()}");

                Categoria[] cats = f.Listar();
                Console.WriteLine("Categorias: ");
                for (int j = 0; j < cats.Length; j++)
                {
                    Categoria c = cats[j];
                    if (c != null)
                    {
                        total += c.GetTotalVeiculos();
                        Console.WriteLine($"{c.GetNome()}");
                        Veiculo[] veiculos = c.Listar();
                        for (int g = 0; g < veiculos.Length; g++)
                        {
                            Veiculo b = veiculos[g];
                            if (b != null)
                            {
                                Console.WriteLine($"Veículos: {b.GetNome()}");
                            }
                      }                       
                    }
                }
                Console.WriteLine($"Total de veículos: {total}");
                Console.WriteLine($"O veículo de maior valor é: {f.MaiorValor().GetNome()}");
            }            
        }
    }
}



