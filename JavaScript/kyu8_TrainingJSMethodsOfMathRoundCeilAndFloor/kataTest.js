describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(roundIt(3.45) , 4);
        Test.assertSimilar(roundIt(34.5) , 34);
        Test.assertSimilar(roundIt(34.56) , 35);
    });
});
