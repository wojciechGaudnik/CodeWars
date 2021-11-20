describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(getLength([1,2,3]),3);
        Test.assertSimilar(getFirst([1,2,3]),1);
        Test.assertSimilar(getLast([1,2,3]),3);
        Test.assertSimilar(pushElement([1,2,3]).length,4);
        Test.assertSimilar(popElement([1,2,3]).length,2);
    });
});
