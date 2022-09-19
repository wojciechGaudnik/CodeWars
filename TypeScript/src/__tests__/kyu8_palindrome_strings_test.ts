import { assert } from "chai";
import {isPalindrome} from "../kata/kyu8_palindrome_strings";

describe("Am I a palindrome?", function() {
    it("Basic tests", function() {
        assert.isTrue(isPalindrome("anna"));
        assert.isFalse(isPalindrome("walter"));
        assert.isTrue(isPalindrome("sator arepo tenet opera rotas"));
        assert.isFalse(isPalindrome("We love Codewars!"));
    });
});
