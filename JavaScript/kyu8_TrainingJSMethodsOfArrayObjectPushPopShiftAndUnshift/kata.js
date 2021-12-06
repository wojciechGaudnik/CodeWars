function infiniteLoop(arr, d, n) {
    let flatter = flat(arr)
    let answer = []
    let start = 0;
    if (d === "left") {
        flatter = shift(flatter, -1, n)
    } else {
        flatter = shift(flatter, 1, n)
    }
    collect(arr, answer, flatter, start);
    return answer;
}

function flat(array) {
    let answer = [];
    for (let first of array) {
        for (let second of first) {
            answer.push(second)
        }
    }
    return answer
}

function shift(arr, direction, n) {
    var times = n > arr.length ? n % arr.length : n;
    return arr.concat(arr.splice(0, (direction > 0 ? arr.length - times : times)));
}

function collect(arr, answer, flatter, start) {
    for (let one of arr) {
        answer.push(flatter.slice(start, start + one.length));
        start += one.length
    }
}