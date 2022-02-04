describe("Tests", () => {
    it("test", () => {
        var emptyShip = new Ship(0,0);
        Test.assertEquals(emptyShip.isWorthIt(),false)
    });
});