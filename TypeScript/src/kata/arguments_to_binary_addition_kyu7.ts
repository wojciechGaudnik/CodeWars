export function arr2bin(arr: any[]): string{
    let sum  = 0;
    for (let entry of arr) {
        if (typeof entry === 'number') {
            sum += entry
        }
    }
    return sum.toString(2)
}