//------------------------------------------------------------------------------
// <copyright file="FilePrinter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.IO;

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Imprime contenidos en un archivo.
    /// </summary>
    public class FilePrinter : IPrinter
    {
        /// <summary>
        /// Imprime un contenido en el archivo Card.txt.
        /// </summary>
        /// <param name="card">El contenido a imprimir.</param>
        public void PrintCard(ICardContent card)
        {
            ArgumentNullException.ThrowIfNull(card);
            File.WriteAllText("Card.txt", card.GetTextToPrint());
        }
    }
}