import { assert } from "chai";
import { getRealFloor } from "../kata/kyu8_what_s_the_real_floor";

describe("example", function() {
    it("test", function() {
        assert.equal(getRealFloor(1), 0);
        assert.equal(getRealFloor(5), 4);
        assert.equal(getRealFloor(15), 13);
    });
});
