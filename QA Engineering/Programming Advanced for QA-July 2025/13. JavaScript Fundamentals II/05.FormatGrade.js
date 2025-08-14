function printGrade(grade) {
    let result = "";

    if (grade < 3) {
        result = "Fail";
        console.log(`${result} (2)`);
        return;
    } else if (grade < 3.5) {
        result = "Poor";
    } else if (grade < 4.5) {
        result = "Good";
    } else if (grade < 5.5) {
        result = "Very good";
    } else {
        result = "Excellent";
    }

    console.log(`${result} (${grade.toFixed(2)})`);
}

printGrade(2.99)