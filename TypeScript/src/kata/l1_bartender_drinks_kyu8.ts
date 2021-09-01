export function getDrinkByProfession(profession:string){
    let map = new Map([
        ['jabroni', 'Patron Tequila'],
        ['school counselor',	'Anything with Alcohol'],
        ['programmer',	'Hipster Craft Beer'],
        ['bike gang member',	'Moonshine'],
        ['politician',	'Your tax dollars'],
        ['rapper',	'Cristal']
    ]);
    return map.has(profession.toLowerCase()) ? map.get(profession.toLowerCase()) : 'Beer';
}