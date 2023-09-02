namespace Zoologico;

public class CaixaMagica<T>
{
    private T conteudo;

    public CaixaMagica(T item)
    {
        conteudo = item;
    }

    public T Abrir()
    {
        return conteudo;
    }
}