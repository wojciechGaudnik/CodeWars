export function mouthSize(animal: string): string {
    return (animal.toLocaleLowerCase() == 'alligator' ? 'small' : 'wide')
}