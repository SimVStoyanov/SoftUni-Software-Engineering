describe('Test analyzeArray', () => {

    it('should return undefined if input is not an array', () => {
        expect(analyzeArray(42)).to.be.undefined;
        expect(analyzeArray('test')).to.be.undefined;
        expect(analyzeArray({})).to.be.undefined;
        expect(analyzeArray(null)).to.be.undefined;
        expect(analyzeArray(undefined)).to.be.undefined;
    });

    it('should return undefined if input is an empty array', () => {
        expect(analyzeArray([])).to.be.undefined;
    });

    it('should return undefined if array contains non-number element', () => {
        expect(analyzeArray([1, 2, '3'])).to.be.undefined;
        expect(analyzeArray([1, null, 3])).to.be.undefined;
        expect(analyzeArray([1, {}, 3])).to.be.undefined;
        expect(analyzeArray([1, undefined, 3])).to.be.undefined;
    });

    it('should return correct min, max, and length for array of numbers', () => {
        const result = analyzeArray([3, 7, 2, 9, 5]);
        expect(result).to.deep.equal({ min: 2, max: 9, length: 5 });
    });

    it('should handle single element array', () => {
        const result = analyzeArray([5]);
        expect(result).to.deep.equal({ min: 5, max: 5, length: 1 });
    });

    it('should handle array with equal elements', () => {
        const result = analyzeArray([4, 4, 4, 4]);
        expect(result).to.deep.equal({ min: 4, max: 4, length: 4 });
    });

    it('should handle negative numbers', () => {
        const result = analyzeArray([-3, -7, -1, -5]);
        expect(result).to.deep.equal({ min: -7, max: -1, length: 4 });
    });

    it('should handle floating point numbers', () => {
        const result = analyzeArray([1.5, 2.2, 0.8, 3.1]);
        expect(result).to.deep.equal({ min: 0.8, max: 3.1, length: 4 });
    });

});