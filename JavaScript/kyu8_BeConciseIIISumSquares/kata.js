function sumSquares(array) {
    return array.reduce((prev, curr) => prev + Math.pow(curr, 2), 0);
}