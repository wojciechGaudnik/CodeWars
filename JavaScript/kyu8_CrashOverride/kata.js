const lastName = {
    A: 'Analogue',
    B: 'Bomb',
    C: 'Catalyst',
    D: 'Discharge',
    E: 'Electron',
    F: 'Faraday',
    G: 'Gig',
    H: 'Hacker',
    I: 'IP',
    J: 'Jabber',
    K: 'Killer',
    L: 'Lazer',
    M: 'Mike',
    N: 'n00b',
    O: 'Overclock',
    P: 'Payload',
    Q: 'Quark',
    R: 'Roy',
    S: 'Spy',
    T: 'T-Rex',
    U: 'Unit',
    V: 'Virus',
    W: 'Worm',
    X: 'X',
    Y: 'Yob',
    Z: 'Zombie',
}

function aliasGen(firstNameParam, lastNameParam){
    if (!/[a-z]/gi.test(firstNameParam[0]) || !/[a-z]/gi.test(lastNameParam[0])){
        return 'Your name must start with a letter from A - Z.'
    }
    return `${firstName[firstNameParam[0].toUpperCase()]} ${lastName[lastNameParam[0].toUpperCase()]}`;
}