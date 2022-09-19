import { assert } from "chai";
import {arr2bin} from "../kata/kyu7_arguments_to_binary_addition";

describe("Array 2 Bin", function(){
    it("Basic tests", function() {
        assert.strictEqual(arr2bin([1,2]), "11");
        assert.strictEqual(arr2bin([1,2,3,4,5]), "1111");
        assert.strictEqual(arr2bin([1,10,100,1000]), "10001010111");
        assert.strictEqual(arr2bin([null]), "0");
        assert.strictEqual(arr2bin([true,true,false,15]),"1111");
    });
});
