function grabDoll(dolls){
    var bag=[];
    var proper = ["Hello Kitty","Barbie doll" ]
    for (let doll of dolls) {
        if (bag.length === 3) {
            break;
        }
        if (proper.includes(doll)) {
            bag.push(doll)
            continue
        }
    }
    return bag;
}