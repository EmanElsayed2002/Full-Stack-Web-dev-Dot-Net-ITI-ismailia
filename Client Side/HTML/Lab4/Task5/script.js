do {
  var promptMessage = prompt("Enter the value of a circle’s radius");

  if (!isNaN(promptMessage) && promptMessage) {
    document.write(Math.pow(Number(promptMessage), 2) * Math.PI);
    break;
  }
} while (isNaN(promptMessage));
