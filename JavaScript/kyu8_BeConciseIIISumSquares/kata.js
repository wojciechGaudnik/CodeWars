function sumSquares(array) {
    return array.reduce((prev, curr) => prev + Math.pow(curr, 2), 0);
}

console.log(sumSquares([1,2,3,4,5]))