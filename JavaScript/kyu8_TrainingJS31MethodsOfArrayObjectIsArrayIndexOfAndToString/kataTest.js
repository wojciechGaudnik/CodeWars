describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(blackAndWhite(5,13) , "It's a fake array");
        Test.assertSimilar(blackAndWhite([5,13]) , "It's a black array");
        Test.assertSimilar(blackAndWhite([5,12]) , "It's a white array");

    });
});
