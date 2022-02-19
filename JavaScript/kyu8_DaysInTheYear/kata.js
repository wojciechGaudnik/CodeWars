function yearDays(year){
    // return `${year} has ${(new Date(year + 1, 1, 1) - new Date(year, 1, 1)) / (1000 * 3600 * 24)} days`
    return year % 400 === 0 || (year % 100 !== 0 && year % 4 === 0) ? `${year} has 366 days` : `${year} has 365 days`
}

console.log(yearDays(0))
console.log(yearDays(-64))

// return year % 400 === 0 || (year % 100 !== 0 && year % 4 === 0)
let a = new Date(2013, 1, 1);
console.log(new Date(2016))
console.log(a)