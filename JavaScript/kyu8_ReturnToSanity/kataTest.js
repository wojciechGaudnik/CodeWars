describe("Tests", () => {
    it("test", () => {
        Test.assertDeepEquals(mystery(), {sanity: 'Hello'}, 'Mystery has not returned to sanity');
    });
});
