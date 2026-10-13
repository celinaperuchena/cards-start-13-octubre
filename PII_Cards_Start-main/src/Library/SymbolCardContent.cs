//------------------------------------------------------------------------------
// <copyright file="SymbolCardContent.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa el contenido de un naipe utilizando símbolos.
    /// </summary>
    public class SymbolCardContent : ICardContent
    {
        private Card card;

        /// <summary>
        /// Inicializa una nueva instancia de SymbolCardContent.
        /// </summary>
        /// <param name="card">El naipe a representar.</param>
        public SymbolCardContent(Card card)
        {
            this.card = card;
        }

        /// <summary>
        /// Obtiene el texto del naipe con símbolos.
        /// </summary>
        /// <returns>El naipe representado con símbolos.</returns>
        public string GetTextToPrint()
        {
            string value;

            switch (this.card.Rank)
            {
                case Rank.Ace:
                    value = "A";
                    break;
                case Rank.King:
                    value = "K";
                    break;
                case Rank.Queen:
                    value = "Q";
                    break;
                case Rank.Jack:
                    value = "J";
                    break;
                case Rank.Ten:
                    value = "10";
                    break;
                case Rank.Nine:
                    value = "9";
                    break;
                case Rank.Eight:
                    value = "8";
                    break;
                case Rank.Seven:
                    value = "7";
                    break;
                case Rank.Six:
                    value = "6";
                    break;
                case Rank.Five:
                    value = "5";
                    break;
                case Rank.Four:
                    value = "4";
                    break;
                case Rank.Three:
                    value = "3";
                    break;
                default:
                    value = "2";
                    break;
            }

            string symbol;

            switch (this.card.Suit)
            {
                case Suit.Hearts:
                    symbol = "♥";
                    break;
                case Suit.Diamonds:
                    symbol = "♦";
                    break;
                case Suit.Clubs:
                    symbol = "♣";
                    break;
                default:
                    symbol = "♠";
                    break;
            }

            return value + symbol;
        }
    }
}