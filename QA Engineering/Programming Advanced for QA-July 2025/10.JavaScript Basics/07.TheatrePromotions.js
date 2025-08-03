function solve(tariff, clientAge) {
    
    let price = 0;

    if (0 <= clientAge && clientAge <= 18) {
        switch(tariff) {
            case "Weekday": 
                price = 12;
                break;
                case "Weekend":
                price = 15;
                break;
            case "Holiday":
                price = 5;
                break;
        }
    } else if (18 < clientAge && clientAge <=64) {
        switch(tariff) {
            case "Weekday": 
                price = 18;
                break;
            case "Weekend":
                price = 20;
                break;
            case "Holiday":
                price = 12;
                break;
        }
    } else if (64 < clientAge && clientAge <=122) {
        switch(tariff) {
            case "Weekday": 
                price = 12;
                break;
            case "Weekend":
                price = 15;
                break;
            case "Holiday":
                price = 10;
                break;
            }
    } else {
        console.log("Error!");
    }

    if (price > 0) {
        console.log(`${price}$`);
    }
}
