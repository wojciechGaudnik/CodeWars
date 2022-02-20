const unchurch = n => n(x=>x+1)(0) ;
const church = n => n ? SUCC(church(n-1)) : ZERO ;

describe("Factorial Lambda Calculus",()=>{
    it("Example tests",()=>{
        assert.strictEqual( unchurch(FACTORIAL(ZERO)), 1 );
        assert.strictEqual( unchurch(FACTORIAL(ONE)), 1 );
        assert.strictEqual( unchurch(FACTORIAL(TWO)), 2 );
        assert.strictEqual( unchurch(FACTORIAL(THREE)), 6 );
        assert.strictEqual( unchurch(FACTORIAL(FOUR)), 24 );
        assert.strictEqual( unchurch(FACTORIAL(FIVE)), 120 );
    });
});