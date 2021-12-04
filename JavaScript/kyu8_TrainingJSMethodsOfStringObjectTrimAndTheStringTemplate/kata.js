function fiveLine(s){
    return [...Array(5).keys()].map(x => x + 1).map(x => s.trim().repeat(x)).join('\n');
}
