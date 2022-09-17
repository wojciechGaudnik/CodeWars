function sumEvenNumbers(input) {
    return input.filter(e => e % 2 === 0).reduce((a, b) => a + b, 0)
}
