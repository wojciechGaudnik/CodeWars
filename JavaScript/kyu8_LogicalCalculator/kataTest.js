import chai from "chai";
const assert = chai.assert;
import logicalCalc from './logicalCalc.js'

describe("Testing", function() {
    it("Fixed Tests", function() {
        assert.strictEqual(logicalCalc([true, true, true, false], "AND"), false);
        assert.strictEqual(logicalCalc([true, true, true, false], "OR"), true);
        assert.strictEqual(logicalCalc([true, true, true, false], "XOR"), true);
        assert.strictEqual(logicalCalc([true, true, false, false], "AND"), false);
        assert.strictEqual(logicalCalc([true, true, false, false], "OR"), true);
        assert.strictEqual(logicalCalc([true, true, false, false], "XOR"), false);
        assert.strictEqual(logicalCalc([true, false, false, false], "AND"), false);
        assert.strictEqual(logicalCalc([true, false, false, false], "OR"), true);
        assert.strictEqual(logicalCalc([true, false, false, false], "XOR"), true);
        assert.strictEqual(logicalCalc([true, true], "AND"), true);
        assert.strictEqual(logicalCalc([true, true], "OR"), true);
        assert.strictEqual(logicalCalc([true, true], "XOR"), false);
        assert.strictEqual(logicalCalc([false, false], "AND"), false);
        assert.strictEqual(logicalCalc([false, false], "OR"), false);
        assert.strictEqual(logicalCalc([false, false], "XOR"), false);
        assert.strictEqual(logicalCalc([false], "AND"), false);
        assert.strictEqual(logicalCalc([false], "OR"), false);
        assert.strictEqual(logicalCalc([false], "XOR"), false);
        assert.strictEqual(logicalCalc([true], "AND"), true);
        assert.strictEqual(logicalCalc([true], "OR"), true);
        assert.strictEqual(logicalCalc([true], "XOR"), true);
    });
});