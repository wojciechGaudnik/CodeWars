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

// n[0] = 1
// n - 1 * i


function daysBetween(startDate, endDate) {
    let first = new Date(startDate).getTime()
    let second = new Date(endDate).getTime()
    let bigger = Math.max(first, second)
    let smaller = Math.min(first, second)
    let dayDivider = 1000 * 3600 * 24
    return Math.ceil((bigger - smaller) / dayDivider)
}


console.log(daysBetween("2022-01-01", "2022-01-01") === 0);
console.log(daysBetween("2022-01-01", "2022-01-02") === 1);
console.log(daysBetween("2022-01-02", "2022-01-01") === 1);
console.log(daysBetween("2022-01-01", "2022-12-30") === 363);
console.log(daysBetween("2020-01-19", "2022-11-15") === 1031);
console.log(daysBetween("1994-06-28", "2022-11-15") === 10367);
console.log(daysBetween("1981-06-23", "2022-11-15") === 15120);
