// import the type of assertion library you wish to use (Chai recommended)
import {assert} from "chai";
import {isReallyNaN} from "../kata/kyu8_is_really_NaN";

describe("Basic tests", function(){
    it("returns `false` for Int", function(){
        assert.equal(isReallyNaN(37), false)
    });

    it("returns `false` for String", function(){
        assert.equal(isReallyNaN('37'), false)
    });

    it("returns `true` for NaN", function(){
        assert.equal(isReallyNaN(NaN), true)
    });

    it("returns `false` for undefined", function(){
        assert.equal(isReallyNaN(undefined), false)
    });
});
