using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instructor
{
    /// <summary>
    /// The Question Class
    /// </summary>
    public class Question
    {
        /// <summary>
        /// The first number in the question.
        /// </summary>
        public decimal a;

        /// <summary>
        /// The operator in the question.
        /// </summary>
        public int operatorIndex;

        /// <summary>
        /// The operator symbol.
        /// </summary>
        public string operatorSymbol;

        /// <summary>
        /// The second number in the question.
        /// </summary>
        public decimal b;

        /// <summary>
        /// The answer to the question.
        /// </summary>
        public decimal x;

        /// <summary>
        /// Whether the question was answered correctly.
        /// </summary>
        public bool correct = false;

        /// <summary>
        /// Whether the question has been answered.
        /// </summary>
        public bool answered = false;

        /// <summary>
        /// The Constructor
        /// </summary>
        /// <param name="A">The first number in the equation.</param>
        /// <param name="Operator">The operator in the equation.</param>
        /// <param name="B">The second number in the equation.</param>
        public Question(decimal A, int Operator, decimal B)
        {
            //Set the questions vaiables.
            this.a = A;
            this.operatorIndex = Operator;
            this.b = B;

            switch (Operator)
            {
                case 0:
                    //Set the questions symbol.
                    this.operatorSymbol = "+";
                    x = a + b;
                    break;
                case 1:
                    //Set the questions symbol.
                    this.operatorSymbol = "-";
                    x = a - b;
                    break;
                case 2:
                    //Set the questions symbol.
                    this.operatorSymbol = "x";
                    x = a * b;
                    break;
                case 3:
                    //Set the questions symbol.
                    char symbol = '\u00F7';
                    this.operatorSymbol = "" + symbol;
                    x = a / b;
                    break;
            }
        }
    }
}
