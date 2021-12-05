function shuffleIt(arr, ...arrays){
    for (let one of arrays) {
        let buff = arr[one[1]]
        arr[one[1]] = arr[one[0]];
        arr[one[0]] = buff
    }
    return arr;
}

console.log(shuffleIt([1,2,3,4,5],[1,2],[3,4],[2,3]))