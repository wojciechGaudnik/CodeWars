const cannonsReady = (gunners) => {
    return Object.values(gunners).every(gunner => gunner === 'aye')? 'Fire!': 'Shiver me timbers!'
}