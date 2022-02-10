describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(startingMark(1.52), 9.45)
        Test.assertEquals(startingMark(1.83), 10.67)
        Test.assertEquals(startingMark(1.22), 8.27)
        Test.assertEquals(startingMark(2.13), 11.85)
    });
});
