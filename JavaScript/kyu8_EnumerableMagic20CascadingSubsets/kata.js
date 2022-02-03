function eachCons(array, n) {
    let answer = [];
    for (let i = 0; i <= array.length - n; i++) {
        answer.push(array.slice(i, i + n));
    }
    return answer;
}