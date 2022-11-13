function getChain(n) {

    let answer = [1]
    for (let i = 1; i < n; i++) {
        answer.push((answer[i - 1] * i));
    }
    return answer
}

console.log(getChain(1).join(',') === [1].join(','))
console.log(getChain(2).join(',') === [1, 1].join(','))
console.log(getChain(3).join(',') === [1, 1, 2].join(','))
console.log(getChain(4).join(',') === [1, 1, 2, 6].join(','))
console.log(getChain(5).join(',') === [1, 1, 2, 6, 24].join(','))
console.log(getChain(6).join(',') === [1, 1, 2, 6, 24, 120].join(','))
console.log(getChain(7).join(',') === [1, 1, 2, 6, 24, 120, 720].join(','))
console.log(getChain(8).join(',') === [1, 1, 2, 6, 24, 120, 720, 5040].join(','))
console.log(getChain(9).join(',') === [1, 1, 2, 6, 24, 120, 720, 5040, 40320].join(','))

n[0] = 1
n - 1 * i
