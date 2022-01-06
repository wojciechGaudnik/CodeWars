function whoIsPaying(name) {
    if (name.length <= 2) {
        return [name];
    }
    return [name, name.substr(0, 2)]
}
