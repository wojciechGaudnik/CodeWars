function numberToPower(number, power){
    if (number === 0) return 0;
    let answer = 1;
    while (power-- > 0) {
       answer *= number
    }
    return answer;
}

console.log(numberToPower(3,3))