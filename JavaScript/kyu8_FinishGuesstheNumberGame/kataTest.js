describe('Guesser', () => {
    it('Correct guess should return true', () => {
        let guesser = new Guesser(10, 2);
        guesser.guess(10);
        guesser.guess(10);
        guesser.guess(10);
        guesser.guess(10);
        Test.expect(guesser.guess(10));
    });

    it('Wrong guess should return false', () => {
        let guesser = new Guesser(10, 2);
        guesser.guess(1);
        Test.expect(!guesser.guess(1));
    });

    it('Lives ran out should throw', () => {
        let guesser = new Guesser(10, 2);
        guesser.guess(1);
        guesser.guess(2);

        Test.expectError('Expect error already dead', () => { guesser.guess(10); });
    });
});