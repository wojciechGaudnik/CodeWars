using Katas;

namespace Solution
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class KataTests
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual("worstest episode ever", BerserkRater_CGVs_Clang.BerserkRater(new[] { "it's this the CG from a P2 game?",
                                                                         "Hell, no! Even the CG in the Dreamcast game was more fluid than this!",
                                                                         "Well, at least Gatsu does his clang even against a mere rabbit",
                                                                         "Hey, Cosette was not in this part of the story!",
                                                                         "Ops, everybody dead again! Well, how boring..."}));

      Assert.AreEqual("0", BerserkRater_CGVs_Clang.BerserkRater(new[] { "missing the Count arc",
                                                     "lame CG",
                                                     "Gatsu doing its clang against a few henchmen",
                                                     "even more lame CG"}));
      Assert.AreEqual("2", BerserkRater_CGVs_Clang.BerserkRater(new[] { "Farnese unable to shut the fuck up",
                                                     "awful CG dogs assaulting everybody",
                                                     "Gatsu clanging the pig apostle!"}));

      Assert.AreEqual("10", BerserkRater_CGVs_Clang.BerserkRater(new[] { "spirits of the dead attacking Gatsu and getting clanged for good",
                                                      "but the wheel spirits where really made with bad CG",
                                                      "Isidoro trying to steal the dragon Slayer and getting a sort of clang on his face",
                                                      "Gatsu vs. the possessed horse: clang!",
                                                      "Farnese whining again...",
                                                      "a shame the episode ends with that scrappy CG" }));

      Assert.AreEqual("bestest episode ever", BerserkRater_CGVs_Clang.BerserkRater(new[] { "Holy chain knights being dicks",
                                                                        "Serpico almost getting clanged by Gatsu, but without losing his composure",
                                                                        "lame CG","Luka getting kicked",
                                                                        "Gatsu going clang against the angels",
                                                                        "Gatsu clanging vs Mozgus, big time!" }));
    }
  }
}