interface Iobj {
  name?: string;
  age?: number;
  dept?: string;
}

let obj: Iobj = {
  name: "Eman",
  age: 22,
  dept: "cs",
};

function getValue(key: "name" | "age" | "dept") {
  return obj[key];
}

console.log(getValue("name"));
console.log(getValue("age"));
console.log(getValue("email"));
