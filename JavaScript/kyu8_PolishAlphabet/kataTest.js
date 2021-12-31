describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(correctPolishLetters("Jędrzej Błądziński"),"Jedrzej Bladzinski");
        Test.assertEquals(correctPolishLetters("Lech Wałęsa"),"Lech Walesa");
        Test.assertEquals(correctPolishLetters("Maria Skłodowska-Curie"),"Maria Sklodowska-Curie");

    });
});
