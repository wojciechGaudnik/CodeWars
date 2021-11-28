describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(howManySmaller([1.234,1.235,1.228],1.24), 2);
        Test.assertSimilar(howManySmaller([1.1888,1.1868,1.1838],1.19), 1);
        Test.assertSimilar(howManySmaller([3.1288,3.1212,3.1205],3.1212), 2);

    });
});
