function reverseInPlace(arr){
    for (let i = 0; i < arr.length / 2; i++)
 {
        let currentElement = arr[i] 

        arr[i] = arr[arr.length - 1 - i] 
        
        arr[arr.length - 1 - i] = currentElement 
    }

    console.log(arr.join(' '))
}

//reverseInPlace([10, 20, 30, 40, 50])