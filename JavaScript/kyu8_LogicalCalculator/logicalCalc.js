export default function logicalCalc(array, op){
    switch (op) {
        case 'AND':
            for (let one of array) {
                if (one === false) {
                    return false
                }
            }
            return true;
        case 'OR':
            for (let one of array) {
                if (one === true) {
                    return true
                }
            }
            return false
        case 'XOR':
            if (array.length === 1) return array[0];
            return array.reduce((p, c) => p ^ c) === 1
    }
}
