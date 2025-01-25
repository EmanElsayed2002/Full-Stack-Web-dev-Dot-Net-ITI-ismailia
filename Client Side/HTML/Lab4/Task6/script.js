do {
  var promptMessage = prompt("Enter the value of a to get SQure Root");

  if (!isNaN(promptMessage) && promptMessage) {
    document.write(Math.sqrt(Number(promptMessage)));
    break;
  }
} while (isNaN(promptMessage));
