var NoOfTry = 3;
var lst = [];
while (NoOfTry--) {
  num = prompt("Enter the number: ");
  while (isNaN(num) && num) {
    num = prompt("Enter valid number!!!");
  }
  lst.push(num);
}
console.log(lst);
function add() {
  var sum = 0;
  for (var item in lst) {
    sum += Number(lst[item]);
  }
  return sum;
}

function multi() {
  var sum = 1;
  for (var item in lst) {
    sum *= Number(lst[item]);
  }
  return sum;
}

function divide() {
  var sum = Number(lst[0]);
  for (var i = 1; i < lst.length; i++) {
    sum /= Number(lst[i]);
  }
  return sum;
}

document.write("<h3>Add ----->" + lst.join("+") + " = " + add() + "</h3>");
document.write("<h3>div ----->" + lst.join("/") + " = " + divide() + "</h3>");
document.write("<h3>muli ----->" + lst.join("*") + " = " + multi() + "</h3>");
