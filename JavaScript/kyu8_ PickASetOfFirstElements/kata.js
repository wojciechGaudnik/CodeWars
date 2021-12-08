describe("Tests", () => {
    it("test", () => {
        var arr = ['a', 'b', 'c', 'd', 'e'];
        Test.assertSimilar(first(arr), ['a']);
        Test.assertSimilar(first(arr, 2), ['a', 'b']);

    });
});
