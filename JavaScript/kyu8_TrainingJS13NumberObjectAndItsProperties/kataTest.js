describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(whatNumberIsIt(1/0),"Input number is Number.POSITIVE_INFINITY");
        Test.assertSimilar(whatNumberIsIt(100),"Input number is 100");
        Test.assertSimilar(whatNumberIsIt(1.7976931348623157e+308),"Input number is Number.MAX_VALUE");
        Test.assertSimilar(whatNumberIsIt(5e-324),"Input number is Number.MIN_VALUE");
        Test.assertSimilar(whatNumberIsIt(-Number.MAX_VALUE*2),"Input number is Number.NEGATIVE_INFINITY");
        Test.assertSimilar(whatNumberIsIt(NaN),"Input number is Number.NaN");
        Test.assertSimilar(whatNumberIsIt(Infinity+1),"Input number is Number.POSITIVE_INFINITY");

    });
});
