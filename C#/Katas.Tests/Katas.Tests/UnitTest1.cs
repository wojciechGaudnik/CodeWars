using NUnit.Framework;
using System;
using Katas;

[TestFixture]
public class VaultPopulationTests
{
    [Test]
    public void MankindIsExtinct()
    {
        var dwellers = VaultExperience_3__PopulateTheVaults.PopulateMyVault(0);

//        VaultTec.AssertDwellersInAVault(dwellers, 0, 0, 0, 0);
    }

    [Test]
    public void TenLittleDwellersInAVault()
    {
        var dwellers = VaultExperience_3__PopulateTheVaults.PopulateMyVault(10);

//        VaultTec.AssertDwellersInAVault(dwellers, 10, 5, 5, 1);
    }

    [Test]
    public void TwentyThreeDwellersInAVault()
    {
        var dwellers = VaultExperience_3__PopulateTheVaults.PopulateMyVault(23);

//        VaultTec.AssertDwellersInAVault(dwellers, 23, 12, 11, 1);
    }
}