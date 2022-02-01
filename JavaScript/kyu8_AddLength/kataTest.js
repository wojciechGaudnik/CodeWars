describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(addLength('apple ban'),["apple 5", "ban 3"]);
        Test.assertSimilar(addLength('you will win'),["you 3", "will 4", "win 3"]);
    });
});
