describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(periodIsLate(new Date(2016, 6, 13), new Date(2016, 7, 16), 35), false);
        Test.assertEquals(periodIsLate(new Date(2016, 6, 13), new Date(2016, 7, 16), 28), true);

    });
});