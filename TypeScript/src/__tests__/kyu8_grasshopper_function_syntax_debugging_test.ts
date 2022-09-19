import { assert } from "chai";
import { main } from "../kata/grasshopper_function_syntax_debugging_kyu8";

describe("Basic tests", () => {
    it("Should pass basic tests", () => {
        assert.equal(main('take ', 'item'), 'take item');
        assert.equal(main('use ', 'sword'), 'use sword');
    });
});