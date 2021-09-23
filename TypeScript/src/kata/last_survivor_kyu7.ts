export function lastSurvivor(letters: string, coords: number[]): string {
    let splited = letters.split('');
    for (let v of coords) {
       splited.splice(v, 1)
    }
    return splited.join('')
}