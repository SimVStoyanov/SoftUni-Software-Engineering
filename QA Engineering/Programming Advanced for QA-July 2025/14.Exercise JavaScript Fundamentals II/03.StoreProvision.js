function storeProvision (currentStock, orderedProducts){
    let store = {}

    for (let i = 0; i < currentStock.length; i+=2) {
        let productName = currentStock[i];
        let quantity = Number(currentStock[i+1])
        
        store[productName] = quantity
    }

    for (let i = 0; i < orderedProducts.length; i+=2) {
        let productName = orderedProducts[i];
        let quantity = Number(orderedProducts[i+1])
        
        if(store.hasOwnProperty(productName)){
            store[productName] += quantity  
        } else {
            store[productName] = quantity  
        }
    }

    for (const key in store) {
        console.log(`${key} -> ${store[key]}`)
    }
}