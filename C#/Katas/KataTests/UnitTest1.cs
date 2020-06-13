using Katas;

namespace smile67kyu6Basics06ReversingAndCombiningText
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class smile67kyu6Basics06ReversingAndCombiningTextTest
    {
        [Test]
        public void smile67kyu6Basics06ReversingAndCombiningTextTest_withoutRandom1()
        {
            Assert.AreEqual("cbafed", new kyu6Basics06ReversingAndCombiningText().reverseAndCombineText("abc def"));
        }
        [Test]
        public void smile67kyu6Basics06ReversingAndCombiningTextTest_withoutRandom2()
        {
            Assert.AreEqual("defabcjklghi", new kyu6Basics06ReversingAndCombiningText().reverseAndCombineText("abc def ghi jkl"));
        }
        [Test]
        public void smile67kyu6Basics06ReversingAndCombiningTextTest_withoutRandom3()
        {
            Assert.AreEqual("cbafed", new kyu6Basics06ReversingAndCombiningText().reverseAndCombineText("cbafed"));
        }
        [Test]
        public void smile67kyu6Basics06ReversingAndCombiningTextTest_withoutRandom4()
        {
            Assert.AreEqual("trzwqfdstrteettr45hh4325543544hjhjh21lllll", new kyu6Basics06ReversingAndCombiningText().reverseAndCombineText("234hh54 53455 sdfqwzrt rtteetrt hjhjh lllll12  44"));
        }
        [Test]
        public void smile67kyu6Basics06ReversingAndCombiningTextTest_withoutRandom5()
        {
            Assert.AreEqual("gffds432243fdsfdseewttf", new kyu6Basics06ReversingAndCombiningText().reverseAndCombineText("sdfsdf wee sdffg 342234 ftt"));
        }
        [Test]
        public void smile67kyu6Basics06ReversingAndCombiningTextTest_withoutRandom6()
        {
            Assert.AreEqual("spjtmswkkmsssjokyccwvbtlulnwamytyvguukyccwvbtldlzyrqgydxgooppqpjpembqtbdlzyrqgpsceypsceycrnzwydxgooppqdlzyrqghtpgskyccwvbtl", new kyu6Basics06ReversingAndCombiningText().reverseAndCombineText("yecsp yecsp btqbmepjp gqryzld gqryzld sgpth wznrc qppoogxdy ltbvwccyk mawnlu smtjps ojsssmkkw gqryzld qppoogxdy uugvyty ltbvwccyk ltbvwccyk"));
        }

        [Test]
        public void smile67kyu6Basics06ReversingAndCombiningTextTest_withoutRandom7()
        {
            Assert.AreEqual("cnerbsrefbdzgxlxefbdzgxlxrqphxeuvpnolamzppudpngdpcpjempjapjempjajwoskjwoskgqdxmonoghrvfxtypvhrvfxtypvnlclokzcujxzhqiklwhrvfxtypvkzcujxefbdzgxlxrmxrtccxabpepjempjafnuclbgqdxmonogrmxrtcvpnolamzpefbdzgxlx", new kyu6Basics06ReversingAndCombiningText().reverseAndCombineText("gonomxdqg vpytxfvrh ksowj ksowj xjuczk wlkiqhz vpytxfvrh olcln xlxgzdbfe uexhpqr rsbrenc xlxgzdbfe ajpmejp ajpmejp pzmalonpv cpdgnpdup ajpmejp blcunf ctrxmr epbaxc pzmalonpv xlxgzdbfe gonomxdqg ctrxmr xjuczk xlxgzdbfe vpytxfvrh"));
        }
    }
}		



// smile67kyu6Basics06ReversingAndCombiningTextTest_withoutRandom2
// Test Passed
// Input Text= sdfsdf wee sdffg 342234 ftt
// Step 1
// fdsfdseew gffds432243 ftt
// Step 2
// weesdfsdf342234sdffg ftt
// Step 3
// gffds432243fdsfdseewttf