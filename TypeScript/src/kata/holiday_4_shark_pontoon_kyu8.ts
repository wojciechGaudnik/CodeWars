
export function shark(pontoonDistance: number, sharkDistance: number, youSpeed: number, sharkSpeed: number, dolphin: boolean): string {
    if (dolphin) {
        sharkSpeed /= 2;
    }
    return (pontoonDistance/youSpeed < (sharkDistance) / sharkSpeed) ? 'Alive!' : 'Shark Bait!';
}