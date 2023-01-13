using EncoraTest.Entity;
using EncoraTest.Services;

namespace EncoraTest.Tests
{
    public class StringServiceTest
    {
        private readonly StringService _service;

        public StringServiceTest() 
        {
            _service = new StringService();    
        }

        [Fact]
        public void Test1()
        {
            //Arrange
            var input = new Input();
            input.Phrases = new List<string>();
            input.Quantity = 2;
            input.Phrases.Add("abaccadcc");
            input.Phrases.Add("xyzxy");

            //Act
            var result = _service.SortingOperation(input);

            //Assert
            Assert.Equal("ccccaaabd", result.Phrases[0]);
            Assert.Equal("xxyyz", result.Phrases[1]);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            var input = new Input();
            input.Phrases = new List<string>();
            input.Quantity = 10;
            input.Phrases.Add("dulgvgzwqg");
            input.Phrases.Add("gxtjtmtywr");
            input.Phrases.Add("hnlnxiupgt");
            input.Phrases.Add("gzjotckivp");
            input.Phrases.Add("dpwwsdptae");
            input.Phrases.Add("pcscpilknb");
            input.Phrases.Add("btvyhhmflf");
            input.Phrases.Add("artrtnqxcr");
            input.Phrases.Add("nrtcmcoadn");
            input.Phrases.Add("fkdsgnekft");

            //Act
            var result = _service.SortingOperation(input);

            //Assert
            Assert.Equal("gggdlquvwz", result.Phrases[0]);
            Assert.Equal("tttgjmrwxy", result.Phrases[1]);
            Assert.Equal("nnghilptux", result.Phrases[2]);
            Assert.Equal("cgijkoptvz", result.Phrases[3]);
            Assert.Equal("ddppwwaest", result.Phrases[4]);
            Assert.Equal("ccppbiklns", result.Phrases[5]);
            Assert.Equal("ffhhblmtvy", result.Phrases[6]);
            Assert.Equal("rrrttacnqx", result.Phrases[7]);
            Assert.Equal("ccnnadmort", result.Phrases[8]);
            Assert.Equal("ffkkdegnst", result.Phrases[9]);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            var input = new Input();
            input.Phrases = new List<string>();
            input.Quantity = 5;
            input.Phrases.Add("wzenwebuau");
            input.Phrases.Add("vokfxzynwl");
            input.Phrases.Add("neldfeyrxk");
            input.Phrases.Add("wqadfiodgs");
            input.Phrases.Add("ykiuvzfcbc");

            //Act
            var result = _service.SortingOperation(input);

            //Assert
            Assert.Equal("eeuuwwabnz", result.Phrases[0]);
            Assert.Equal("fklnovwxyz", result.Phrases[1]);
            Assert.Equal("eedfklnrxy", result.Phrases[2]);
            Assert.Equal("ddafgioqsw", result.Phrases[3]);
            Assert.Equal("ccbfikuvyz", result.Phrases[4]);
        }

        [Fact]
        public void Test4()
        {
            //Arrange
            var input = new Input();
            input.Phrases = new List<string>();
            input.Quantity = 2;
            input.Phrases.Add("qakmc");
            input.Phrases.Add("rrtbk");
            input.Phrases.Add("vaixn");
            input.Phrases.Add("wmpnj");
            input.Phrases.Add("uproi");
            input.Phrases.Add("btska");
            input.Phrases.Add("ejqwr");
            input.Phrases.Add("elwlg");
            input.Phrases.Add("oaoiy");
            input.Phrases.Add("hrqkn");

            //Act
            var result = _service.SortingOperation(input);

            //Assert
            Assert.Equal("ackmq", result.Phrases[0]);
            Assert.Equal("rrbkt", result.Phrases[1]);
            Assert.Equal("ainvx", result.Phrases[2]);
            Assert.Equal("jmnpw", result.Phrases[3]);
            Assert.Equal("iopru", result.Phrases[4]);
            Assert.Equal("abkst", result.Phrases[5]);
            Assert.Equal("ejqrw", result.Phrases[6]);
            Assert.Equal("llegw", result.Phrases[7]);
            Assert.Equal("ooaiy", result.Phrases[8]);
            Assert.Equal("hknqr", result.Phrases[9]);
        }

        [Fact]
        public void Test5()
        {
            //Arrange
            var input = new Input();
            input.Phrases = new List<string>();
            input.Quantity = 2;
            input.Phrases.Add("pzjim");
            input.Phrases.Add("njnfq");
            input.Phrases.Add("xyohs");

            //Act
            var result = _service.SortingOperation(input);

            //Assert
            Assert.Equal("ijmpz", result.Phrases[0]);
            Assert.Equal("nnfjq", result.Phrases[1]);
            Assert.Equal("hosxy", result.Phrases[2]);
        }

        [Fact]
        public void Test6()
        {
            //Arrange
            var input = new Input();
            input.Phrases = new List<string>();
            input.Quantity = 2;
            input.Phrases.Add("xqycs");
            input.Phrases.Add("beoax");
            input.Phrases.Add("afkso");
            input.Phrases.Add("bldit");
            input.Phrases.Add("gwrys");

            //Act
            var result = _service.SortingOperation(input);

            //Assert
            Assert.Equal("cqsxy", result.Phrases[0]);
            Assert.Equal("abeox", result.Phrases[1]);
            Assert.Equal("afkos", result.Phrases[2]);
            Assert.Equal("bdilt", result.Phrases[3]);
            Assert.Equal("grswy", result.Phrases[4]);
        }
    }
}