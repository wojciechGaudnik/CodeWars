describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(getASCII('A'),65)
        Test.assertEquals(getASCII(' '),32)
        Test.assertEquals(getASCII('!'),33)
    });
});
