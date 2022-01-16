describe("Solution", function(){
    it("should pass fixed tests", function(){
        Test.assertEquals(+circleCircumference(new Circle(new Point(10, 10), 30)).toFixed(6), 188.495559);
        Test.assertEquals(+circleCircumference(new Circle(new Point(25, -70), 30)).toFixed(6), 188.495559);
        Test.assertEquals(+circleCircumference(new Circle(new Point(-15, 5), 0)).toFixed(6), 0);
        Test.assertEquals(+circleCircumference(new Circle(new Point(-15, 5), 12.5)).toFixed(6), 78.539816);
    });
});
