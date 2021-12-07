function threeInOne(arr) {
    let answer = [];
    for (let i = 0; i < arr.length; i = i + 3) {
        answer.push(arr.slice(i, i + 3).reduce((a, b) => a + b))
    }
    return answer;
}
