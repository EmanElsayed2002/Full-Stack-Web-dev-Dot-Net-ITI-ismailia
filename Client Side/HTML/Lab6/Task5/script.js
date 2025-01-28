var input = document.getElementById("num");
console.log(input);

var regExp = /[^0-9.-]/g;
var letters = "";
input.addEventListener("input", (e) => {
  console.log(e.target.value);
  if (!isNaN(e.target.value)) {
    letters += e.target.value;
  } else {
    letters += "";
  }

  input.value = letters;
  const value = e.target.value;
});
