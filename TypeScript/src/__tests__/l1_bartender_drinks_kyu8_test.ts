// import the type of assertion library you wish to use (Chai recommended)
import {assert} from "chai";
import {getDrinkByProfession} from "../kata/l1_bartender_drinks_kyu8";

describe("Testing...", function(){
    it("Basic tests", function() {
        assert.equal(getDrinkByProfession("jabrOni"), "Patron Tequila", "'Jabroni' should map to 'Patron Tequila'");
        assert.equal(getDrinkByProfession("scHOOl counselor"), "Anything with Alcohol", "'School Counselor' should map to 'Anything with alcohol'");
        assert.equal(getDrinkByProfession("prOgramMer"), "Hipster Craft Beer", "'Programmer' should map to 'Hipster Craft Beer'");
        assert.equal(getDrinkByProfession("bike ganG member"), "Moonshine", "'Bike Gang Member' should map to 'Moonshine'");
        assert.equal(getDrinkByProfession("poLiTiCian"), "Your tax dollars", "'Politician' should map to 'Your tax dollars'");
        assert.equal(getDrinkByProfession("rapper"), "Cristal", "'Rapper' should map to 'Cristal'");
        assert.equal(getDrinkByProfession("pundit"), "Beer", "'Pundit' should map to 'Beer'");
        assert.equal(getDrinkByProfession("Pug"), "Beer", "'Pug' should map to 'Beer'");
    });
});