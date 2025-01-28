var answerDisplay = document.getElementById("Answer");
var inputs = document.querySelector("table");
var letters = "";
inputs.addEventListener("click", (e) => {
  if (e.target.value != "") {
    if (e.target.value == "=") {
      console.log(letters);
      answerDisplay.value = eval(letters);
      letters = "";
    }
    letters += e.target.value;
    console.log(e.target.value);
    answerDisplay.value = letters;
  } else {
    console.log("first");
  }
});
