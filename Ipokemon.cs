namespace taller3;

public interface Ipokemon{
    void add(pokemonDTO po);
    void addSeveral(List <pokemonDTO> po);
    void delete(int id);
    void update(int id, pokemonDTO po);
    pokemonDTO BringOne(int id);
    List<pokemonDTO> All();
    List<pokemonDTO> AllByType(string type);
   // string combat(pokemonDTO po1, pokemonDTO po2);
}