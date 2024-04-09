public class Personagem {

    private string nome;
    private string raca;
    private int lv;
    public Personagem(string nome, string raca, int lv){
        this.nome = nome;
        this.raca = raca;
        this.lv = lv;
    }
    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
    public string Raca {
        get { return raca; }
        set { raca = value; }
    }
    public int LV {
        get { return lv; }
        set { lv = value; }
    }
    public void Atacar() {
        Console.WriteLine("Basic Attack!");
    }
    public void Atacar(string habilidade) {
        Console.WriteLine("Ataque especial:" + habilidade);
    }
}

public class Guerreiro: Personagem {
    private string arma;

    public Guerreiro(string nome; string raca; int lv; string arma;) : base(nome, raca, lv){
        Arma = arma;
    }

    public string Arma{
        get { return arma; }
        set { arma = value; }
    }
    public void Atacar() {
        Console.WriteLine("Slash!");
    }
    public void Atacar(string habilidade) {
        Console.WriteLine("Ataque especial do guerreiro:" + habilidade);
    }
}

public class Mago: Personagem {
    private string cajado;

    public Guerreiro(string nome; string raca; int lv; string cajado;) : base(nome, raca, lv){
        Cajado = cajado;
    }

    public string Cajado{
        get { return cajado; }
        set { cajado = value; }
    }
    public void Atacar() {
        Console.WriteLine("Fire Ball!");
    }
    public void Atacar(string habilidade) {
        Console.WriteLine("Ataque especial do mago:" + habilidade);
    }
}

public class Arqueiro: Personagem {
    private string arco;

    public Arqueiro(string nome; string raca; int lv; string arco;) : base(nome, raca, lv){
        Arco = arco;
    }

    public string Arco{
        get { return arco; }
        set { arco = value; }
    }
    public void Atacar() {
        Console.WriteLine("Shoot Arrow!");
    }
    public void Atacar(string habilidade) {
        Console.WriteLine("Ataque especial do arqueiro:" + habilidade);
    }
}

pubic class Program {
    public static void main (string[] args) {
        Guerreiro guerreiro = new Guerreiro("Sion", "Morto-Vivo", 50, "Machado de duas mãos");
        guerreiro.Atacar();
        guerreiro.Atacar("Golpe Demolidor!");

        Mago mago = new Mago("Dante", "Escolhido por Deus", 23, "Grimório da Morte");
        mago.Atacar();
        mago.Atacar("Definhar!");

        Arqueiro arqueiro = new Arqueiro("Joui", "Humano", 19, "Arco tocado pelo Sangue");
        arqueiro.Atacar();
        arqueiro.Atacar("Hemorragia!");
    }
}