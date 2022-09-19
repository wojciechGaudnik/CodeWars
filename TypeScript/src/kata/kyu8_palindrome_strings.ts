export function isPalindrome(line: string): boolean {
    return line.split('').reverse().join('') == line;
}