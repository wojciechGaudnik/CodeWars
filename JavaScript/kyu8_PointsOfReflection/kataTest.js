const assert = require("chai").assert;

describe("Points of Reflection", () => {
    it("Basic tests", () => {
        assert.deepEqual(symmetricPoint([0,0], [1,1]), [2, 2]);
        assert.deepEqual(symmetricPoint([2, 6], [-2, -6]), [-6, -18]);
        assert.deepEqual(symmetricPoint([10, -10], [-10, 10]), [-30, 30]);
        assert.deepEqual(symmetricPoint([1, -35], [-12, 1]), [-25, 37]);
        assert.deepEqual(symmetricPoint([1000, 15], [-7, -214]), [-1014, -443]);
        assert.deepEqual(symmetricPoint([0, 0], [0, 0]), [0, 0]);
    });
});