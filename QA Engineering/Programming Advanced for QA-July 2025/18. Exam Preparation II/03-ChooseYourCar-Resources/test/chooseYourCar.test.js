import { chooseYourCar } from '../chooseYourCar.js'
import { describe } from 'mocha'
import { expect, assert } from 'chai';

describe('Test chooseYourCar', () => {

    describe('choosingType', () => {
        it('should throw an error on invalid input', () => {
            expect(() => chooseYourCar.choosingType('Sedan', 'red', 1800)).to.throw(Error, "Invalid Year!");
            expect(() => chooseYourCar.choosingType('Sedan', 'red', 2025)).to.throw(Error, "Invalid Year!");
            expect(() => chooseYourCar.choosingType('Truck', 'green', 2015)).to.throw(Error, "This type of car is not what you are looking for.");
        });

        it('should throw an error on invalid year', () => {
            expect(() => chooseYourCar.choosingType('Sedan', 'red', 1800)).to.throw(Error, "Invalid Year!");
            expect(() => chooseYourCar.choosingType('Sedan', 'red', 2025)).to.throw(Error, "Invalid Year!");
        });

        it('should throw an error on invalid type', () => {
            expect(() => chooseYourCar.choosingType('Truck', 'green', 2015)).to.throw(Error, "This type of car is not what you are looking for.");
        });

        it('should meet requirements for a Sedan >= 2010', () => {
            let result = chooseYourCar.choosingType('Sedan', 'red', 2010);
            expect(result).to.equal("This red Sedan meets the requirements, that you have.");
        });

        it('should meet requirements for a Sedan < 2010', () => {
            let result = chooseYourCar.choosingType('Sedan', 'blue', 2005);
            expect(result).to.equal("This Sedan is too old for you, especially with that blue color.");
        });

        it('should meet requirments for a car', () => {
            const type = "Sedan";
            const color = "red";
            const year = 2015;
            const expected = "This red Sedan meets the requirements, that you have.";
            const result = chooseYourCar.choosingType(type, color, year);
            expect(result).to.equal(expected);
        });

        it('should not meet requirments for a car', () => {
            const type = "Sedan";
            const color = "blue";
            const year = 2007;
            const expected = "This Sedan is too old for you, especially with that blue color.";
            const result = chooseYourCar.choosingType(type, color, year);
            expect(result).to.equal(expected);
        });
    });

    describe('brandName', () => {
        it('should throw an error on invalid input', () => {
            expect(() => chooseYourCar.brandName('Audi', 3)).to.throw(Error, "Invalid Information!");
            expect(() => chooseYourCar.brandName(["Audi", "BMW"], 3.5)).to.throw(Error, "Invalid Information!");
            expect(() => chooseYourCar.brandName(["Audi", "BMW"], -1)).to.throw(Error, "Invalid Information!");
            expect(() => chooseYourCar.brandName(["Audi", "BMW"], 5)).to.throw(Error, "Invalid Information!");
            expect(() => chooseYourCar.brandName(123, 0)).to.throw(Error, "Invalid Information!");
        });

        it('should return the correct brands', () => {
            const brand = ["Audi", "BMW", "Peugeot"];
            const brandIndex = 1;
            const expected = "Audi, Peugeot";
            const result = chooseYourCar.brandName(brand, brandIndex);
            expect(result).to.equal(expected);
        });
    });

    describe('carFuelConsumption', () => {
        it('should throw an error on invalid input', () => {
            expect(() => chooseYourCar.carFuelConsumption('100', 5)).to.throw(Error, "Invalid Information!");
            expect(() => chooseYourCar.carFuelConsumption(100, -5)).to.throw(Error, "Invalid Information!");
            expect(() => chooseYourCar.carFuelConsumption(0, 5)).to.throw(Error, "Invalid Information!");
            expect(() => chooseYourCar.carFuelConsumption(100, "8")).to.throw(Error, "Invalid Information!");
        });

        it('should return message for an efficient car', () => {
            const liters = 5;
            const distance = 100;
            const expected = "The car is efficient enough, it burns 5.00 liters/100 km.";
            const result = chooseYourCar.carFuelConsumption(distance, liters);
            expect(result).to.equal(expected);
        });

        it('should return message for an non-efficient car', () => {
            const liters = 12;
            const distance = 100;
            const expected = "The car burns too much fuel - 12.00 liters!";
            const result = chooseYourCar.carFuelConsumption(distance, liters);
            expect(result).to.equal(expected);
        });

        it(`should return message for a non-efficient car`, () => {
            let result = chooseYourCar.carFuelConsumption(100, 10);
            expect(result).to.equal("The car burns too much fuel - 10.00 liters!");
        });

        it('should currently round fuel consumption', () => {
            let result = chooseYourCar.carFuelConsumption(150, 10.5);
            expect(result).to.equal("The car is efficient enough, it burns 7.00 liters/100 km.");
        });

        it('should currently identify non-efficient when slightly above 7', () => {
            let result = chooseYourCar.carFuelConsumption(100, 7.01);
            expect(result).to.equal("The car burns too much fuel - 7.01 liters!");
        });
    });

});