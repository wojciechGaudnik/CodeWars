// See https://www.chaijs.com for how to use Chai.
import { assert } from "chai";
import {flip} from "../kata/gravity_flip_kyu8";

describe("Gravity Flip", () => {
    it("Sample tests", () => {
        assert.deepEqual(flip('R', [3, 2, 1, 2]), [1, 2, 2, 3]);
        assert.deepEqual(flip('L', [1, 4, 5, 3, 5]), [5, 5, 4, 3, 1]);
    });
});
