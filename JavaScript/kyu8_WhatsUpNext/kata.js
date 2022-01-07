const nextItem = (xs, item) => {
    let isAvailable = false;
    let answer = undefined;
    for (let one of xs) {
        if (isAvailable) {
            return one;
        }
        if (one === item) {
            isAvailable = true;
        }
    }
    return answer;
}