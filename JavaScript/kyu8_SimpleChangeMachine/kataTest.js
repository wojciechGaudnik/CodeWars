describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(changeMe("£1"),"20p 20p 20p 20p 20p");
        Test.assertEquals(changeMe("Money"),"Money");
    });
});
