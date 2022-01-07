describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(nextItem([1, 2, 3, 4, 5, 6, 7, 8], 5), 6);
        Test.assertEquals(nextItem(['a', 'b', 'c'], 'd'), undefined);
        Test.assertEquals(nextItem(['a', 'b', 'c'], 'c'), undefined);
        Test.assertEquals(nextItem("testing", "t"), "e");
        function* countFrom(n) { for (let i = n; ; ++i) yield i; }
        Test.assertEquals(nextItem(countFrom(1), 12), 13);
    });
});
