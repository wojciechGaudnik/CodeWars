describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(numberToPower(4, 2), 16);
        Test.assertEquals(numberToPower(10, 4), 10000);
        Test.assertEquals(numberToPower(10, 0), 1);

    });
});
