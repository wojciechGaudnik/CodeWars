function power(x,y){
    if (y > 0 && y < 701270) {
        return (x * power(x, y - 1));
    } else {
        return 1;
    }
}