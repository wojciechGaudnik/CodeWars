function giveMeFive(obj){
    let answer = [];
    for (let element in obj) {
        if (obj.hasOwnProperty(element)) {
            if (element.length === 5) answer.push(element);
            if (obj[element].length === 5) answer.push(obj[element]);
        }
    }
    return answer;
}