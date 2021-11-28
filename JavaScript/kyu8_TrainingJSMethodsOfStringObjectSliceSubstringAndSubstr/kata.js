function cutIt(arr){
    var shortest = Number.MAX_VALUE;
    for (let one of arr) {
        if (shortest > one.length) shortest = one.length;
    }
    var answer = [];
    for (let one of arr) {
       answer.push(one.slice(0, shortest))
    }
    return answer;
}