const isSantaClausable = require('./kata.js')
const chai = require("chai")
const assert = chai.assert;

describe('SantaClausable Interface', function() {
    var santa = {
        sayHoHoHo: function() { console.log('Ho Ho Ho!') },
        distributeGifts: function() { console.log('Gifts for all!'); },
        goDownTheChimney: function() { console.log('*whoosh*'); }
    };

    var notSanta = {
        sayHoHoHo: function() { console.log('Oink Oink!') }
    };

    it('should implement the SantaClausable interface', function() {
        assert.equal(isSantaClausable(santa), true);
    });

    it('should not implement the SantaClausable interface', function() {
        assert.equal(isSantaClausable(notSanta), false);
    });
});
