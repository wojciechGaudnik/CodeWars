function yourFutureCareer() {
    var career = Math.random()
    if (career <= 0.32) {
        return 'FrontEnd Developer'
    }
    if (career <= 0.65) {
        return 'BackEnd Developer'
    }
    return 'Full-Stack Developer'
}