function addLength(str) {
    let answer = [];
    for (let word of str.split(' ')) {
        answer.push(`${word} ${word.length}`)
    }
    return answer;
}