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
    class Question
    {
        //The first number in the equation.
        int a;

        //The operator in the equation.
        int op;

        //The second number in the equation.
        int b;

        //The answer to the equation.
        float x;

        /// <summary>
        /// The Constructor
        /// </summary>
        /// <param name="A">The first number in the equation.</param>
        /// <param name="Operator">The operator in the equation.</param>
        /// <param name="B">The second number in the equation.</param>
        public Question(int A, int Operator, int B)
        {
            //Set the questions vaiables.
            this.a = A;
            this.op = Operator;
            this.b = B;
        }

        public void Solve()
        {
            switch (op)
            {
                // Add +
                case 0:
                    x = a + b;
                    break;

                // Minus -
                case 1:
                    x = a - b;
                    break;

                // Times *
                case 2:
                    x = a * b;
                    break;

                // Divide /
                case 3:
                    x = a / b;
                    break;
            }
        }
    }
}
