function defineSuit(card) {
    var shapes = {
        '♣': 'clubs',
        '♠': 'spades',
        '♦': 'diamonds',
        '♥': 'hearts',
    }
    return shapes[card.slice(-1)]
}
