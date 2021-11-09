describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(toFreud(""), "");
        Test.assertSimilar(toFreud(""), "");
        Test.assertSimilar(toFreud("test"), "sex");
        Test.assertSimilar(toFreud("This is a test"), "sex sex sex sex" )
        Test.assertSimilar(toFreud("This is a longer test"), "sex sex sex sex sex" )
        Test.assertSimilar(toFreud("You're becoming a true freudian expert"), "sex sex sex sex sex sex" )
    });
});
