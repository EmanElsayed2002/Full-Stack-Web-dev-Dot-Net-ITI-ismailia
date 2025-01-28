window.addEventListener("keydown", (e) => {
  console.log(e.keyCode);
  if (e.keyCode == 16) {
    alert("u write Shift");
  } else if (e.keyCode == 17) {
    alert("u write CTLR");
  } else if (e.keyCode == 18) {
    alert("u write Alt");
  }
});
