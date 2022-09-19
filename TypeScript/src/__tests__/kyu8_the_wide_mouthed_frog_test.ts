import { assert } from "chai";
import { mouthSize } from "../kata/kyu8_the_wide_mouthed_frog";

describe("Basic tests", () => {
    it("Basic tests should pass", () => {
        assert.equal(mouthSize("toucan"),"wide");
        assert.equal(mouthSize("ant bear"),"wide");
        assert.equal(mouthSize("alligator"),"small");
    });
});
