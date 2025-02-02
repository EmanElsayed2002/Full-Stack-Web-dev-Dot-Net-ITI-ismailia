var input = document.getElementById("num");
console.log(input);

var regExp = /[^0-9.-]/g;
var letters = "";
input.addEventListener("keydown", (e) => {
  // console.log(e.keyCode);
  if (!isNaN(e.key) || e.keyCode == 8) {
  } else {
    e.preventDefault();
  }
});
