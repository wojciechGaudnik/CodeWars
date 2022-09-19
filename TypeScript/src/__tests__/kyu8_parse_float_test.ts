import {assert} from "chai";
import {parseF} from "../kata/kyu8_parse_float";

describe("solution", function(){
    it("tests", function(){
        assert.equal(parseF("1"), 1.0);
    });
});
