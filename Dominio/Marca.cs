namespace Dominio;
public class Marca
{
    public int IdMarca { get; set; }
    public string DescripcionMarca { get; set; }
    public List<Producto> Productos { get; set; }
}