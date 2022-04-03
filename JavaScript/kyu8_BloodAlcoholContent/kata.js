function bloodAlcoholContent(drinks, weight, sex, H){
    let A = drinks.ounces * drinks.abv;
    let W = weight;
    let r = sex === 'male' ? 0.73 : 0.66;
    return parseFloat(Number(A * 5.14 / W * r - 0.015 * H).toFixed(4));
}
