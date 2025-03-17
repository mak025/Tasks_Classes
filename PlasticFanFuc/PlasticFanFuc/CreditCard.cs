using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plastic_fantastic
{
    /// <summary>
    /// Repræsenterer et kreditkort med kortnummer, korttype, kreditgrænse og kortindehaver.
    /// Understøtter flere konstruktører for fleksibel instansiering.
    /// </summary>
    public class CreditCard
    {
        /// <summary>
        /// Kortnummeret på kreditkortet.
        /// </summary>
        public string CardNumber { get; }

        /// <summary>
        /// Kreditkortets type (f.eks. Visa, MasterCard, American Express).
        /// </summary>
        public string CardType { get; }

        /// <summary>
        /// Kreditgrænsen på kortet.
        /// </summary>
        public double CreditLimit { get; }

        /// <summary>
        /// Kortindehaverens navn.
        /// </summary>
        public string CardholderName { get; }

        /// <summary>
        /// Privat konstruktør, der initierer kortnummeret.
        /// Bruges internt til at kæde konstruktører sammen.
        /// </summary>
        /// <param name="cardNumber">Kortnummeret.</param>
        private CreditCard(string cardNumber)
        {
            CardNumber = cardNumber;
        }

        /// <summary>
        /// Initialiserer et kreditkort med kortnummer og korttype.
        /// </summary>
        /// <param name="cardNumber">Kortnummeret.</param>
        /// <param name="cardType">Kreditkortets type (f.eks. Visa, MasterCard).</param>
        public CreditCard(string cardNumber, string cardType) : this(cardNumber)
        {
            CardType = cardType;
            CreditLimit = 0; // Standard værdi
        }

        /// <summary>
        /// Initialiserer et kreditkort med kortnummer og kreditgrænse.
        /// </summary>
        /// <param name="cardNumber">Kortnummeret.</param>
        /// <param name="creditLimit">Kreditgrænsen på kortet.</param>
        public CreditCard(string cardNumber, double creditLimit)
            : this(cardNumber) // Kæder til den første konstruktør
        {
            CreditLimit = creditLimit;
        }

        /// <summary>
        /// Initialiserer et kreditkort med kortnummer, korttype og kreditgrænse.
        /// </summary>
        /// <param name="cardNumber">Kortnummeret.</param>
        /// <param name="cardType">Kreditkortets type.</param>
        /// <param name="creditLimit">Kreditgrænsen.</param>
        public CreditCard(string cardNumber, string cardType, double creditLimit)
            : this(cardNumber, cardType)
        {
            CreditLimit = creditLimit;
        }

        /// <summary>
        /// Initialiserer et kreditkort med kortnummer, korttype, kreditgrænse og kortindehaverens navn.
        /// </summary>
        /// <param name="cardNumber">Kortnummeret.</param>
        /// <param name="cardType">Kreditkortets type.</param>
        /// <param name="creditLimit">Kreditgrænsen.</param>
        /// <param name="cardholderName">Navnet på kortindehaveren.</param>
        public CreditCard(string cardNumber, string cardType, double creditLimit, string cardholderName)
            : this(cardNumber, cardType, creditLimit) // Kæder til den tredje konstruktør
        {
            CardholderName = cardholderName;
        }

        /// <summary>
        /// Returnerer en strengrepræsentation af kreditkortet.
        /// </summary>
        /// <returns>En beskrivelse af kreditkortet inklusiv kortnummer, type, kreditgrænse og kortindehaver.</returns>
        public override string ToString()
        {
            return $"Card Number: {CardNumber}, Type: {CardType}, Limit: {CreditLimit} kr, Holder: {CardholderName}";
        }
    }
}