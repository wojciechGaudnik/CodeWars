describe("Tests", () => {
    it("test", () => {
        var numbers = [1, 2, 3, 4, 5];
        Test.assertSimilar(numbers.square(), [1, 4, 9, 16, 25]);
        Test.assertSimilar(numbers.cube(), [1, 8, 27, 64, 125]);
        Test.assertEquals(numbers.sum(), 15, 'Wrong sum');
        Test.assertEquals(numbers.average(), 3, 'Wrong average');
        Test.assertSimilar(numbers.even(), [2, 4], 'Wrong result for even()');
        Test.assertSimilar(numbers.odd(), [1, 3, 5], 'Wrong result for odd()');
    });
});
