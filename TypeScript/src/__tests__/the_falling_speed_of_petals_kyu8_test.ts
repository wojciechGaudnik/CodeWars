import { assert } from "chai";
import {sakuraFall} from "../kata/the_falling_speed_of_petals_kyu8";

describe("Basic tests", () => {
    it("Should pass basic tests", () => {
        assert.approximately(sakuraFall(5), 80, 1e-9);
        assert.approximately(sakuraFall(10), 40, 1e-9);
        assert.approximately(sakuraFall(200), 2, 1e-9);
        assert.approximately(sakuraFall(-1), 0, 1e-9);
        assert.approximately(sakuraFall(0), 0, 1e-9);
    });
});