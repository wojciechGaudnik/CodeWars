export function usdcny(usd: number): string {
    let cny = usd * 6.75
    let top = cny
    let bottom = cny
    while (top % 0.25 != 0 && bottom % 0.25 != 0) {
        top += 0.1
        bottom -= 0.1
    }
    let ready = String((top % 0.25 == 0) ? top.toFixed(2) : bottom.toFixed(2))
    return ready + ' Chinese Yuan'
}
