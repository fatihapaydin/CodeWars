using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyApp
{
    public static class Problems
    {
        public static string ToCsvText(int[][] array)
        {
            StringBuilder metin = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                metin.AppendLine(string.Join(",", array[i].Select(j => j.ToString())));
            }

            return metin.ToString().Remove(metin.Length - 1);
        }

        public static double FindAverage(double[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            return array.Average();
        }

        public static string Array(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || !s.Contains(","))
                return null;

            string[] sayilar = s.Split(",");

            if (sayilar.Length < 3)
                return null;

            string[] basSonAlinmisSayilar = sayilar.Skip(1).Take(sayilar.Length - 2).ToArray();

            return basSonAlinmisSayilar.Aggregate((a, b) => a + " " + b);
        }

        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            return arr1.Sum() + arr2.Sum();
        }

        public static object[] IsVow(object[] a)
        {
            char[] sesliler = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < a.Length; i++)
            {
                char siradaki = Convert.ToChar(a[i]);

                if (sesliler.Contains(siradaki))
                    a[i] = siradaki.ToString();
            }

            return a;
        }

        public static string RemoveExclamationMarks(string s)
        {
            string[] dizi = s.Split('!', StringSplitOptions.RemoveEmptyEntries);
            return dizi.Length == 0 ? "" : dizi.Aggregate((a, b) => a += b);
        }

        public static double basicOp(char operation, double value1, double value2)
        {
            double sonuc = 0;

            switch (operation)
            {
                case '+':
                    sonuc = value1 + value2;
                    break;
                case '-':
                    sonuc = value1 - value2;
                    break;
                case '*':
                    sonuc = value1 * value2;
                    break;
                case '/':
                    sonuc = value1 / value2;
                    break;
            }

            return sonuc;
        }

        public static int GetAverage(int[] marks)
        {
            return Convert.ToInt32(Math.Floor(marks.Average()));
        }

        public static bool Validate_hello(string greetings)
        {
            string[] alternatifMerhabalar = { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc" };

            return alternatifMerhabalar.Any(x => greetings.ToLower().Contains(x));
        }

        public static string MultiTable(int number)
        {
            StringBuilder carpimTablosu = new StringBuilder();

            for (int i = 1; i < 11; i++)
            {
                carpimTablosu.AppendLine(i + " * " + number + " = " + (i * number).ToString());
            }

            return carpimTablosu.ToString().Substring(0, carpimTablosu.Length - 1);
        }

        public static string CalculateAge(int birth, int yearTo)
        {
            string mesaj;
            int fark = Math.Abs(yearTo - birth);
            string yilIfade = fark == 1 ? "year" : "years";

            if (birth < yearTo)
            {
                mesaj = "You are " + fark.ToString() + " ";
                mesaj += yilIfade + " old.";
            }
            else if (birth == yearTo)
                mesaj = "You were born this very year!";
            else
            {
                mesaj = "You will be born in " + fark.ToString() + " ";
                mesaj += yilIfade + ".";
            }

            return mesaj;
        }

        public static int[] distinct(int[] a)
        {
            return a.Distinct().ToArray();
        }

        public static bool Feast(string beast, string dish)
        {
            return dish.StartsWith(beast[0]) && dish.EndsWith(dish[dish.Length - 1]);
        }

        public static List<int> FilterOddNumber(List<int> listOfNumbers)
        {
            return listOfNumbers.Where(x => x % 2 == 1).ToList();
        }

        public static bool All(int[] arr, Func<int, bool> fun)
        {
            return arr.All(fun);
        }

        public static bool IsDigit(string s)
        {
            if (s == null)
                return false;

            string temiz = s.Trim();
            double sayi;
            return double.TryParse(temiz, out sayi);
        }

        public static int[] GenerateRange(int min, int max, int step)
        {
            int siradaki = min;
            List<int> dizi = new List<int>();

            while (siradaki <= max)
            {
                dizi.Add(siradaki);
                siradaki += step;
            }

            return dizi.ToArray();
        }

        public static List<int> MultipleOfIndex(List<int> xs)
        {
            List<int> indeksinKatiOlanElemanlar = new List<int>();

            for (int i = 0; i < xs.Count; i++)
            {
                if (xs[i] % i == 0)
                    indeksinKatiOlanElemanlar.Add(xs[i]);
            }

            xs.Skip(1).Where((x, i) => x % (i + 1) == 0).ToList();

            return indeksinKatiOlanElemanlar;
        }

        public static object[] TakeFirstElements(object[] array, int n = 1)
        {
            if (array == null)
                return new object[] { };

            return array.Take(n).ToArray();
        }

        public static int[] PreFizz(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }

        public static int Mango(int quantity, int price)
        {
            int bedavaMangoSayisi = quantity / 3;

            return (quantity - bedavaMangoSayisi) * price;
        }

        public static double Converter(int mpg)
        {
            //"ali".Equals("Ali", StringComparison.OrdinalIgnoreCase);

            return mpg * 1.609344 / 4.54609188;
        }

        public static string TempleStrings(string obj, string feature)
        {
            return $"{obj} are {feature}";
        }
        public static bool LogicalCalc(bool[] array, string op)
        {
            switch (op)
            {
                case "AND":
                    return array.All(x => x);

                case "OR":
                    return array.Any(x => x);

                case "XOR":
                    bool netice = array[0];

                    for (int i = 1; i < array.Length; i++)
                    {
                        netice = netice ^ array[i];
                    }

                    //  array.Aggregate((x, y) => x ^ y);

                    return netice;
            }

            return false;
        }

        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            return numbers.Where(j => j % divisor == 0).ToArray();
        }

        public static string UefaEuro2016(string[] teams, int[] scores)
        {
            string ilkMetin = $"At match {teams[0]} - {teams[1]}, ";

            if (scores[0] == scores[1])
                return ilkMetin + "teams played draw.";

            int kazananIndeks = scores[0] > scores[1] ? 0 : 1;

            return ilkMetin + teams[kazananIndeks] + " won!";
        }

        public static string GetDrinkByProfession(string p)
        {
            Dictionary<string, string> zikkimlar = new Dictionary<string, string>(StringComparer.CurrentCultureIgnoreCase)
            {
              {"Jabroni","Patron Tequila"},
              {"School counselor","Anything with Alcohol"},
              {"Programmer","Hipster Craft Beer"},
              {"Bike gang member", "Moonshine"},
              {"Politician","Your tax dollars"},
              {"Rapper","Cristal"},
              {"any","Beer"}
            };

            return zikkimlar.Keys.Contains(p)
            ? zikkimlar[p]
            : zikkimlar["any"];
        }

        public static int NextId(int[] ids)
        {
            return ids.Count(j => ids.Count(x => x == j) == 1);
        }

        public static int[] Arr(int N)
        {
            return Enumerable.Range(0, N).ToArray();
        }

        public static int ToBinary(int n)
        {
            return int.Parse(Convert.ToString(n, 2));
        }

        public static string FormatMoney(double amount)
        {
            return string.Format("{0:C2}", amount);
        }

        public static double SakuraFall(double v)
        {
            return v > 0 ? 400.0d / v : 0;
        }

        public static double? ParseF(object s = null)
        {
            double sayi;

            if (double.TryParse(s == null ? "" : s.ToString(), out sayi))
                return sayi;

            return null;
        }


        public static string Greet(string language)
        {
            Dictionary<string, string> merhabalar = new Dictionary<string, string>
            {
                {"english", "Welcome"},
                {"czech", "Vitejte"},
                {"danish", "Velkomst"},
                {"dutch", "Welkom"},
                {"estonian", "Tere tulemast"},
                {"finnish", "Tervetuloa"},
                {"flemish", "Welgekomen"},
                {"french", "Bienvenue"},
                {"german", "Willkommen"},
                {"irish", "Failte"},
                {"italian", "Benvenuto"},
                {"latvian", "Gaidits"},
                {"lithuanian", "Laukiamas"},
                {"polish", "Witamy"},
                {"spanish", "Bienvenido"},
                {"swedish", "Valkommen"},
                {"welsh", "Croeso"}
            };

            return merhabalar.ContainsKey(language.ToLower())
            ? merhabalar[language.ToLower()]
            : merhabalar["english"];
        }

        public static bool ArrayMadness(int[] a, int[] b)
        {
            int kareToplami = a.Sum(x => x * x);
            int kupToplami = b.Sum(j => j * j * j);

            return kareToplami > kupToplami;
        }

        public static int[] DifferenceInAges(int[] ages)
        {
            int enKucuk = ages.Min();
            int enBuyuk = ages.Max();

            return new int[] { enKucuk, enBuyuk, enBuyuk - enKucuk };
        }

        public static string TripleTrouble(string one, string two, string three)
        {
            string netice = "";

            for (int i = 0; i < one.Length; i++)
            {
                netice += one[i].ToString() + two[i].ToString() + three[i].ToString();
            }

            return netice;
        }

        public static int NoBoringZeros(int n)
        {
            if (n == 0)
                return 0;

            while (n % 10 == 0)
            {
                n = n / 10;
            }

            return n;
        }


        public static void main(params string[] parametreler)
        {
            System.Console.WriteLine("Hello World! \n");
        }


        public static int[] MonkeyCount(int n)
        {
            int[] dizi = new int[n];

            for (int i = 1; i < n + 1; i++)
            {
                dizi[i - 1] = i;
            }
            return dizi;
        }

        public static int CalculateTip(double amount, string rating)
        {
            int oran;

            switch (rating.ToLower())
            {
                case "excellent":
                    oran = 20;
                    break;
                case "great":
                    oran = 15;
                    break;
                case "good":
                    oran = 10;
                    break;
                case "poor":
                    oran = 5;
                    break;
                case "terrible":
                    oran = 0;
                    break;
                default:
                    oran = -1;
                    break;
            }

            return oran > -1 ? Convert.ToInt32(Math.Ceiling(oran * amount / 100)) : -1;
        }


        public static string DrawStairs(int n)
        {
            string sonuc = "";

            for (int i = 1; i <= n; i++)
            {
                sonuc += "I".PadLeft(i, ' ') + "\n";
            }
            return sonuc.Substring(0, sonuc.Length - 1);
        }
        public static string Quote(string fighter = "")
        {
            if (fighter.ToUpper() == "GEORGE SAINT PIERRE")
                return "I am not impressed by your performance.";
            else if (fighter.ToUpper() == "CONOR MCGREGOR")
                return "I'd like to take this chance to apologize.. To absolutely NOBODY!";
            else
                return "";
        }


        public static string Interpret(string code)
        {
            if (code == "H")
                return "Hello World!";
            else if (code == "Q")
                return "Q";
            else if (code == "9")
            {
                string metin = "";

                for (int i = 99; i > 0; i--)
                {
                    if (i != 1)
                        metin += i + " bottles of beer on the wall, 99 bottles of beer. \nTake one down and pass it around, " + (i - 1).ToString() + " bottles of beer on the wall. \n";
                    else
                        metin += i + " bottle of beer on the wall, " + i + " bottle of beer. \nTake one down and pass it around, no more bottles of beer on the wall. \nNo more bottles of beer on the wall, no more bottles of beer. \nGo to the store and buy some more, 99 bottles of beer on the wall.";
                }

                return metin;
            }
            else
                return null;
        }

        public static bool IsPalindrome(object line)
        {
            return line.ToString() == string.Join("", line.ToString().Reverse());
        }

        public static string Remove(string s, int n)
        {
            const char karakter = '!';

            if (!s.Contains(karakter) || n < 1)
                return s;

            int sayac = 0;
            int baslangicIndeksi = 0;

            while (sayac < n)
            {
                int indeks = s.IndexOf(karakter, baslangicIndeksi);

                if (indeks < 0)
                    break;

                s = s.Remove(indeks, 1);

                baslangicIndeksi = indeks;
                sayac++;
            }

            return s;
        }

        public static bool None(int[] arr, Func<int, bool> fun)
        {
            return arr.Count(fun) == 0;
        }
        public static bool Any(int[] arr, Func<int, bool> fun)
        {
            return arr.Any(fun);
        }

        public static bool Include(int[] arr, int item)
        {
            return arr.Contains(item);
        }

        public static string TumSesliHarfleriUnlemIsaretiIleDegistir(string s)
        {
            var sesliHarfler = "aeiouAEIOU";

            return new string(s.Select(j => sesliHarfler.Contains(j) ? '!' : j).ToArray());
        }


        public static double Calculator(double a, double b, char op)
        {
            double cevap = 0;

            switch (op)
            {
                case '+':
                    cevap = a + b;
                    break;

                case '-':
                    cevap = a - b;
                    break;

                case '*':
                    cevap = a * b;
                    break;

                case '/':
                    if (b == 0)
                        throw new ArgumentException("Sıfıra bölme yapılamaz");
                    cevap = a / b;
                    break;

                default:
                    throw new ArgumentException("Geçersiz operatör");
            }

            return cevap;
        }
        public static uint Hotpo(uint n)
        {
            uint times = 0;

            return HotpoDevam(n, ref times);
        }

        public static uint HotpoDevam(uint n, ref uint times)
        {
            if (n == 1)
                return times;

            times++;

            if (n % 2 == 0)
                n = n / 2;
            else
                n = 3 * n + 1;

            return HotpoDevam(n, ref times);
        }

        public static bool ValidateCode(string code)
        {
            //Regex.IsMatch(code, "^[1-3]");

            char[] gecerliKarakterler = new char[] { '1', '2', '3' };
            return gecerliKarakterler.Any(j => code.StartsWith(j));
        }

        public static string AliasGen(string fName, string lName)
        {
            // class is partial,
            // FirstName and Surname dictionaries are defined in other part of partial
            // you can access them directly here

            if (char.IsLetter(fName[0]) && char.IsLetter(lName[0]))
                return fName + " " + lName;

            return "Your name must start with a letter from A - Z.";

        }
        public static string VowelRemover(string input)
        {
            string vowels = "aeiou";

            return new string(input.Where(j => !vowels.Contains(j)).ToArray());
        }

        public static object PlayerRankUp(int points)
        {
            if (points >= 100)
                return "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up.";
            else
                return false;
        }

        public static int FindAverage(int[] nums)
        {
            return nums.Sum() / nums.Length;
        }

        public static int LowercaseCountCheck(string s)
        {
            return s.Count(x => Char.IsLower(x));
        }

        public static byte Sum(byte a, byte b)
        {
            return (byte)(a + b);
        }

        public static double[] BarTriang(double[] x, double[] y, double[] z)
        {
            var result = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                result[i] = Math.Round((x[i] + y[i] + z[i]) / 3, 4);
            }

            return result;
        }

        public static string Slope(int[] points)
        {
            if (points[0] == points[2])
                return "undefined";
            else
                return ((points[1] - points[3]) / (points[0] - points[2])).ToString();
        }

        public static string Leo(int oscar)
        {
            if (oscar == 88)
                return "Leo finally won the oscar! Leo is happy";
            else if (oscar == 86)
                return "Not even for Wolf of wallstreet?!";
            else if (oscar > 88)
                return "Leo got one already!";
            else return "When will you give Leo an Oscar?";
        }

        public static double FuelPrice(double litres, double pricePerLitre)
        {
            double tenzilat = ((int)(litres / 2)) * 5;

            if (tenzilat > 25)
                tenzilat = 25;

            return Math.Round(litres * (pricePerLitre - tenzilat / 100), 2);
        }

        public static string PrintArray(object[] array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] is object[])
                {
                    result += PrintArray((object[])array[i]);
                }
                else
                {
                    result += array[i].ToString();
                }
                if (i != array.Length - 1)
                    result += ",";
            }

            return result;
        }

        public static double TwoDecimalPlaces(double number)
        {
            return Math.Round(number, 2);
        }

        public static string DuckDuckGoose(Player[] players, int goose)
        {
            var targetIndex = (goose - 1) % players.Length;

            return players[targetIndex].Name;
        }

        public static string Contamination(string text, string character)
        {
            if (text == string.Empty || character == string.Empty)
                return "";

            var select = text.Select(x => Convert.ToChar(character)).ToArray();
            return new string(select);
        }

        public static string WhoseMove(string lastPlayer, bool win)
        {
            if (win)
                return lastPlayer;
            else
                return lastPlayer == "black" ? "white" : "black";
        }
        public static List<int> AddExtra(List<int> listOfNumbers)
        {
            var list = listOfNumbers.Select(x => x).ToList();
            list.Add(5);
            return list;
        }

        public static string Evil(int n)
        {
            var binary = Convert.ToString(n, 2);
            var count = binary.Count(x => x == '1');
            return count % 2 == 0 ? "It's Evil!" : "It's Odious!";
        }
        public static string RepeatString(object toRepeat, int n)
        {
            if (!(toRepeat is string))
                return "Not a string";

            var result = "";
            for (int i = 0; i < n; i++)
            {
                result += toRepeat.ToString();
            }
            return result;
        }

        public static string SayHello(string[] name, string city, string state)
        {
            return "Hello, " + string.Join(" ", name) + "! Welcome to " + city + ", " + state + "!";
        }

        public static char Grader(double score)
        {
            if (score > 1 || score < 0.6)
                return 'F';
            else if (score >= 0.9)
                return 'A';
            else if (score >= 0.8)
                return 'B';
            else if (score >= 0.7)
                return 'C';
            else
                return 'D';
        }

        public static Dictionary<char, int> CharFreq(string message)
        {
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < message.Length; i++)
            {
                var item = message[i];

                if (!dict.ContainsKey(item))
                {
                    var count = message.Count(x => x == item);
                    dict.Add(item, count);
                }
            }

            return dict;
        }

        public static string[] AddLength(string str)
        {
            return str.Split().Select(x => x + " " + x.Length).ToArray();
        }


    }

    public class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }
    }

    public class Kup
    {
        private int Side;


        public int GetSide()
        {
            return this.Side;
        }

        public void SetSide(int s)
        {
            this.Side = s < 0 ? -s : s;
        }

        public Kup()
        {
        }

        public Kup(int side)
        {
            SetSide(side);
        }
    }


    public class Ghost
    {
        string color;

        public string GetColor() { return color; }

        public static string[] colors = { "white", "yellow", "purple", "red" };

        public void SetColor()
        {
            Random random = new Random();
            color = colors[random.Next(colors.Length)];
        }

        public Ghost()
        {
            SetColor();
        }

    }
}
