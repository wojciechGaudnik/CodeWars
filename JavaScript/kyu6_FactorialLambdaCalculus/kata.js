ZERO  = s => z => z
ONE   = s => z => s(z)
TWO   = s => z => s(s(z))
THREE = s => z => s(s(s(z)))
FOUR  = s => z => s(s(s(s(z))))
FIVE  = s => z => s(s(s(s(s(z)))))
SUCC  = n => s => z => s(n(s)(z))
PRED  = n => n-1                       //  actually defined differently :]
TRUE  = t => f => t
FALSE = t => f => f
IS_ZERO = n => n ( _ => FALSE) (TRUE)

const FACTORIAL = (n) => {
    return NUM_ONE;
}

console.log(FACTORIAL(ZERO))