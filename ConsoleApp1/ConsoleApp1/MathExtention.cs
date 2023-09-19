namespace ConsoleApp1
{
    //    Create a function that outputs the result of a math expression in words.
    //Examples
    //wordedMath("One plus one") ➞ "Two"
    //wordedMath("zero Plus one") ➞ "One"
    //wordedMath("one minus one") ➞ "Zero"
    public class MathExtention
    {
        public double MapNumber(string number)
        {
            if (number.ToLower() == "one")
            {
                return 1;
            }
            else if (number.ToLower() == "two")
            {
                return 2;
            }
            else if (number.ToLower() == "three")
            {
                return 3;
            }
            else if (number.ToLower() == "four")
            {
                return 4;
            }
            else if (number.ToLower() == "five")
            {
                return 5;
            }
            else if (number.ToLower() == "six")
            {
                return 6;
            }
            else if (number.ToLower() == "seven")
            {
                return 7;
            }
            else if (number.ToLower() == "eight")
            {
                return 8;
            }
            else if (number.ToLower() == "nine")
            {
                return 9;
            }
            else
            {
                return 0;
            }
        }
        public class MathDictionary
        {
            public string FirstNumber { get; set; } = default!;
            public string SecondNumber { get; set; } = default!;
            public string Operator { get; set; } = default!;
        }
        public double WordedMath(string wordedMathSentence)
        {

            double result = DecoupleSentence(wordedMathSentence);


            return result;
        }

        public MathDictionary TranslateSentence(string wordedSentence)
        {
            var result = wordedSentence.Split(' ');

            return new MathDictionary { FirstNumber = result[0], SecondNumber = result[2], Operator = result[1] };
        }
        public double DecoupleSentence(string wordedSentence)
        {
            var result = TranslateSentence(wordedSentence);
            if (result.Operator.ToLower() == "plus")
            {
                return MapNumber(result.FirstNumber) + MapNumber(result.SecondNumber);
            }
            else if (result.Operator.ToLower() == "minus")
            {
                return MapNumber(result.FirstNumber) - MapNumber(result.SecondNumber);
            }
            else if (result.Operator.ToLower() == "divide")
            {
                return MapNumber(result.FirstNumber) / MapNumber(result.SecondNumber);
            }
            else if (result.Operator.ToLower() == "multiply")
            {
                return MapNumber(result.FirstNumber) * MapNumber(result.SecondNumber);
            }
            else
            {
                throw new InvalidOperationException("We Only Support Minus/Plus/Divide/Multiply Operation");
            }
        }
    }
}
