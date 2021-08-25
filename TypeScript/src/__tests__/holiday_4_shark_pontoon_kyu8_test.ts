import { assert } from "chai";
import { shark } from "../kata/holiday_4_shark_pontoon_kyu8";

describe("Basic tests", () => {
    it("Should pass basic tests", () => {
        assert.equal(shark(12, 50, 4, 8, true), "Alive!");
        assert.equal(shark(7, 55, 4, 16, true), "Alive!");
        assert.equal(shark(24, 0, 4, 8, true), "Shark Bait!");
        assert.equal(shark(40, 35, 3, 20, true), "Shark Bait!");
        assert.equal(shark(7, 8, 3, 4, true), "Alive!");
        assert.equal(shark(31, 89, 4, 23, true), "Shark Bait!");
    });
});