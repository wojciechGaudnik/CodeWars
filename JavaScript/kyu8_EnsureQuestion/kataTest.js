const chai = require("chai");
const assert = chai.assert;
chai.config.truncateThreshold=0;

describe("Ensure question", () => {
    it("Fixed tests", () => {
        assert.strictEqual(ensureQuestion(""),"?","Expected: '?'");
        assert.strictEqual(ensureQuestion("Yes"),"Yes?","Expected: '?'");
        assert.strictEqual(ensureQuestion("No?"),"No?","Expected: '?'");
    });
});