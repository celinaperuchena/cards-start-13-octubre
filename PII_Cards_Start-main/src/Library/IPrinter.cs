//------------------------------------------------------------------------------
// <copyright file="IPrinter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa una impresora de contenidos.
    /// </summary>
    public interface IPrinter
    {
        /// <summary>
        /// Imprime un contenido.
        /// </summary>
        /// <param name="card">El contenido a imprimir.</param>
        void PrintCard(ICardContent card);
    }
}