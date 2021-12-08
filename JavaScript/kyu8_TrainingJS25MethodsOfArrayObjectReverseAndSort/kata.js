function sortIt(arr){
    let answer = [];
    let dict = {};
    for (let one of arr) {
        if (dict.hasOwnProperty(one)) {
            dict[one] = dict[one] + 1;
        } else {
            dict[one] = 1;
        }
    }
    let values = new Set(Object.values(dict));
    for (let value of  values) {
        let theSameValue = Object.keys(dict).filter(k => dict[k] === value).reverse();
        let multiple = theSameValue.map(e => new Array(value).fill(e)).join();
        answer.push(multiple)
    }
    return answer.join().split(',');
}

console.log(sortIt([1, 2, 3, 4, 4, 5, 5, 6, 6]));
console.log(sortIt([1,1,1,2,2,3]));
