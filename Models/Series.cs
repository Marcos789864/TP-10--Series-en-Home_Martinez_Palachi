public  class Series
{

    public int IdSerie {get;set;}

    public string Nombre {get;set;}

    public int AñoInicio {get;set;}

    public string Sinopsis {get;set;}

    public string ImagenSerie {get;set;}




    public Series()
{

}

public Series( int vIdSerie, string vNombre, int vAñoInicio, string vSinopsis, string vImagenSerie)
{
    IdSerie = vIdSerie;
    Nombre = vNombre;
    AñoInicio = vAñoInicio;
    Sinopsis = vSinopsis;
    ImagenSerie = vImagenSerie;
}
}

