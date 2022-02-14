describe("Tests", () => {
    it("test", () => {
        console.log("My Test Cases");
        Test.assertEquals(myFirstKata(3,5),(3 % 5 + 5 % 3));
        Test.assertEquals(myFirstKata("hello",3),false);
        Test.assertEquals(myFirstKata(67,"bye"),false);
        Test.assertEquals(myFirstKata(true,true),false);
        Test.assertEquals(myFirstKata(314,107),(107 % 314 + 314 % 107));
        Test.assertEquals(myFirstKata(19483,9),(9 % 19483 + 19483 % 9));
    });
});
