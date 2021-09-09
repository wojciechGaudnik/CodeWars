// Import a Chai assertion style: assert, expect, or should
import {expect} from "chai";
import {Cube} from "../kata/playing_with_cubes2_kyu8"

// TODO: TDD development by writing your own tests

describe("Cube", function(){

    describe('new Cube(10)', () => {
        it('constructs a new cube with side length 10', () => {
            expect(new Cube(10).getSide()).to.equal(10);
            expect(new Cube().getSide()).to.equal(0);
        });
    });

});