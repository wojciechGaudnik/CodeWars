const chai = require("chai");
const assert = chai.assert;
chai.config.truncateThreshold = 0;

describe("Tests", () => {
    it("test", () => {
        assert.strictEqual(greet_abe(), 'Hello, Abe!', 'greet_abe() is not greeting Abe');
        assert.strictEqual(greet_ben(), 'Hello, Ben!', 'greet_ben() is not greeting Ben');
    });
});
