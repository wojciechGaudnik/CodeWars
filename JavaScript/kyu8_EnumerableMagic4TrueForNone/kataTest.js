describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(none([1,2,3,4,5],function(item){ return item > 5 }), true)
        Test.assertEquals(none([1,2,3,4,5],function(item){ return item > 4 }), false)

    });
});
