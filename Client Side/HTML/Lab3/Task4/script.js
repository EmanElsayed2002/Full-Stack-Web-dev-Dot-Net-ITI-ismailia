function TwoNumbers() {
  var res = 0;
  if (arguments.length != 2) {
    throw "please enter 2 parameters only";
  }
  for (var i = 0; i < arguments.length; i++) {
    if (typeof arguments[i] === "number") {
      res += arguments[i];
    } else {
      throw "please all parameters are Numbers";
    }
  }
  return res;
}

var result = TwoNumbers(2, 2);
console.log(result);

// console.log(Math.max(1, 2, "3eman"));

// console.log(Math.round(Math.random() * 10));

var d = new Date("8-21-2002");
console.log(d);

var x = [];
var x = [];
console.log(x);
