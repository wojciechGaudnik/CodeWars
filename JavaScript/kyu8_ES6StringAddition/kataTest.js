describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(joinStrings('string1', 'string2'), 'string1 string2');
        Test.assertEquals(joinStrings('testing', 'testing'), 'testing testing');
        Test.assertEquals(joinStrings(134, 234), '134 234');
    });
});
