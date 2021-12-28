describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(derive(7,8), "56x^7");
        Test.assertEquals(derive(5,9), "45x^8");
    });
});
