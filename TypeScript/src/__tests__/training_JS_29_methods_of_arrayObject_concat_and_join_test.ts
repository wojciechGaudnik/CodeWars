import { assert } from "chai";
import {bigToSmall} from "../kata/training_JS_29_methods_of_arrayObject_concat_and_join";

describe("-------- Basic Test --------", function() {
    it("bigToSmall([[1,2],[3,4],[5,6]])", function() {
        assert.strictEqual(bigToSmall([[1,2],[3,4],[5,6]]), "6>5>4>3>2>1");
    });

    it("bigToSmall([[1,3,5],[2,4,6]])", function() {
        assert.strictEqual(bigToSmall([[1,3,5],[2,4,6]]), "6>5>4>3>2>1");
    });

    it("bigToSmall([[1,1],[1],[1,1]])", function() {
        assert.strictEqual(bigToSmall([[1,1],[1],[1,1]]), "1>1>1>1>1");
    });
});