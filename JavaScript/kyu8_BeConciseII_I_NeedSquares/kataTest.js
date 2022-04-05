describe("Your refactored solution", () => {
    it("should behave in exactly the same way as the function does prior to refactoring for the tested range of inputs", () => {
        Test.assertSimilar(squaresOnly1([0,1,2,3,4,5,6,7,8,9,10]), [0,1,4,9]);
        Test.assertSimilar(squaresOnly1([31,33,35,37,39,38,36,34,32]), [36]);
        Test.assertSimilar(squaresOnly1([0,10,20,30,40,50,60,70,80,90,100]), [0,100]);
        Test.assertSimilar(squaresOnly1([20,19,18,17,16,15,13,11,9,1,5,4]), [16,9,1,4]);
        Test.assertSimilar(squaresOnly1([45,36,75,64,9,9,4,1,4,1,1,16,16,18,17,35,25,35]), [36,64,9,9,4,1,4,1,1,16,16,25]);
    });
});