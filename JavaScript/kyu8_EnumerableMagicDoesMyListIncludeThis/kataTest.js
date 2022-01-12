describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(include([1,2,3,4], 3), true )
        Test.assertEquals(include([1,2,4,5], 3), false)
    });
});
