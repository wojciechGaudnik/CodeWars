describe("Tests", () => {
    it("test", () => {
        console.log("no chars should return null");

        Test.assertSimilar(uniTotal(""), 0);

        console.log("Should work with Single Letters");

        Test.assertSimilar(uniTotal("a"), 97);
        Test.assertSimilar(uniTotal("b"), 98);
        Test.assertSimilar(uniTotal("c"), 99);
        Test.assertSimilar(uniTotal("d"), 100);
        Test.assertSimilar(uniTotal("e"), 101);

        console.log("should work with multiple letters");
        Test.assertSimilar(uniTotal("aaa"), 291);

        console.log("should work with sentences and spaces");

        Test.assertSimilar(uniTotal("Mary Had A Little Lamb"),1873);
    });
});