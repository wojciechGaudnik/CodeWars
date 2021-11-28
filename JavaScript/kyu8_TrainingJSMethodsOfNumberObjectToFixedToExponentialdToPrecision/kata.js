function howManySmaller(arr, n) {
    return arr.map(e => Math.round(e * 100 + Number.EPSILON) / 100).filter(value => value < n).length;
}