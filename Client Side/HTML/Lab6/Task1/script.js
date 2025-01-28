var origin = document.querySelector("div");
console.log(origin);

origin.addEventListener("click", () => {
  var cloned = origin.cloneNode(true);
  cloned.style.backgroundColor = getRandomColor();
  document.body.append(cloned);
});

function getRandomColor() {
  return `#${Math.floor(Math.random() * 16777215)
    .toString(16)
    .padStart(6, "0")}`;
}
