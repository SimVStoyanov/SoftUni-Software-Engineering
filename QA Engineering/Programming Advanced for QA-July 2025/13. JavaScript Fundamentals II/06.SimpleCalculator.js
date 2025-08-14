function calculator(firstNumber, secondNumber, operator) {

    let addFunction = (firstNumber, secondNumber) => firstNumber + secondNumber;
    let substractFunction = (firstNumber, secondNumber) => firstNumber - secondNumber;
    let multiplyFunction = (firstNumber, secondNumber) => firstNumber * secondNumber;
    let divideFunction = (firstNumber, secondNumber) => firstNumber / secondNumber; 

switch (operator) {
    case `add`:
        console.log(addFunction(firstNumber, secondNumber));
        break;
    case `subtract`:
        console.log(substractFunction(firstNumber, secondNumber));
        break;
    case `multiply`:
        console.log(multiplyFunction(firstNumber, secondNumber));
        break;
    case `divide`:
        console.log(divideFunction(firstNumber, secondNumber));
        break;
    default:
        console.log(`Invalid operator`);
        break;
    }
}

calculator(5,5,`multiply`);
calculator(40,8,`divide`); 
calculator(12,19,`add`);
calculator(50,13,`subtract`);
calculator(10,2,`add`);
