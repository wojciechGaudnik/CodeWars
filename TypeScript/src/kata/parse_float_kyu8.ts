export function parseF(s:string):number | null {
    return isNaN(parseFloat(s)) ? null: parseFloat(s);
}