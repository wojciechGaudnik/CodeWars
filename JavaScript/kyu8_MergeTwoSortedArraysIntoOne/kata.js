function mergeArrays(a, b) {
    return Array.from(new Set(a.concat(b))).sort((n1,n2) => n1 - n2);
}