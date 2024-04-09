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
    public virtual void Atacar() {
        Console.WriteLine("Basic Attack!");
    }
}

public class Guerreiro: Personagem {
    private string arma;

    public Guerreiro(string nome; string raca; int lv;) : base(nome, raca, lv){
        Arma = arma;
    }

    public string Arma{
        get { return arma; }
        set { arma = value; }
    }
    public override void Atacar() {
        Console.WriteLine("Slash!");
    }
}

public class Mago: Personagem {
    private string cajado;

    public Guerreiro(string nome; string raca; int lv;) : base(nome, raca, lv){
        Cajado = cajado;
    }

    public string Cajado{
        get { return cajado; }
        set { cajado = value; }
    }
    public override void Atacar() {
        Console.WriteLine("Fire Ball!");
    }
}

public class Arqueiro: Personagem {
    private string arco;

    public Guerreiro(string nome; string raca; int lv;) : base(nome, raca, lv){
        Arco = arco;
    }

    public string Arco{
        get { return arco; }
        set { arco = value; }
    }
    public override void Atacar() {
        Console.WriteLine("Shoot Arrow!");
    }
}