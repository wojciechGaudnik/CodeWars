export function checkExam(array1: string[], array2: string[]): number {
    let answer = 0;
    for (var i = 0; i < array1.length; i++) {
        if (array1[i] === array2[i]) {
            answer += 4;
        } else if (array2[i] !== '') {
            answer -=1;
        }
    }
    return (answer < 0) ? 0 : answer;
}