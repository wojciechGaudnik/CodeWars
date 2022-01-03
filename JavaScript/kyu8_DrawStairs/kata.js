function drawStairs(n) {
    let answer = "";
    for (let i = 0; i < n; i++) {
        answer += " ".repeat(i) + "I\n";
    }
    return answer.substring(0,answer.length - 1);
}