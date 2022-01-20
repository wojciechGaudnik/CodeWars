describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(cookie("Ryan"), "Who ate the last cookie? It was Zach!")
        Test.assertEquals(cookie(26), "Who ate the last cookie? It was Monica!")
        Test.assertEquals(cookie(2.3), "Who ate the last cookie? It was Monica!")
        Test.assertEquals(cookie(true), "Who ate the last cookie? It was the dog!")

    });
});
