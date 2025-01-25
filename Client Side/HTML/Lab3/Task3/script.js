var sum = 0;
var valideNumber;
do {
  valideNumber = -1;
  prmpMessage = prompt("please Enter Valid number");
  if (!isFinite(prmpMessage)) {
    valideNumber = Number(prmpMessage);
    if (valideNumber <= 0 || prmpMessage > 100) break;
    sum += valideNumber;
  }
} while (true);

document.write("<h3>Sum: " + sum + "</h3>");
