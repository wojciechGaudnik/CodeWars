function yearDays(year){
    return year % 400 === 0 || (year % 100 !== 0 && year % 4 === 0) ? `${year} has 366 days` : `${year} has 365 days`
}