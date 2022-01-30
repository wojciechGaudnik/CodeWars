var hotpo = function (n) {
    var answer = 0;
    while (n > 1) {
        n = func(n)
        answer++;
    }
    return answer;
}

let func = function (number) {
    if (number % 2 === 0) {
        return number / 2
    }
    return (3 * number) + 1
}
