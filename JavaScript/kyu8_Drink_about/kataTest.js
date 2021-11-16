const { assert } = require("chai")

describe("Basic tests", () => {
    it("Testing for fixed tests", () => {
        assert.strictEqual(peopleWithAgeDrink(22), 'drink whisky');
    })
})