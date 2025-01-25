var MessageConfirm = confirm("Consider Case Sensitive");

if (MessageConfirm) {
  var promptMessage = prompt("Enter Your String To Make Palindrome");
  var i = 0,
    j = promptMessage.length - 1;
  while (i < j && promptMessage[i] == promptMessage[j]) {
    i++;
    j--;
  }
  console.log(i, j);
  if (i == j) {
    alert("string is Palindrome!!😎");
  } else {
    alert("string is NOT Palindrome!!😜");
  }
} else {
  promptMessage = prompt("Enter Your String To Make Palindrome");
  promptMessage = promptMessage.toLowerCase();
  var i = 0,
    j = promptMessage.length - 1;
  while (i <= j) {
    if (promptMessage[i] != promptMessage[j]) {
      alert("string is NOT Palindrome!!😜");
      break;
    }
    i++;
    j--;
  }

  alert("string is Palindrome!!😎");
}
