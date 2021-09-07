import { assert } from "chai";
import {usdcny} from "../kata/usd_to_cny";

describe("should work with test cases", function() {
    it("simple", function() {
        assert.strictEqual(usdcny(15), '101.25 Chinese Yuan');
    });
    it("simple", function() {
        assert.strictEqual(usdcny(465), '3138.75 Chinese Yuan');
    });

});



