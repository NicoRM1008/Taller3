namespace taller3;

public class pokemon: Ipokemon{
    
    private List<pokemonDTO> BD;

    public pokemon(){
        this.BD = new List<pokemonDTO>();
    }
    public void add(pokemonDTO po){
        for (int i = po.ataques.Length-1 ; i >= 0; i--){
    if (po.ataques[i] > 40 || po.ataques[i] < 0)
    {
        po.ataques = po.ataques.Where(x=>x!=po.ataques[i]).ToArray();
    }
    }

    if(po.defensa < 0 || po.defensa > 30){
        po.defensa=0;
    }

        this.BD.Add(po);
    }

    public void addSeveral(List<pokemonDTO> po){
        for(int i = 0; i < po.Count; i++){

            this.add(po[i]);
            
        }
    }
     public void delete(int Id){
        this.BD.RemoveAll(po => po.id == Id);
    }
    public void update(int Id, pokemonDTO po){ //actulizar
        pokemonDTO pokemonUpdate = this.BD.Single(po => po.id == Id);
        pokemonUpdate = po;
    }
    public pokemonDTO BringOne(int id){
        pokemonDTO poke = this.BD.Single(po => po.id == id);
        return poke;
    }
    public List<pokemonDTO> All(){
        return this.BD;
    }
    public List<pokemonDTO> AllByType(string type){
        List<pokemonDTO> aux = new List<pokemonDTO>();
         
         foreach (pokemonDTO p in this.BD){
            if(p.tipo == type){
                aux.Add(p);
            }
         }
        return aux;
    }
    
    /*public string combat(pokemonDTO po1, pokemonDTO po2){

        int f1 = 0;
        int f2 = 0;
        
        var random1 = new Random();
        var ata1 = random1.Next(0,3);
        var random2 = new Random();
        var ata2 = random2.Next(0,3);

       if(po1.defensa >= po2.ataques[ata1]){
             f1 = f1 + 1;
       }if(po1.defensa >= po2.ataques[ata2]){
             f2 = f2 + 1;
       }

       if(f1 > f2){
        return "Ganador luchador 1";
       }if(f2 > f1){
        return "Ganador Luchador 2";
       }else{
        return "Empate";
       }
    }*/
}