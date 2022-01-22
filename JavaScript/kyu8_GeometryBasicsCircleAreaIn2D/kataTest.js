describe("Tests", () => {
    it("test", () => {
        Test.assertEquals( +circleArea( new Circle( new Point(10, 10), 30)).toFixed(6), 2827.433388)
        Test.assertEquals( +circleArea( new Circle( new Point(25, -70), 30)).toFixed(6), 2827.433388)
        Test.assertEquals( +circleArea( new Circle( new Point(-15, 5), 0)).toFixed(6), 0)
        Test.assertEquals( +circleArea( new Circle( new Point(-15, 5), 12.5)).toFixed(6), 490.873852)

    });
});
