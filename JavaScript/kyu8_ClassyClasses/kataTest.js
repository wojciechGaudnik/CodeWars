describe("Tests", () => {
    it("test", () => {
        var john = new Person('john', 34)
        Test.assertEquals(john.info, 'johns age is 34')

    });
});
