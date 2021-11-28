describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(alienLanguage("My name is John") , "My NAMe Is JOHn");
        Test.assertSimilar(alienLanguage("this is an example") , "THIs Is An EXAMPLe");
        Test.assertSimilar(alienLanguage("Hello World") , "HELLo WORLd");
        Test.assertSimilar(alienLanguage("HELLO WORLD") , "HELLo WORLd");

    });
});
