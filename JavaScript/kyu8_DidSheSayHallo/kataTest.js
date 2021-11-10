describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(validateHello('ahoj'), true);

        Test.assertEquals(validateHello('meh'), false);
    });
});
