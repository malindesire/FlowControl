namespace FlowControl
{
    internal class Visitor
    {
        private int _age;
        private readonly int _price;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }

        public int Price { get { return _price; } }

        public Visitor(int age)
        {
            _age = age;
            _price = GetPrice(age);
        }


        private static int GetPrice(int age)
        {
            if (age < 20 && age > 4)
            {
               return (int)PriceLevel.Youth;
            }
            else if (age > 64 && age <= 100)
            {
               return (int)PriceLevel.Senior;
            }
            else if (age < 5 || age > 100)
            {
               return (int)PriceLevel.Freebies;
            }
            else
            {
               return (int)PriceLevel.Regular;
            }
        }
    }
}
