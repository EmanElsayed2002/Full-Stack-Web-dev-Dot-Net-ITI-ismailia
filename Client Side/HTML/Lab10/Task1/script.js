function reverseArgs() {
  let reversedArray = [];
  for (let i = arguments.length - 1; i >= 0; i--) {
    reversedArray.push(arguments[i]);
  }
  return reversedArray;
}

console.log(reverseArgs(1, 2, 3, 4, 5));
console.log(reverseArgs("A", "B", "C"));
