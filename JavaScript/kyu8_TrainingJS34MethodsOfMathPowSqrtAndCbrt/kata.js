function cutCube(volume,n){
    let isCube = (m) => Number.isInteger(Math.cbrt(m));
    return isCube(n) && isCube(volume / n)
}