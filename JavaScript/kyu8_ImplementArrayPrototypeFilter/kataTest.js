describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar([1,2,3,4].filter((num)=>{ return num > 3}), [4])

    });
});
