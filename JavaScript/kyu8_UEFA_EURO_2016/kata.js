function uefaEuro2016(teams, scores) {
    if (scores[0] === scores[1]) {
        return `At match ${teams[0]} - ${teams[1]}, teams played draw.`;
    }
    return `At match ${teams[0]} - ${teams[1]}, ${teams[scores.indexOf(Math.max(scores[0], scores[1]))]} won!`;
}