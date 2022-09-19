import { expect } from "chai";
import {arr} from "../kata/kyu8_filling_an_array_part_1";

describe("Basic tests", () => {
    it("Should return an array", () => {
        expect(arr()).to.be.an('array');
    });

    it("Should return a blank array when called with no argument", () => {
        expect(arr()).to.deep.equal([]);
    });

    it("Should return 0 to 3 when called with 4", () => {
        expect(arr(4)).to.deep.equal([0,1,2,3]);
    });
});
