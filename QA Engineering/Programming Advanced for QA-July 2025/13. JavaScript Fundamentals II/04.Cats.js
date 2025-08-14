function getCatsData(input) {
    class Cat {
        constructor(name, age) {
            this.name = name;
            this.age = age;
        }

        meow() {
            console.log(`${this.name}, age ${this.age} says Meow`);
        }
    }

    for (let catData of input) {
        let [name, age] = catData.split(' ');
        let cat = new Cat(name, Number(age));
        cat.meow();
    }
}

getCatsData([`Candy 1`, 'Maca 3', `Puh 2`]);
