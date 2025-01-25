// var Messageprompt = prompt("Enter Your Message!!");
// var cnt = 0;
// for (var i = 0; i < Messageprompt.length; i++) {
//   if (Messageprompt[i] == "e") {
//     cnt++;
//   }
// }
// console.log("# of e", cnt);

// console.log();
//
var Messageprompt = prompt("Enter Your Message!!");
var cnt = Messageprompt.split("e").length - 1;
console.log("# of e:", cnt);
