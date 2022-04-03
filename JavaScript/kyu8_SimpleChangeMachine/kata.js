// noinspection NonAsciiCharacters

function changeMe(moneyIn){
    let validMoney = {'£5': 500, '£2': 200, '£1': 100, '50p': 50, '20p': 20}
    if (!Object.keys(validMoney).includes(moneyIn)) {
        return moneyIn;
    }
    if (moneyIn === '20p') {
        return '10p 10p'
    }
    let moneyInP = validMoney[moneyIn];
    let twentyMultiplier = Math.floor(moneyInP / 20);
    moneyInP -= twentyMultiplier * 20;
    let tenMultiplier = Math.floor(moneyInP / 10);
    moneyInP -= tenMultiplier * 10;
    if (moneyInP !== 0) {
        throw new Error("There is no way to exchange money");
    }
    return ('20p '.repeat(twentyMultiplier) + '10p '.repeat(tenMultiplier)).trimRight();
}

console.log(changeMe('50p'));