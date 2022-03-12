function wrap(value) {
    return {
        value:value
    };
}

let res = wrap("MyTest")
console.log(res)
console.log(typeof res)
console.log(res.value)
console.log(wrap(343).value)