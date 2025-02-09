let fruits = ["apple", "strawberry", "banana", "orange", "mango"];

let all = fruits.every((fruit) => {
  typeof fruit === "string";
});
console.log(all);

let some = fruits.some((fruit) => fruit.startsWith("a"));
console.log(some);

let filtered = fruits.filter(
  (fruit) => fruit.startsWith("b") || fruit.startsWith("s")
);
console.log(filtered);

let liked = fruits.map((fruit) => `I like ${fruit}`);
console.log(liked);

liked.forEach((message) => console.log(message));
