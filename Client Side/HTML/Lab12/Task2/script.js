function findMinMax(...numbers) {
  return {
    max: Math.max(...numbers),
    min: Math.min(...numbers),
  };
}
let numbers = [10, 20, 30, 433];
let { min, max } = findMinMax(...numbers);
console.log(min);
console.log(max);
