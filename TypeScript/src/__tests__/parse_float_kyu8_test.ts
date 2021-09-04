import {assert} from "chai";
import {parseF} from "../kata/parse_float_kyu8";

describe("solution", function(){
    it("tests", function(){
        assert.equal(parseF("1"), 1.0);
        assert.equal(parseF("a")dd, Nan);
    });
});