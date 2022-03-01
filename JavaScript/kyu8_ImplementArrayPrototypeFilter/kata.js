Array.prototype.filter = function (func) {
    let answer = []
    for (let one of this) {
        if (func(one)){
            answer.push(one)
        }
    }
    return answer;
}