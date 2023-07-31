namespace Dominio;

public class Provincia
{
    public int IdProvincia { get; set; }
    public string NombreProvincia { get; set; }
    public int RegionId { get; set; }
    public Region  Region { get; set; }
    public List<Persona>  Personas { get; set; }
}