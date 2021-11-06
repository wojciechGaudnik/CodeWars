function array(arr){
    let splitted = arr.split(',');
    if (splitted.length < 3) {
        return null;
    }
    return splitted.slice(1, -1).join(' ').toString();
}

module.exports = {array}