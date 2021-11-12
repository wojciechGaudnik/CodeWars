const chai = require("chai");
const assert = chai.assert;

describe("Fixed Tests", () => {
    it("Tests", () => {
        assert.deepEqual(twoHighest([]), [])
        assert.deepEqual(twoHighest([15]), [15])
        assert.deepEqual(twoHighest([15, 20, 20, 17]), [20, 17])
    })
})