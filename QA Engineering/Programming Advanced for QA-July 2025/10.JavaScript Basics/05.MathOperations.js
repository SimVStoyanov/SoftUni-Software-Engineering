function solve(a, b, operator){
    let result;

    if (operator === '+'){
        result = a + b;
    } else if (operator === '-'){
        result = a - b;
    } else if (operator === '*'){
        result = a * b;
    } else if (operator === '/'){
        result = a / b;
    } else if (operator === '%'){
        result = a % b;
    } else if (operator === '**'){
        result = a ** b;
    }

    console.log(result)
}

solve(5, 5, '+')
solve(5, 5, '-')
solve(5, 5, '*')
solve(5, 5, '/')
solve(7, 5, '%')
solve(5, 3, '**')