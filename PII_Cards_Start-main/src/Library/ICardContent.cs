namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa un contenido que puede imprimirse.
    /// </summary>
    public interface ICardContent
    {
        /// <summary>
        /// Obtiene el texto que se debe imprimir.
        /// </summary>
        string GetTextToPrint();
    }
}