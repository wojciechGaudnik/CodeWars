describe("Basic tests", function(){
    it("Testing for number of pillars: 1, distance: 10 m and width: 10 cm", function(){
        Test.assertEquals(pillars(1, 10, 10) , 0);
    });
    it("Testing for number of pillars: 2, distance: 20 m and width: 25 cm", function(){
        Test.assertEquals(pillars(2, 20, 25) , 2000);
    });
    it("Testing for number of pillars: 11, distance: 15 m and width: 30 cm", function(){
        Test.assertEquals(pillars(11, 15, 30) , 15270);
    });
});