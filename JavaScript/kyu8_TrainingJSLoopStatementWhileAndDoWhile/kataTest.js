describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(padIt("a",1),"*a");
        Test.assertSimilar(padIt("a",2),"*a*");
        Test.assertSimilar(padIt("a",3),"**a*");
        Test.assertSimilar(padIt("a",4),"**a**");
        Test.assertSimilar(padIt("a",5),"***a**");
    });
});
