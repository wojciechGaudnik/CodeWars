describe("Test Case", function(){
    it ("Comparison: === should return false for the same value!", function() {
        var x = findStrangeValue();
        var testPassed;
        if ( !(x === x) ) {
            testPassed = true;
        } else {
            testPassed = false;
        }

        Test.expect(testPassed, true)
    });
});