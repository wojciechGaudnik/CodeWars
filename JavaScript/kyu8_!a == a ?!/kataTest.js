describe("Tests", () => {
    it("test", () => {
        Test.assertEquals( a == false,  true, `a != false`);
        Test.assertEquals( !a == false, true, `!a != false`);
        Test.assertEquals( a == !a,     true, `a != !a`);
    });
});
