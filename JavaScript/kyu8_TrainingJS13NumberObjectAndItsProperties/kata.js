function whatNumberIsIt(n){
    var answer = "Input number is "
    if (n === Number.MAX_VALUE) return answer + "Number.MAX_VALUE"
    if (n === Number.MIN_VALUE) return answer + "Number.MIN_VALUE"
    if (isNaN(n)) return answer + "Number.NaN"
    if (n === Number.POSITIVE_INFINITY) return answer + "Number.POSITIVE_INFINITY"
    if (n === Number.NEGATIVE_INFINITY) return answer + "Number.NEGATIVE_INFINITY"
    return answer + n
}
