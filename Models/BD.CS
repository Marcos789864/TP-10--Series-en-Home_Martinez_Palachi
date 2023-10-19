using System.Data.SqlClient;
using Dapper;

public static class BD
{
    private static string ConnectionString{get;set;}  = @"Server=. ; DataBase=BDSeries ; Trusted_Connection=True;";
    

    public static List<Series> ObtenerSeries()
    {
        string sql = "";
        List<Series> Series = new List<Series>();
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            sql = "Select * from Series";
            Series = db.Query<Series>(sql).ToList();
        }
        return Series;
    }

    public static List<string> Sinopsis(int IdSerie)
    {
        string sql = "";
        string List<string> Sinopsis = new List<string>;
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            sql = "Select Siniposis from Series where IdSerie = @vIdSerie";
            Sinopsis = db.Query<string>(sql,new{vIdSerie = IdSerie});
        }
        return Siniposis;
    } 

    public static List<Actores> ObtenerActores(int IdSerie)
    {
        string sql = "";
        List<Actores> Actores = new List<Actores>();
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            sql = "Select * from Actores where IdActor = @vIdActor";
            Actores = db.Query<Actores>(sql, new{vIdActor = IdSerie}).ToList();
        }
        return Actores;
    }

    public static  List<Temporadas> ObtenerTemporadas(int IdSerie)
    {
        string sql = "";
        List<Temporadas> Temporadas = new List<Temporadas>();
        using(SqlConnection db = new SqlConnection(ConnectionString))
        {
            sql = "Select * from Temporadas where IdTemporada = @vIdTemporada ";
            Temporadas = db.Query<Temporadas>(sql,new{vIdTemporada = IdSerie}).ToList();
        }
        return Temporadas;
    }
}