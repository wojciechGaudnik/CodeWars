export function bigToSmall(arr: number[][]): string {
    return arr
        .reduce((a, v) => a.concat(v))
        .sort((a, b) => a > b ? -1 : 1)
        .join(">");
}