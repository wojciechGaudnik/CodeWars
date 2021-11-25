function pickIt(arr){
    var odd=[],even=[];
    for (let e of arr) {
        if (e % 2 === 0) {
            even.push(e)
        } else {
            odd.push(e)
        }
    }
    return [odd, even];
}