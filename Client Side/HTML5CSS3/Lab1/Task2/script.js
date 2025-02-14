var redInput = document.getElementById("redColor");
var greenInput = document.getElementById("GreenColor");
var blueInput = document.getElementById("BlueColor");
var p = document.getElementById("content");
var red = 126,
  blue = 126,
  green = 126;
console.log(redInput, blueInput, greenInput);
redInput.addEventListener("input", (e) => {
  red = e.target.value;
  p.style.color = `rgb(${red} , ${green} , ${blue})`;
});

blueInput.addEventListener("input", (e) => {
  blue = e.target.value;
  p.style.color = `rgb(${red} , ${green} , ${blue})`;
});

greenInput.addEventListener("input", (e) => {
  green = e.target.value;
  p.style.color = `rgb(${red} , ${green} , ${blue})`;
});
