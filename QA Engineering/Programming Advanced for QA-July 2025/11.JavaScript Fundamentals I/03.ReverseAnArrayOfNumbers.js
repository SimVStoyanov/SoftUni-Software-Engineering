function reverseArr(n, arr){
    let newArr = arr.slice(0, n).reverse()

    console.log(newArr.join(' '))
}

//reverseArr(3, [10, 20, 30, 40, 100])
//reverseArr(2, [5, 300, 30, 40, 100])