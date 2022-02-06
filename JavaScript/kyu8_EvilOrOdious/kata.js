function evil(n) {
    return [...(n >>> 0).toString(2)].filter(c => c === '1').length % 2 === 0 ? "It's Evil!" : "It's Odious!";
}