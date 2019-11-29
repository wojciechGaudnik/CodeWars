using NUnit.Framework;
using System;
using Katas;

[TestFixture]
public class HackMyTerminalTests
{
    [Test]
    public void PasswordWith4Letters() {

        Assert.AreEqual("PILZ", VaultExperience_2__HackMyTerminal_.HackMyTerminal( 4, "/§TTE§*%RAUM*+?=)PILZ(/&A..-.%BAUM_:"), "Password incorrekt. Terminal has been locked!");
    }
}