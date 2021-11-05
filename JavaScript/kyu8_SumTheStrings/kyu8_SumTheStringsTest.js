const lib = require("./kyu8_SumTheStrings")
var assert = require("assert")
describe("Tests", () => {
    it("test", () => {
        assert.equal(lib.sumStr("4","5"), "9");
        assert.equal(lib.sumStr("34","5"), "39");
    });
});

