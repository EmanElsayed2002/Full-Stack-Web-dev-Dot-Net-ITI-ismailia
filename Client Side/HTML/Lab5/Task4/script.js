do {
  var prmpt = prompt("Enter Your Birth Date (DD-MM-YYYY)");

  var bool =
    prmpt.length == 10 &&
    prmpt.split("-").length == 3 &&
    check(0, 2, 1, 30) &&
    check(3, 5, 1, 12) &&
    check(6, 11, 1000, 2025);
  console.log(check(6, 11, 1000, 2025));
  var day = Number(prmpt.slice(0, 2));
  var month = Number(prmpt.slice(3, 5));
  var year = Number(prmpt.slice(6, 11));
} while (!bool);

var NewDate = new Date(year, month, day);
// console.log(NewDate);
document.write("<h3>" + NewDate + "</h3>");

function check(start, end, startvalue, endvalue) {
  return (
    !isNaN(prmpt.slice(start, end)) &&
    Number(prmpt.slice(start, end)) >= startvalue &&
    Number(prmpt.slice(start, end) <= endvalue)
  );
}
