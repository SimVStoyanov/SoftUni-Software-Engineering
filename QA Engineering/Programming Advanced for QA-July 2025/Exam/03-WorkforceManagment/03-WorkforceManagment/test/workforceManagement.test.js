import { workforceManagement } from '../workforceManagement.js'
import { describe } from 'mocha'
import { expect, assert } from 'chai'

describe('Tests for workforceManagment', () => {

    describe('Test recruitStaff', () => {
        it('should should throw an error on invalid role', () => {
            expect(() => workforceManagement.recruitStaff('Merry', 'Аccountant', 8)).to.throw(Error, 'We are not currently hiring for this role.');
            expect(() => workforceManagement.recruitStaff('Peter', 'Architect', 2)).to.throw(Error, 'We are not currently hiring for this role.');
            expect(() => workforceManagement.recruitStaff('Alex', 'Pilot', 7)).to.throw(Error, 'We are not currently hiring for this role.');
        });

        it('should hire worker', () => {
            const result = workforceManagement.recruitStaff('Genadi', 'Developer', 4);
            expect(result).to.equal('Genadi has been successfully recruited for the role of Developer.');
            const result2 = workforceManagement.recruitStaff('Katerina', 'Developer', 10);
            expect(result2).to.equal('Katerina has been successfully recruited for the role of Developer.');
        });

        it('should not hire workers with less than 4 years experience', () => {
            const result = workforceManagement.recruitStaff('Gully', 'Developer', 3);
            expect(result).to.equal('Gully is not suitable for this role.');
            const result2 = workforceManagement.recruitStaff('Valentin', 'Developer', 1);
            expect(result2).to.equal('Valentin is not suitable for this role.');
        });
    });

    describe('Test computeWages', () => {
        it('should return totalPayment with less than or equal to 160 hours', () => {
            const result = workforceManagement.computeWages(89);
            expect(result).to.equal(1602);
            const result2 = workforceManagement.computeWages(160);
            expect(result2).to.equal(2880);
        });

        it('should return totalPayment with bonus over 160 hours', () => {
            const result = workforceManagement.computeWages(161);
            expect(result).to.equal(4398);
        });

        it('should throw an error on invalid hours worked', () => {
            expect(() => workforceManagement.computeWages(-1)).to.throw(Error, "Invalid hours");
            expect(() => workforceManagement.computeWages('сто')).to.throw(Error, "Invalid hours");
            expect(() => workforceManagement.computeWages('88')).to.throw(Error, "Invalid hours");
            expect(() => workforceManagement.computeWages(null)).to.throw(Error, "Invalid hours");
            expect(() => workforceManagement.computeWages(undefined)).to.throw(Error, "Invalid hours");
    
        });
    });

    describe('Test dismissEmployee', () => {
        it('should remove employee', () => {
            const workforce = ['Atanas', 'Dragan', 'Stamat'];
            const result = workforceManagement.dismissEmployee(workforce, 1);
            expect(result).to.equal("Atanas, Stamat");
        });

        it('should throw an error on invalid workforce', () => {
            expect(() => workforceManagement.dismissEmployee(0, 'Atanas', 'Stamat')).to.throw(Error, "Invalid input");
            expect(() => workforceManagement.dismissEmployee('Stamat', 'Ivan', 0)).to.throw(Error, "Invalid input");
        });

        it('should throw an error on invalid employee index', () => {
            expect(() => workforceManagement.dismissEmployee(['Atanas', 'Dragan'], -1)).to.throw(Error, "Invalid input");
            expect(() => workforceManagement.dismissEmployee(['Petar', 'Ivan'], 5)).to.throw(Error, "Invalid input");
            expect(() => workforceManagement.dismissEmployee(['Petar', 'Ivan'], 1.5)).to.throw(Error, "Invalid input");
        });
    });
}); 