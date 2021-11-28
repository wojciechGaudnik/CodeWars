function splitAndMerge(str, sp) {
    return str.split(" ").map(index => index.split("").join(sp)).join(" ");
}
