describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(fiveLine("  a") , "a\naa\naaa\naaaa\naaaaa");
        Test.assertSimilar(fiveLine("\txy \n") , "xy\nxyxy\nxyxyxy\nxyxyxyxy\nxyxyxyxyxy");
        Test.assertSimilar(fiveLine("           Ok               ") , "Ok\nOkOk\nOkOkOk\nOkOkOkOk\nOkOkOkOkOk");

    });
});
