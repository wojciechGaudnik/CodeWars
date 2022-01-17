function sc(floor){
    if (floor <= 1) {
        return '';
    }
    if (floor < 7) {
        return 'Aa~ '.repeat(floor - 1) + 'Pa! ' + 'Aa!';
    }
    return 'Aa~ '.repeat(floor - 1) + 'Pa!';
}