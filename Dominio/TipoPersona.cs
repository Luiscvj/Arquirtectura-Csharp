namespace Dominio;

public class TipoPersona
{
    public int IdPersona { get; set; }
    public string Descripcion { get; set; }
    public List<Persona> Personas { get; set; }
}