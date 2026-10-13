//------------------------------------------------------------------------------
// <copyright file="ConsolePrinter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Imprime contenidos en la consola.
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        /// <summary>
        /// Imprime un contenido en la consola.
        /// </summary>
        /// <param name="card">El contenido a imprimir.</param>
        public void PrintCard(ICardContent card)
        {
            ArgumentNullException.ThrowIfNull(card);
            Console.WriteLine(card.GetTextToPrint());
        }
    }
}