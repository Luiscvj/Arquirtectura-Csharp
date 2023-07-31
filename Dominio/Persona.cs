namespace Dominio;

public class Persona
{
    public int IdPersona { get; set; }
    public string NombrePersona { get; set; }
    public string ApellidoPersona { get; set; }
    public int EdadaPersona { get; set; }
    public int ProvinciaId { get; set; }
    public Provincia Provincia { get; set; }
    public int TipoPersonaId { get; set; }
    public TipoPersona TipoPersona { get; set; }

}