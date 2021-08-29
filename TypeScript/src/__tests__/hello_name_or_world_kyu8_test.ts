import { assert } from "chai";
import {hello} from "../kata/hello_name_or_world_kyu8";

describe("Basic tests", () => {
    it("Should pass basic tests", () => {
        assert.equal(hello('johN'), 'Hello, John!')
        assert.equal(hello('alice'), 'Hello, Alice!')
        assert.equal(hello(), 'Hello, World!')
        assert.equal(hello(''), 'Hello, World!')
    });
});