function startingMark(bodyHeight){
    let a = (9.45 - 10.67) / (1.52 - 1.83)
    let b = 10.67 - a * 1.83
    let y = a * bodyHeight + b;
    return Math.round(y * 100) / 100
}