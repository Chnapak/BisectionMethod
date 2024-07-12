namespace BinarySearch
{
    internal class Calculation
    {
        // This program uses the Bisection method to find values of square roots of mainly irational numbers.
        // There are two methods iteration and recursion. Iteration is better because it can't crash easily.
        // It can find the square root of 2 in matter of twenty miliseconds.


        // Iteration
        public double BisectionLoop(double irregular)
        {
            double lower = 0;
            double upper = int.MaxValue;

            while(true)
            {
                
                Console.WriteLine((upper + lower) / 2);

                // If the average of the bounds is an overestimate, move upper to the average.
                if (Math.Pow((upper + lower) / 2, 2) > irregular)
                {
                    // If the difference is unnoticable, then return the average.
                    if ((upper + lower) / 2 == lower)
                    {
                        return (upper + lower) / 2;
                    }

                    upper = (upper + lower) / 2;
                }
                // If the average of the bounds is an underestimate, move lower to the average.
                else if ((Math.Pow(upper + lower, 2)) / 4 < irregular)
                {
                    // If the difference is unnoticable, then return the average.
                    if ((upper + lower) / 2 == upper)
                    {
                        return (upper + lower) / 2;
                    }

                    lower = (upper + lower) / 2;
                }
                // If the average is on point, then it is the square root.
                else
                {
                    Console.WriteLine((upper + lower) / 2);
                    return (upper + lower) / 2;
                }
            }
        }
        public double BisectionIteration(double irregular, double lower, double upper){
            

            // Similar logic and struture as the iteration function.
            Console.WriteLine((upper + lower) / 2);

            if (Math.Pow((upper+lower)/2, 2) > irregular)
            {
                return BisectionIteration(irregular, lower, (upper + lower) / 2);
            }
            else if ((Math.Pow(upper + lower, 2)) / 4 < irregular){
                return BisectionIteration(irregular, (upper + lower) / 2, upper);
            }
            else
            {
                return (upper + lower) / 2;
            }
        }
    }
}
