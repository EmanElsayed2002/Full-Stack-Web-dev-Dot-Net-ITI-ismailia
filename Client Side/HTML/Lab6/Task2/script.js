var answerDisplay = document.getElementById("Answer");
var flag = false;
var expre = "";
function EnterNumber(value) {
  if (expre[expre.length - 1] == "=" || flag) {
    answerDisplay.value = "";
    flag = false;
  }
  expre += value;
  console.log(value);
  answerDisplay.value += value;
  return value;
}

function EnterOperator(value) {
  expre += value;
  // answerDisplay.value = "";
  answerDisplay.value += value;
  return value;
}

function EnterEqual() {
  try {
    flag = true;
    console.log(expre);
    answerDisplay.value = eval(expre);

    if (answerDisplay.value == "Infinity" || answerDisplay.value == "NaN") {
      answerDisplay.value = "Can not divide over zero";
    }
    return answerDisplay.value;
  } catch (err) {
    alert("expression Invalid");
    answerDisplay.value = "";
  } finally {
    expre = "";
  }
}

function EnterClear() {
  answerDisplay.value = "";
}
