describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(all([1,2,3,4,5], function(v){return v<9}), true)
        Test.assertEquals(all([1,2,3,4,5], function(v){return v>9}), false)

    });
});
