using Katas;
using NUnit.Framework;

public class SolutionTest
{
    [Test]
    public void EncryptExampleTests()
    {
        Assert.AreEqual("This is a test!", kyu6SimpleEncryption_1_AlternatingSplit.Encrypt("This is a test!", 0));
        Assert.AreEqual("hsi  etTi sats!", kyu6SimpleEncryption_1_AlternatingSplit.Encrypt("This is a test!", 1));
        Assert.AreEqual("s eT ashi tist!", kyu6SimpleEncryption_1_AlternatingSplit.Encrypt("This is a test!", 2));
        Assert.AreEqual(" Tah itse sits!", kyu6SimpleEncryption_1_AlternatingSplit.Encrypt("This is a test!", 3));
        Assert.AreEqual("This is a test!", kyu6SimpleEncryption_1_AlternatingSplit.Encrypt("This is a test!", 4));
        Assert.AreEqual("This is a test!", kyu6SimpleEncryption_1_AlternatingSplit.Encrypt("This is a test!", -1));
        Assert.AreEqual("hskt svr neetn!Ti aai eyitrsig", kyu6SimpleEncryption_1_AlternatingSplit.Encrypt("This kata is very interesting!", 1));
    }
  
    [Test]
    public void DecryptExampleTests()
    {
        Assert.AreEqual("This is a test!", kyu6SimpleEncryption_1_AlternatingSplit.Decrypt("This is a test!", 0));
        Assert.AreEqual("This is a test!", kyu6SimpleEncryption_1_AlternatingSplit.Decrypt("hsi  etTi sats!", 1));
        Assert.AreEqual("This is a test!", kyu6SimpleEncryption_1_AlternatingSplit.Decrypt("s eT ashi tist!", 2));
        Assert.AreEqual("This is a test!", kyu6SimpleEncryption_1_AlternatingSplit.Decrypt(" Tah itse sits!", 3));
        Assert.AreEqual("This is a test!", kyu6SimpleEncryption_1_AlternatingSplit.Decrypt("This is a test!", 4));
        Assert.AreEqual("This is a test!", kyu6SimpleEncryption_1_AlternatingSplit.Decrypt("This is a test!", -1));
        Assert.AreEqual("This kata is very interesting!", kyu6SimpleEncryption_1_AlternatingSplit.Decrypt("hskt svr neetn!Ti aai eyitrsig", 1));
    }
  
    [Test]
    public void EmptyTests()
    {
        Assert.AreEqual("", kyu6SimpleEncryption_1_AlternatingSplit.Encrypt("", 0));
        Assert.AreEqual("", kyu6SimpleEncryption_1_AlternatingSplit.Decrypt("", 0));
    }
  
    [Test]
    public void NullTests()
    {
        Assert.AreEqual(null, kyu6SimpleEncryption_1_AlternatingSplit.Encrypt(null, 0));
        Assert.AreEqual(null, kyu6SimpleEncryption_1_AlternatingSplit.Decrypt(null, 0));
    }
}