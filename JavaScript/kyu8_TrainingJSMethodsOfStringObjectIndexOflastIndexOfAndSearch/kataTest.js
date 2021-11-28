describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(firstToLast("ababc","a") , 2);
        Test.assertSimilar(firstToLast("ababc","c") , 0);
        Test.assertSimilar(firstToLast("ababc","d") , -1);
    });
});
