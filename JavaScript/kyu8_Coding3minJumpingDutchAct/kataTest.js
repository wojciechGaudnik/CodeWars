const chai = require("chai");
const assert = chai.assert;
chai.config.truncateThreshold=0;

describe("<br><font size=6><b>-------- Coding 3min : Jumping Dutch act --------</b></font>", () => {
    it("<br><font size=4><b>-------- Basic Test --------</b></font>", () => {
        assert.strictEqual(sc(2), "Aa~ Pa! Aa!", "good luck!");
        assert.strictEqual(sc(6), "Aa~ Aa~ Aa~ Aa~ Aa~ Pa! Aa!", "good luck!");
        assert.strictEqual(sc(7), "Aa~ Aa~ Aa~ Aa~ Aa~ Aa~ Pa!", "good luck!");
        assert.strictEqual(sc(10), "Aa~ Aa~ Aa~ Aa~ Aa~ Aa~ Aa~ Aa~ Aa~ Pa!", "good luck!");
        assert.strictEqual(sc(1), "", "good luck!");
        assert.strictEqual(sc(-1), "", "good luck!");
    })
});
