class Kata {
}

const arr = (N: number) => {
    if (isNaN(N)) {
        return Array.from(Array(0).keys());
    }
    return Array.from(Array(N).keys());
}
console.log(arr(NaN))


