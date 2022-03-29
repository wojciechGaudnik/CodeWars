describe("Your refactored solution", () => {
    it("should behave in exactly the same way as the program prior to refactoring for the range of inputs tested", () => {
        Test.assertEquals(sumSquares([1,2,3,4,5]), 55);
        Test.assertEquals(sumSquares([7,3,9,6,5]), 200);
        Test.assertEquals(sumSquares([11,13,15,18,2]), 843);
        Test.assertEquals(sumSquares([-5,-4,-3,-2,-1,0,1,2,3,4,5]), 110);
    });
});