describe("Tests", () => {
    it("test", () => {
        Test.assertSimilar(colorOf(255,0,0), "#ff0000");
        showColor("#ff0000")
        Test.assertSimilar(colorOf(0,111,0), "#006f00");
        showColor("#006f00")
        Test.assertSimilar(colorOf(1, 2 ,3), "#010203");
        showColor("#010203")
    });
});
