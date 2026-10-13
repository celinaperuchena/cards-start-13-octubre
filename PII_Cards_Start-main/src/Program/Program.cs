//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Ucu.Poo.Cards;

namespace Ucu.Poo.Exercise
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            // Creamos el as de picas.
            Card card = new Card(Rank.Ace, Suit.Spades);

            // Creamos el formato con símbolos.
            SymbolCardContent symbolCard = new SymbolCardContent(card);

            // Imprimimos los dos formatos en consola.
            Print(card, new ConsolePrinter());
            Print(symbolCard, new ConsolePrinter());

            // Combinamos ambos formatos para el archivo.
            CombinedCardContent bothFormats =
                new CombinedCardContent(card, symbolCard);

            Print(bothFormats, new FilePrinter());
        }

        /// <summary>
        /// Imprime el contenido con la impresora indicada.
        /// </summary>
        /// <param name="content">El contenido a imprimir.</param>
        /// <param name="printer">La impresora a utilizar.</param>
        private static void Print(ICardContent content, IPrinter printer)
        {
            printer.PrintCard(content);
        }

        /// <summary>
        /// Combina dos contenidos para imprimirlos juntos.
        /// </summary>
        private sealed class CombinedCardContent : ICardContent
        {
            private ICardContent first;
            private ICardContent second;

            /// <summary>
            /// Inicializa una nueva instancia de la clase CombinedCardContent.
            /// </summary>
            /// <param name="first">El primer contenido.</param>
            /// <param name="second">El segundo contenido.</param>
            public CombinedCardContent(
                ICardContent first,
                ICardContent second)
            {
                this.first = first;
                this.second = second;
            }

            /// <summary>
            /// Obtiene los dos contenidos como texto.
            /// </summary>
            /// <returns>Ambos contenidos en líneas separadas.</returns>
            public string GetTextToPrint()
            {
                return this.first.GetTextToPrint()
                    + Environment.NewLine
                    + this.second.GetTextToPrint();
            }
        }
    }
}