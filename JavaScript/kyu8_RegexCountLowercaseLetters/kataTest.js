describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(lowercaseCount("abc"), 3);
        Test.assertEquals(lowercaseCount("abcABC123"), 3);
        Test.assertEquals(lowercaseCount("abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~"), 3);
        Test.assertEquals(lowercaseCount(""), 0)
        Test.assertEquals(lowercaseCount("ABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~"), 0)
        Test.assertEquals(lowercaseCount("abcdefghijklmnopqrstuvwxyz"), 26);
    });
});
