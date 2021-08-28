import { assert } from "chai";
import {isPalindrome} from "../kata/palindrome_strings_kyu8";

describe("Am I a palindrome?", function() {
    it("Basic tests", function() {
        assert.isTrue(isPalindrome("anna"));
        assert.isFalse(isPalindrome("walter"));
        assert.isTrue(isPalindrome("sator arepo tenet opera rotas"));
        assert.isFalse(isPalindrome("We love Codewars!"));
    });
});