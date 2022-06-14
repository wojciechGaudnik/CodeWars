const chai = require("chai");
const assert = chai.assert;
chai.config.truncateThreshold = 0;

describe("Sample Tests", () => {
    it("tests", () => {
        assert.deepEqual(keysAndValues({a: 1, b: 2, c: 3}), [['a', 'b', 'c'], [1, 2, 3]]);
        assert.deepEqual(keysAndValues({}), [[], []]);
        assert.deepEqual(keysAndValues({1: 'a', 2: 'b', 3: 'c'}), [['1', '2', '3'], ['a', 'b', 'c']]);
    });
});
