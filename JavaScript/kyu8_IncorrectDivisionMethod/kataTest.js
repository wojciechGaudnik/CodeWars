const {assert} = require("chai");

it("example tests", function() {
    assert.strictEqual(solve(2, 1), 2);
    assert.strictEqual(solve(2, 4), 0.5);
    assert.strictEqual(solve(42, 0), Infinity);
    assert.strictEqual(solve(0, 8), 0);
    assert.strictEqual(solve(7, 2), 3.5);
    assert.strictEqual(solve(4.2, 1), 4.2);
    assert.strictEqual(solve(9999, 11), 909);
});