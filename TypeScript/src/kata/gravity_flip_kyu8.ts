export function flip(dir: string, arr: number[]): number[] {
    return ((dir === 'R') ?
        arr.sort((e1, e2) => (e1 > e2) ? 1 : -1) :
        arr.sort((e1, e2) => (e1 < e2) ? 1 : -1));
}

console.log(flip('R', [3, 2, 1, 2]), [1, 2, 2, 3])