using System;

namespace MyApp
{
    public class VucutKitleEndeksi
    {
        public static string Bmi(double agirlik, double boy)
        {
            double vucutKitleIndeksi = agirlik / (boy * boy);

            if (vucutKitleIndeksi <= 18.5)
                return "Underweight";
            else if (vucutKitleIndeksi <= 25)
                return "Normal";
            else if (vucutKitleIndeksi <= 30)
                return "Overweight";

            return "Obese";
        }
    }

    public class Swapper
    {
        public object[] Arguments { get; private set; }

        public Swapper(object[] args)
        {
            Arguments = args;
        }

        public void SwapValues()
        {
            object[] args = new[] { Arguments[0], Arguments[1] };

            object temp = Arguments[0];
            Arguments[0] = Arguments[1];
            Arguments[1] = temp;
        }
    }

    public class Ball
    {
        public string ballType { get; set; }

        /*
                public Ball()
                {
                    ballType = "regular";
                }*/

        public Ball(string ballType = "regular")
        {
            this.ballType = ballType;
        }
    }

    public class Cube
    {
        private int _side;
        public int Side { get { return _side; } set { _side = Math.Abs(value); } }

        public int Volume { get; private set; }
        public int Surface { get; private set; }

        public Cube(int s)
        {
            Side = s;
            if (Side == 2)
                Side = 3;
            Volume = Convert.ToInt32(Math.Pow(Side, 3));
            Surface = Convert.ToInt32(6 * Math.Pow(Side, 2));
        }

        public Cube() { }
    }

    public class Person
    {
        public Person(string firstName = "John", string lastName = "Doe", int age = 0, string gender = "Male")
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string SayFullName() { return FirstName + " " + LastName; }

        public static string GreetExtraTerrestrials(string raceName) { return "Welcome to Planet Earth " + raceName; }

    }
    public class Guesser
    {
        private int number;
        private int lives;

        public Guesser(int number, int lives)
        {
            this.number = number;
            this.lives = lives;
        }

        public bool Guess(int n)
        {
            if (lives <= 0)
                throw new System.Exception("Hiç hak kalmadı");

            if (number != n)
            {
                lives -= 1;
                return false;
            }

            return true;
        }
    }
}