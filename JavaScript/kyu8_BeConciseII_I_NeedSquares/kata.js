let squaresOnly = (a) => {
    return a.filter(n => Math.sqrt(n) % 2 === 0 || Math.sqrt(n) % 1 === 0);
}
