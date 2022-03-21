class Warrior {
    constructor(warrior) {
        this.warrior = warrior;
    }

    toString() {
        return `Hi! my name's ${this.warrior}`
    }

    name(warrior) {
        if (warrior) {
            this.warrior = warrior;
        }
        return this.warrior;
    }

}