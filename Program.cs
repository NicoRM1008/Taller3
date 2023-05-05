using taller3;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

pokemon pok = new pokemon();


app.MapGet("/", () => "Hello World!");

//Añadir un pokemon
app.MapPost("/api/v1/pokemon", (pokemonDTO p) => {
    pok.add(p);
});

//Añadir N pokemones
app.MapPost("/api/v1/pokemonN", (List<pokemonDTO> po) =>{
    pok.addSeveral(po);
});

//Mostrar un pokemon
app.MapGet("/api/v1/pokemon/{id}", (int id) =>{
    return pok.BringOne(id);
});

//Mostrar todos los pokemones
app.MapGet("/api/v1/pokemonN", () =>{
    return pok.All();
});

//Mostrar pokemones por tipo
app.MapGet("/api/v1/pokemonN/{type}", (string type) =>{
    return pok.AllByType(type);
});

//Actualizar un  pokemon
app.MapPut("/api/v1/pokemon/{id}", (int id, pokemonDTO p) => {
    pok.update(id, p);
});

//Eliminar un pokemon
app.MapDelete("/api/v1/pokemon/{id}", (int id) => {
    pok.delete(id);
});

 /*app.MapGet("/api/v1/pokemonC", (pokemonDTO po1, pokemonDTO po2) =>{
  pok.combat(po1, po2);
 });

app.Run();


[{
  "id": 1,
  "nombre":"samu",
  "tipo":"agua",
  "ataques":[12,34,56,78],
  "defensa": 23
},
 {
  "id": 2,
  "nombre":"metapod",
  "tipo":"agua",
  "ataques":[12,45,56,67],
  "defensa": 23
},
 {
  "id": 3,
  "nombre":"tumama",
  "tipo":"agua",
  "ataques":[1,3,6,8],
  "defensa": 345
}]

*/