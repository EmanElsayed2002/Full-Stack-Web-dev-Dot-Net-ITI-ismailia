var actualNumber = Math.floor(Math.random() * 20) + 5;

do {
  do {
    var prmpt = prompt("Please Enter Your Number 👀");
  } while (isNaN(prmpt));

  if (prmpt > actualNumber) {
    alert("Greater than actial Number");
  } else if (prmpt < actualNumber) {
    alert("Smaller than actial Number");
  }
} while (prmpt != actualNumber);
alert("Congrats!!🎉🎉");
