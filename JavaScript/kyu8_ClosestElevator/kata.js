function elevator(left, right, call){
    if (Math.abs(left - call) < Math.abs(right - call)) {
        return "left";
    }
    return "right";
}