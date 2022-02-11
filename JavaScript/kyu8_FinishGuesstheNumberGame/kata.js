class Guesser {
    constructor(number, lives) {
        this.number = number;
        this.lives = lives;
    }

    guess(n) {
        if (!this.lives) {
            throw new Error("You have no more lives!");
        }
        if (n === this.number) {
            return true;
        }
        this.lives--;
        return false;
    }
}