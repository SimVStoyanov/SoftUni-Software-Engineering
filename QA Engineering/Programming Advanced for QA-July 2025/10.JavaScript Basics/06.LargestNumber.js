function solve(a, b, c){
    let maxNumber = Number.MIN_SAFE_INTEGER;

    if(a > maxNumber){
        maxNumber = a;
    }

    if(b > maxNumber){
        maxNumber = b;
    }

    if(c > maxNumber){
        maxNumber = c;
    }

    console.log(`The largest number is ${maxNumber}.`)
}

solve(3, -5, 12)
solve(13, 5, 12)
solve(-3, -5, -12)