function whoseMove(lastPlayer, win) {
    return win ? lastPlayer : lastPlayer === "black" ? "white" : "black";
}