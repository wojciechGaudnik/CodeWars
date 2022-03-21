describe("Tests", () => {
    it("test", () => {
        var albert = new Warrior("Albert")
        var boris  = new Warrior("Boris")

        Test.assertEquals(albert.toString(),"Hi! my name's Albert");
        Test.assertEquals(albert.name(),"Albert");
        Test.assertEquals(boris.name(),"Boris");

        boris.name("Bobo")
        Test.assertEquals(boris.name(),"Bobo");


    });
});
