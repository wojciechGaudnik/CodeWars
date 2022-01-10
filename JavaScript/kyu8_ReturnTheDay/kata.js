function whatday(num) {
    if (num < 1 || num > 7) {
        return 'Wrong, please enter a number between 1 and 7';
    }
    return new Date(2022, 1, num + 5).toLocaleString('en-us', {  weekday: 'long' })
}
