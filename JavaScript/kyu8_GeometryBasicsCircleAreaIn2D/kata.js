function circleArea(circle){
    return Math.pow(circle.radius, 2) * Math.PI;
}

class Circle {
    constructor(center, radius) {
        this.center = center;
        this.radius = radius;
    }
}

class Point {
    constructor (x,y) {
        this.x = x;
        this.y = y;
    }
}