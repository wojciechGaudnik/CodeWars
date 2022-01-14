var a = {'Mike':'aye','Joe':'aye','Johnson':'aye','Peter':'aye'},
    b = {'Mike':'aye','Joe':'nay','Johnson':'aye','Peter':'aye'};

const cannonsReady = (gunners) => {
    return Object.values(gunners).every(gunner => gunner === 'aye')? 'Fire!': 'Shiver me timbers!'
}

console.log(cannonsReady(a))