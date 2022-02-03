const chai = require("chai");
const assert = chai.assert;

chai.config.truncateThreshold = 0;

describe('Test Cases', function() {
    const lst = [3, 5, 8, 13];

    it('Should return cascading lists of 1 element', function() {
        assert.deepEqual(eachCons(lst, 1), [[3], [5], [8], [13]]);
    });

    it('Should return cascading lists of 2 element', function() {
        assert.deepEqual(eachCons(lst, 2), [[3,5], [5,8], [8,13]]);
    });

    it('Should return cascading lists of 3 element', function() {
        assert.deepEqual(eachCons(lst, 3), [[3,5,8], [5,8,13]]);
    });

    it('Empty list should return an empty list', function() {
        assert.deepEqual(eachCons([], 3), []);
    });
});