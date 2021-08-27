import { assert } from "chai";
import { getRealFloor } from "../kata/what_s_the_real_floor_kyu8";

describe("example", function() {
    it("test", function() {
        assert.equal(getRealFloor(1), 0);
        assert.equal(getRealFloor(5), 4);
        assert.equal(getRealFloor(15), 13);
    });
});