var obj = {
    name: "Eman",
    age: 22,
    dept: "cs",
};
function getValue(key) {
    return obj[key];
}
console.log(getValue("name"));
console.log(getValue("age"));
console.log(getValue("email"));
