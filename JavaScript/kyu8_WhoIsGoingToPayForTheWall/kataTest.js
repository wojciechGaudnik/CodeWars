describe("Basic tests",() =>{
    Test.assertSimilar(whoIsPaying("Mexico"),["Mexico", "Me"]);
    Test.assertSimilar(whoIsPaying("Melania"),["Melania", "Me"]);
    Test.assertSimilar(whoIsPaying("Melissa"),["Melissa", "Me"]);
    Test.assertSimilar(whoIsPaying("Me"),["Me"]);
    Test.assertSimilar(whoIsPaying(""), [""]);
    Test.assertSimilar(whoIsPaying("I"), ["I"]);
});