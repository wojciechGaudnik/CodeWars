class Cube {

    private _side: number;

    constructor(side?: number) {
        this._side = Math.abs(side || 0);
    }

    public getSide(): number {
        return this._side;
    }

    public setSide(value: number) {
        this._side = Math.abs(value);
    }
}

export {Cube}