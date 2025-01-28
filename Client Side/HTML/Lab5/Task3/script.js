function FullNameDay(date) {
  var UserDate = new Date(date);
  var days = [
    "Sunday",
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
  ];
  return days[UserDate.getDay()];
}
var dayName = FullNameDay("8-21-2002");
console.log(dayName);
