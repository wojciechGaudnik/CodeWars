describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(howManydays(1),31);
        Test.assertSimilar(howManydays(2),28);
        Test.assertSimilar(howManydays(3),31);
        Test.assertSimilar(howManydays(4),30);
        Test.assertSimilar(howManydays(12),31);
    });
});
