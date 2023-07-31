namespace Dominio;

public class Pais
{
    public int idPais { get; set; }
    public string NombrePais { get; set; }
    public List<Region> Regiones { get; set; }
}