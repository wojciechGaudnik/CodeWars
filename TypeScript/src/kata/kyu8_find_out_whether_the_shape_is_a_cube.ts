export function cubeChecker(volume: number, side: number): boolean {
    return (volume == 0 || side == 0) ? false : Math.pow(side, 3) == volume;
}