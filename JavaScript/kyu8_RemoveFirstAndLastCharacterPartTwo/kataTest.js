const chai = require("chai");
const assert = chai.assert;
const lib = require("./kata");

describe("Tests", () => {
    it("Should remove the first and last character", () => {
        assert.strictEqual(lib.array('1,2,3'), '2');
        assert.strictEqual(lib.array('1,2,3,4'), '2 3');
        assert.strictEqual(lib.array('1,2,3,4,5'), '2 3 4');
    })
    it("Should return null if the final result is an empty string", () => {
        assert.strictEqual(lib.array(''), null);
        assert.strictEqual(lib.array('1'), null);
        assert.strictEqual(lib.array('1,2'), null);
    })
});