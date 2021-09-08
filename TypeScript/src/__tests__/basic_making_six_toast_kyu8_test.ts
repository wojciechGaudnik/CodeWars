import {assert} from "chai";
import {sixToast} from "../kata/basic_making_six_toast_kyu8";

describe("solution", function(){
    it("Basic Tests", function() {
        assert.equal(sixToast(15), 9);
        assert.equal(sixToast(6), 0);
        assert.equal(sixToast(3), 3);
    });
});