public class Temporadas 
{
    public int IdTemporada{get;set;}

    public int IdSerie{get;set;}

    public int NumeroTemporada{get;set;}

    public string TituloTemporada {get;set;}


    public Temporadas()
{

}

public  Temporadas( int vIdTemporada, int vIdSerie, int vNumeroTemporada, string vTituloTemporada)
{   
    IdTemporada = vIdTemporada;
    IdSerie = vIdSerie;
    NumeroTemporada = vNumeroTemporada;
    TituloTemporada = vTituloTemporada;
}
}

