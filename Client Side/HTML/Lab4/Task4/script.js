var NameMessage = prompt("Please Enter Your Name");
while (!isNaN(NameMessage) && NameMessage) {
  NameMessage = prompt("Please Enter Valid Name!!!");
}
if (NameMessage) {
  var phoneNumber = prompt("Please Enter Your Phone 8 Length!!");
  while (isNaN(phoneNumber)) {
    phoneNumber = prompt("Please Enter Valid Phone 8 Length!!");
  }
  if (phoneNumber) {
    var MobileNumber = prompt("Please Enter Your Mobile Number!!");
    while (
      MobileNumber != "010" &&
      MobileNumber != "011" &&
      MobileNumber != "012"
    ) {
      MobileNumber = prompt("Please Enter Valid Mobile Number!!");
    }
    if (MobileNumber) {
      var Email = prompt("Please Enter Your Email!!");
      var regExpre = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;

      while (!regExpre.test(Email)) {
        Email = prompt("Please Enter Valid Email!!");
      }
      if (Email) {
        document.write("<h3> Name:" + NameMessage + "</h3>");
        document.write(
          "<h3> phone Number:" + MobileNumber + phoneNumber + "</h3>"
        );
        document.write("<h3> Email:" + Email + "</h3>");
      } else {
        alert("GOOD BYE!!");
      }
    } else {
      alert("GOOD BYE!!");
    }
  } else {
    alert("GOOD BYE!!");
  }
} else {
  alert("GOOD BYE!!");
}
