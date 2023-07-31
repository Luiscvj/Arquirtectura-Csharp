namespace Dominio;
public class Region
{
    public int IdRegion { get; set; }
    public string NombreRegion { get; set; }
    public int PaisId { get; set; }
    public Pais Pais { get; set; }
    public List<Provincia> Provincias { get; set; }

}