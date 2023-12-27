
class HappyNumberChecker
    {
    private int _n = 0;
    public int Number
    {
        get { return _n; }
    }

    public HappyNumberChecker(int number)
    {
        _n = number;
    }

    
        public bool IsHappy()
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            while (_n != 1 && !seenNumbers.Contains(_n))
            {
                seenNumbers.Add(_n);
                _n = GetNextSumOfSquares(_n);
            }

            return _n == 1;
        }

        private int GetNextSumOfSquares(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit * digit;
                num /= 10;
            }

            return sum;
        }
        /*
        static void Main()
        {
            HappyNumberChecker checker = new HappyNumberChecker(19);
                
            // Example usage:
            
            bool result = checker.IsHappy();

            if (result)
            {
                Console.WriteLine($"{checker.Number} is a happy number.");
            }
            else
            {
                Console.WriteLine($"{checker.Number} is not a happy number.");
            }
        }
        */
    }


