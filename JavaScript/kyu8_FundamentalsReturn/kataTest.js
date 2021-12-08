const chai = require("chai");
const assert = chai.assert;
chai.config.truncateThreshold=0;

describe("Basic tests", () => {
    it("Testing for fixed tests", () => {
        assert.strictEqual(add(1,2),3)
        assert.strictEqual(multiply(1,2),2)
        assert.strictEqual(divide(2,1),2)
        assert.strictEqual(mod(1,2),1)
        assert.strictEqual(exponent(1,2),1)
        assert.strictEqual(subt(1,2),-1)
    })
})