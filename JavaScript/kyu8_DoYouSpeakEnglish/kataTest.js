describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(spEng("english"), true);
        Test.assertEquals(spEng("egnlish"), false);
    });
});
