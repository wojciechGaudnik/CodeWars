import { assert } from "chai";
import { mouthSize } from "../kata/the_wide_mouthed_frog_kyu8";

describe("Basic tests", () => {
    it("Basic tests should pass", () => {
        assert.equal(mouthSize("toucan"),"wide");
        assert.equal(mouthSize("ant bear"),"wide");
        assert.equal(mouthSize("alligator"),"small");
    });
});