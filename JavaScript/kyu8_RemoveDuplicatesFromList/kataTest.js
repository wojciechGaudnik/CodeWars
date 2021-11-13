describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(distinct([1]), [1]);
        Test.assertSimilar(distinct([1,2]), [1,2]);
        Test.assertSimilar(distinct([1,1,2]), [1,2]);
    });
});
