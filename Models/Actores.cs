public class Actores
{
    public int IdActor{get;set;}

    public int IdSerie{get;set;}

    public string Nombre {get;set;}




    public Actores(){

}

public Actores( int vIdActor, int vIdSerie, string vNombre)
{
    IdActor = vIdActor;
    IdSerie = vIdSerie;
    Nombre = vNombre;
}
}

