import { expect } from "chai";
import {SafeInteger} from "../kata/is_integer_safe_to_use_kyu8";

describe("SafeInteger", function() {
    it("should return false for 9007199254740992", () => {
        expect(SafeInteger(9007199254740992)).to.equal(false);
    });

    it("should return true for 9007199254740990", () => {
        expect(SafeInteger(9007199254740990)).to.equal(true);
    });
});
