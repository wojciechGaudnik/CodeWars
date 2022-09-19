// See https://www.chaijs.com for how to use Chai.
import { assert } from "chai";
import {checkExam} from "../kata/kyu8_check_the_exam";

describe("Basic tests", () => {
    it("Should pass basic tests", () => {
        assert.equal(checkExam(["a", "a", "b", "b"], ["a", "c", "b", "d"]), 6);
        assert.equal(checkExam(["a", "a", "c", "b"], ["a", "a", "b",  ""]), 7);
        assert.equal(checkExam(["a", "a", "b", "c"], ["a", "a", "b", "c"]), 16);
        assert.equal(checkExam(["b", "c", "b", "a"], ["",  "a", "a", "c"]), 0);
    });
});
