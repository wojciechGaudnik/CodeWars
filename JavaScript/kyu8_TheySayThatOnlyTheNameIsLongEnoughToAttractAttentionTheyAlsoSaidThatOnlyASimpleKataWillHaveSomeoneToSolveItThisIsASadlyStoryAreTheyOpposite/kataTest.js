describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(isOpposite("ab","AB") , true);
        Test.assertSimilar(isOpposite("aB","Ab") , true);
        Test.assertSimilar(isOpposite("aBcd","AbCD") , true);
        Test.assertSimilar(isOpposite("aBcde","AbCD") , false);
        Test.assertSimilar(isOpposite("AB","Ab") , false);
        Test.assertSimilar(isOpposite("","") , false);

    });
});
