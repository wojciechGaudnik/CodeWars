describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(equal1(),100,"value of a+b is not equal to 100");
        Test.assertSimilar(equal2(),100,"value of a-b is not equal to 100");
        Test.assertSimilar(equal3(),100,"value of a*b is not equal to 100");
        Test.assertSimilar(equal4(),100,"value of a/b is not equal to 100");
        Test.assertSimilar(equal5(),100,"value of a%b is not equal to 100");
    });
});
