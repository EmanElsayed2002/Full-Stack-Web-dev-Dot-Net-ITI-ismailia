function FullNameDay(date) {
  var UserDate = new Date(date);
  return UserDate.getDay();
}
var days = [
  "Sunday",
  "Monday",
  "Tuesday",
  "Wednesday",
  "Thursday",
  "Friday",
  "Saturday",
];
var dayName = days[FullNameDay("8-21-2002")];
console.log(dayName);
