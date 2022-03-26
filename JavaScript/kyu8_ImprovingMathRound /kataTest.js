describe("Tests", () => {
    it("test", () => {
        Test.assertEquals(Math.roundTo(3.1415926535, 4), 3.1416);
        Test.assertEquals(Math.roundTo(4, 5), 4);
        Test.assertEquals(Math.roundTo(4.1235343424, 6), 4.123534);
        Test.assertEquals(Math.roundTo(5.3035802, 3), 5.304);
        Test.assertEquals(Math.roundTo(0.9384930193848595, 15), 0.938493019384860);
        Test.assertEquals(Math.roundTo(9.9999, 3), 10);
    });
});
