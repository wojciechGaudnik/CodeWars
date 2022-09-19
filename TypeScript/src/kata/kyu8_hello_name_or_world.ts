export function hello(name = ''): string {
    return 'Hello, ' + ((name === '' || name.length == 0) ? 'World' : name.charAt(0).toUpperCase() + name.substr(1).toLowerCase()) + '!';
}

console.log(hello())