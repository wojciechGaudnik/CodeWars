const chai = require("chai");
const assert = chai.assert;
const lib = require("./kata")
describe('Remainder Function', function(){
    it('Should handle arguments and math as defined in specificaitons', function(){
        assert.equal(lib.remainder(17,5), 2, 'Returned value should be the value left over after dividing as much as possible.');
        assert.equal(lib.remainder(13, 72), lib.remainder(72, 13), 'The order the arguments are passed should not matter.');
        assert.isNaN(lib.remainder(1, 0), 'Divide by zero should return NaN');
        assert.isNaN(lib.remainder(0, 0), NaN, 'Divide by zero should return NaN');
    });
});