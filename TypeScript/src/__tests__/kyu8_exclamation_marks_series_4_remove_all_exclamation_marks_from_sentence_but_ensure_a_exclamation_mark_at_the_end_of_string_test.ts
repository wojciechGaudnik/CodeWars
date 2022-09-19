import {assert} from "chai";
import {remove} from "../kata/kyu8_exclamation_marks_series_4_remove_all_exclamation_marks_from_sentence_but_ensure_a_exclamation_mark_at_the_end_of_string";

describe("Basic Tests", function(){
    it("It should works for basic tests", function(){
        assert.strictEqual(remove("Hi!") , "Hi!")
        assert.strictEqual(remove("Hi!!!") ,"Hi!")
        assert.strictEqual(remove("!Hi") , "Hi!")
        assert.strictEqual(remove("!Hi!") , "Hi!")
        assert.strictEqual(remove("Hi! Hi!") , "Hi Hi!")
        assert.strictEqual(remove("Hi") , "Hi!")
    })
})
