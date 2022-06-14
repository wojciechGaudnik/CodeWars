function keysAndValues(data){
    let keys = []
    let values = []
    for (let [k, v] of Object.entries(data)) {
        keys.push(k);
        values.push(v)
    }
    return [keys, values];
}
