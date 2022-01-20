function cookie(x) {
    if (x instanceof String || typeof (x) === 'string') {
        return "Who ate the last cookie? It was Zach!";
    }
    if (x instanceof Number || typeof (x) === 'number') {
        return "Who ate the last cookie? It was Monica!"
    }
    return "Who ate the last cookie? It was the dog!"
}