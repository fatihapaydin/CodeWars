namespace Test
{
    public class Tests
    {
        /*
        public static TheoryData<string, bool> TestIsUpperCaseVerisi = new TheoryData<string, bool>
        {
            {"c",false},
            {"C",true},
            {"Can",false},
            {"CAN",true},
            {"1",true},
            {"",true}
        };

        [Theory]
        [MemberData(nameof(TestIsUpperCaseVerisi))]
        public void TestIsUpperCase(string metin, bool beklenen)
        {
            bool aslinda = metin.IsUpperCase();
            aslinda.Should().Be(beklenen);
        }
        /*
        public static TheoryData<string, string> TestNoSpaceVerisi = new TheoryData<string, string>
        {
          {"8 j 8   mBliB8g  imjB8B8  jl  B","8j8mBliB8gimjB8B8jlB"},
          {"8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd","88Bifk8hB8BB8BBBB888chl8BhBfd"},
          {"8aaaaa dddd r     ","8aaaaaddddr"}
        };

        [Theory]
        [MemberData(nameof(TestNoSpaceVerisi))]
        public void TestNoSpace(string metin, string beklenen)
        {
            string aslinda = SpacesRemover.NoSpace(metin);
            aslinda.Should().Be(beklenen);
        }
        /*
        public static TheoryData<string[], string[]> TestFixTheMeerkatVerisi = new TheoryData<string[], string[]>
        {
             {new string[]{"3","2","1"},new string[]{"1","2","3"}}
        };

        [Theory]
        [MemberData(nameof(TestFixTheMeerkatVerisi))]
        public void TestFixTheMeerkat(string[] dizi, string[] beklenen)
        {
            string[] aslinda = Kata.FixTheMeerkat(dizi);
            aslinda.Should().BeEquivalentTo(beklenen);
        }
        /*
        public static TheoryData<string, string> TestAbbrevNameVerisi = new TheoryData<string, string>
        {
            {"Sam Harris","S.H"},
            {"patrick feeney","P.F"}
        };

        [Theory]
        [MemberData(nameof(TestAbbrevNameVerisi))]
        public void TestAbbrevName(string adi, string beklenen)
        {
            string aslinda = Kata.AbbrevName(adi);
            aslinda.Should().Be(beklenen);
        }

        /*
        public static TheoryData<string, string> TestUpdateLightVerisi = new TheoryData<string, string>
        {
            {"green","yellow"},
            {"yellow","red"},
            {"red","green"}
        };

        [Theory]
        [MemberData(nameof(TestUpdateLightVerisi))]
        public void TestUpdateLight(string simdikiRenk, string sonrakiRenkBeklenen)
        {
            string aslinda = Kata.UpdateLight(simdikiRenk);
            aslinda.Should().Be(sonrakiRenkBeklenen);
        }
        

        public static TheoryData<object[], object[]> IsVowTestVerisi = new TheoryData<object[], object[]>
        {
          {new object[]{1,2,3},new object[]{1,2,3}}
        };

        [Theory]
        [MemberData(nameof(IsVowTestVerisi))]
        public void TestIsVow(object[] dizi, object[] beklenenDizi)
        {
            var aslinda = Problems.IsVow(dizi);
            aslinda.Should().BeEquivalentTo(beklenenDizi);
        }

        public static TheoryData<string, string> TestRemoveExclamationMarksVerisi = new TheoryData<string, string>
        {
            {"",""},
            {"!",""},
            {"!!",""},
            {"Hi!","Hi"},
            {"!?!","?"}
        };

        [Theory]
        [MemberData(nameof(TestRemoveExclamationMarksVerisi))]
        public void TestRemoveExclamationMarks(string metin, string beklenen)
        {
            string aslinda = Problems.RemoveExclamationMarks(metin);
            aslinda.Should().Be(beklenen);
        }

        public static TheoryData<string, bool> IsDigitTestVerisi = new TheoryData<string, bool>
        {
           {"3",true},
           {"  3  ",true},
           {"-3.23",true},
           {"3-4",false},
           {"  3    5",false},
           {"zero",false}
        };

        [Theory]
        [MemberData(nameof(IsDigitTestVerisi))]
        public void TestIsDigit(string sayiAdayi, bool beklenen)
        {
            bool aslinda = Problems.IsDigit(sayiAdayi);
            aslinda.Should().Be(beklenen);
        }


        public static TheoryData<object[], int, object[]> TakeFirstElementsTestVerisi = new TheoryData<object[], int, object[]>
        {
           {null,1,new object[]{}},
           {new object[] { 'a', 'b', 'c', 'd', 'e' },0,new object[]{}},
           {new object[] { 'a', 'b', 'c', 'd', 'e' },2,new object[]{'a','b'}},
           {new object[] { 'a', 'b', 'c', 'd', 'e' },20,new object[]{ 'a', 'b', 'c', 'd', 'e' }},
        };
        [Theory]
        [MemberData(nameof(TakeFirstElementsTestVerisi))]
        public void TestTakeFirstElements(object[] dizi, int sonIndeks, object[] beklenenDizi)
        {
            object[] aslinda = Problems.TakeFirstElements(dizi, sonIndeks);
            aslinda.Should().BeEquivalentTo(beklenenDizi);
        }

        public static TheoryData<int, int, int> MangoTestVerisi = new TheoryData<int, int, int>
        {
            {3,3,6},
            {9,5,30}
        };
        [Theory]
        [MemberData(nameof(MangoTestVerisi))]
        public void TestMango(int adet, int birimFiyat, int beklenenToplamFiyat)
        {
            int aslinda = Problems.Mango(adet, birimFiyat);
            aslinda.Should().Be(beklenenToplamFiyat);
        }


        public static TheoryData<Ball, string> TestVerisi = new TheoryData<Ball, string>
        {
          {new Ball(),"regular"},
          {new Ball("naber"),"naber"}
        };

        [Theory]
        [MemberData(nameof(TestVerisi))]
        public void TestBall(Ball ball, string beklenenBallType)
        {
            ball.ballType.Should().Be(beklenenBallType);
        }

        [Theory]
        [InlineData(new[] { "Germany", "Ukraine" }, new[] { 2, 0 }, "At match Germany - Ukraine, Germany won!")]
        [InlineData(new[] { "Belgium", "Italy" }, new[] { 0, 2 }, "At match Belgium - Italy, Italy won!")]
        [InlineData(new[] { "Portugal", "Iceland" }, new[] { 1, 1 }, "At match Portugal - Iceland, teams played draw.")]
        public void TestUefaEuro2016(string[] teams, int[] scores, string beklenen)
        {
            string aslinda = Problems.UefaEuro2016(teams, scores);
            aslinda.Should().Be(beklenen);
        }

        [Theory]
        [InlineData(5, new int[] { 0, 1, 2, 3, 4 })]
        public void TestArr(int uzunluk, int[] beklenen)
        {
            int[] aslinda = Problems.Arr(uzunluk);
            aslinda.Should().BeEquivalentTo(beklenen);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 11)]
        [InlineData(12, 1100)]
        public void TestToBinary(int sayi, int beklenen)
        {
            int aslinda = Problems.ToBinary(sayi);
            aslinda.Should().Be(beklenen);
        }

        [Theory]
        [InlineData(1, "$1.00")]
        [InlineData(2.5, "$2.50")]
        public void TestFormatMoney(double amount, string beklenen)
        {
            var aslinda = Problems.FormatMoney(amount);
            aslinda.Should().Be(beklenen);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(10450, 1045)]
        [InlineData(10450000, 1045)]
        [InlineData(10451, 10451)]
        [InlineData(-1525, -1525)]
        [InlineData(-15250, -1525)]
        [InlineData(-1525000000, -1525)]
        public void TestNoBoringZeros(int sayi, int beklenen)
        {
            var aslinda = Problems.NoBoringZeros(sayi);
            aslinda.Should().Be(beklenen);
        }

        [Theory]
        [InlineData(20, "Excellent", 4)]
        [InlineData(26.95, "good", 3)]
        public void TestCalculateTip(double amount, string rating, int beklenen)
        {
            var aslinda = Problems.CalculateTip(amount, rating);
            aslinda.Should().Be(beklenen);
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "I\n I")]
        [InlineData(3, "I\n I\n  I")]
        [InlineData(4, "I\n I\n  I\n   I")]
        public void TestDrawStairs(int uzunluk, string beklenen)
        {
            string aslinda = Problems.DrawStairs(uzunluk);
            aslinda.Should().Be(beklenen);
        }


        [Theory]
        [InlineData("Hi!", 1, "Hi")]
        [InlineData("Hi!", 100, "Hi")]
        [InlineData("Hi!!!", 1, "Hi!!")]
        [InlineData("Hi!!!", 100, "Hi")]
        [InlineData("!Hi", 1, "Hi")]
        [InlineData("!Hi!", 1, "Hi!")]
        [InlineData("!Hi!", 100, "Hi")]
        [InlineData("!!!Hi !!hi!!! !hi", 1, "!!Hi !!hi!!! !hi")]
        [InlineData("!!!Hi !!hi!!! !hi", 3, "Hi !!hi!!! !hi")]
        [InlineData("!!!Hi !!hi!!! !hi", 5, "Hi hi!!! !hi")]
        [InlineData("!!!Hi !!hi!!! !hi", 100, "Hi hi hi")]
        public void TestRemove(string s, int n, string beklenen)
        {
            string aslinda = Problems.Remove(s, n);
            aslinda.Should().Be(beklenen);
        }

        [Theory]
        [InlineData("Hi!", "H!!")]
        [InlineData("!Hi! Hi!", "!H!! H!!")]
        [InlineData("aeiou", "!!!!!")]
        [InlineData("ABCDE", "!BCD!")]
        public void TestTumSesliHarfleriUnlemIsaretiIleDegistir(string kelime, string beklenen)
        {
            var aslinda = Problems.TumSesliHarfleriUnlemIsaretiIleDegistir(kelime);
            aslinda.Should().Be(beklenen);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(23, 15)]
        public void TestHotpo(uint n, uint beklenen)
        {
            var aslinda = Problems.Hotpo(n);
            aslinda.Should().Be(beklenen);
        }


        [Theory]
        [InlineData("hello", "hll")]
        [InlineData("how are you today?", "hw r y tdy?")]
        [InlineData("complain", "cmpln")]
        [InlineData("never", "nvr")]
        public void Hello(string input, string expected)
        {
            var actual = Problems.VowelRemover(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50, false)]
        [InlineData(100, "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up.")]
        [InlineData(150, "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up.")]
        public void PlayerRankUp(int points, object expected)
        {
            var actual = Problems.PlayerRankUp(points);

            Assert.True(actual.GetType() == expected.GetType());

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { -10, -5, -5, 0 }, -5)]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 0 }, 0)]
        [InlineData(new[] { 1, 3, 5, 10 }, 4)]
        public void FindAverage(int[] nums, int expected)
        {
            var actual = Problems.FindAverage(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abc", 3)]
        [InlineData("abcABC123", 3)]
        [InlineData("abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~", 3)]
        [InlineData("ABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~", 0)]
        [InlineData("abcdefghijklmnopqrstuvwxyz", 26)]
        public void LowercaseCountCheck(string s, int expected)
        {
            var actual = Problems.LowercaseCountCheck(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(100, 150, 250)]
        [InlineData(199, 58, 1)]
        public void Sum(byte a, byte b, byte expected)
        {
            var actual = Problems.Sum(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(-5, 5)]
        [InlineData(0, 0)]
        public void CubeTest(int side, int expected)
        {
            Kup cube = side != 0 ? new Kup(side) : new Kup();

            var actual = cube.GetSide();

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new double[] { 4, 6 }, new double[] { 12, 4 }, new double[] { 10, 10 }, new double[] { 8.6667, 6.6667 })]
        [InlineData(new double[] { 4, 2 }, new double[] { 12, 2 }, new double[] { 6, 10 }, new double[] { 7.3333, 4.6667 })]
        public void BarTriang(double[] x, double[] y, double[] z, double[] expected)
        {
            var actual = Problems.BarTriang(x, y, z);

            for (int i = 0; i < x.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Theory]
        [InlineData(new int[] { 19, 3, 20, 3 }, "0")]
        [InlineData(new int[] { 7, 2, 7, 4 }, "undefined")]
        [InlineData(new int[] { 10, 50, 30, 150 }, "5")]
        [InlineData(new int[] { 15, 45, 12, 60 }, "-5")]
        [InlineData(new int[] { 10, 20, 20, 80 }, "6")]
        [InlineData(new int[] { -10, 6, -10, 3 }, "undefined")]
        public void Slope(int[] array, string expected)
        {
            var actual = Problems.Slope(array);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 1.23, 5.65)]
        [InlineData(8, 2.5, 18.40)]
        [InlineData(5, 5.6, 27.50)]
        public void FuelPrice(double litres, double pricePerLitre, double expected)
        {
            var actual = Problems.FuelPrice(litres, pricePerLitre);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new object[] { }, "")]
        [InlineData(new object[] { 2, 4, 5, 2 }, "2,4,5,2")]
        [InlineData(new object[] { "1", "2", "3", "4" }, "1,2,3,4")]
        [InlineData(new object[] { new object[] { "hello", "this", "is", "an", "array!" }, "a", "b", "c", "d", "e!" }, "hello,this,is,an,array!,a,b,c,d,e!")]
        public void PrintArray(object[] array, string expected)
        {
            var actual = Problems.PrintArray(array);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4.659725356, 4.66)]
        public void TwoDecimalPlaces(double number, double expected)
        {
            var actual = Problems.TwoDecimalPlaces(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, "a")]
        [InlineData(3, "c")]
        [InlineData(10, "z")]
        [InlineData(20, "z")]
        [InlineData(30, "z")]
        [InlineData(18, "g")]
        [InlineData(28, "g")]
        [InlineData(12, "b")]
        [InlineData(2, "b")]
        [InlineData(7, "f")]
        public void DuckDuckGoose(int index, string expected)
        {
            var exampleNames = new string[] { "a", "b", "c", "d", "c", "e", "f", "g", "h", "z" };
            var players = exampleNames.Select(x => new Player(x)).ToArray();

            var actual = Problems.DuckDuckGoose(players, index);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abc", "z", "zzz")]
        [InlineData("", "z", "")]
        [InlineData("abc", "", "")]
        [InlineData("_3ebzgh4", "&", "&&&&&&&&")]
        [InlineData("//case", " ", "      ")]
        public void Contamination(string text, string character, string expected)
        {
            var actual = Problems.Contamination(text, character);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("black", false, "white")]
        [InlineData("black", true, "black")]
        [InlineData("white", false, "black")]
        [InlineData("white", true, "white")]
        public void WhoseMove(string lastPlayer, bool win, string expected)
        {
            var actual = Problems.WhoseMove(lastPlayer, win);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddExtra()
        {
            List<int> listOfNumbers = new List<int>() { 1, 2, 2, 2, 4, 3, 4, 5, 6, 7 };
            Assert.Equal((Problems.AddExtra(listOfNumbers)).Count, listOfNumbers.Count + 1);
        }

        [Theory]
        [InlineData(1, "It's Odious!")]
        [InlineData(2, "It's Odious!")]
        [InlineData(3, "It's Evil!")]
        public void Evil(int n, string expected)
        {
            var actual = Problems.Evil(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12345, 5, "Not a string")]
        [InlineData(12345.5, 5, "Not a string")]
        [InlineData("Hi", 3, "HiHiHi")]
        [InlineData("Hi ", 3, "Hi Hi Hi ")]
        [InlineData("**", 3, "******")]
        public void RepeatString(object toRepeat, int n, string expected)
        {
            var actual = Problems.RepeatString(toRepeat, n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new string[] { "John", "Smith" }, "Phoenix", "Arizona", "Hello, John Smith! Welcome to Phoenix, Arizona!")]
        [InlineData(new string[] { "John", "Smith", "Junior" }, "Phoenix", "Arizona", "Hello, John Smith Junior! Welcome to Phoenix, Arizona!")]
        public void SayHello(string[] name, string city, string state, string expected)
        {
            var actual = Problems.SayHello(name, city, state);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 'F')]
        [InlineData(1.1, 'F')]
        [InlineData(0.9, 'A')]
        [InlineData(0.98, 'A')]
        [InlineData(0.89, 'B')]
        [InlineData(0.8, 'B')]
        [InlineData(0.79, 'C')]
        [InlineData(0.7, 'C')]
        [InlineData(0.69, 'D')]
        [InlineData(0.6, 'D')]
        [InlineData(0.59, 'F')]
        [InlineData(0.3, 'F')]
        [InlineData(0.1, 'F')]
        public void Grader(double score, char expected)
        {
            var actual = Problems.Grader(score);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("apple ban", new string[] { "apple 5", "ban 3" })]
        [InlineData("you will win", new string[] { "you 3", "will 4", "win 3" })]
        public void AddLength(string str, string[] expected)
        {
            var actual = Problems.AddLength(str);
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
        */
    }
}
