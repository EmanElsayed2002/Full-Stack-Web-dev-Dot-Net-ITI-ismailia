do {
  try {
    var userInput = prompt(
      "Enter Your Birth Date in the following format (DD-MM-YYYY). Example: 22-01-1999"
    );
    if (!isValidDate(userInput)) {
      throw new Error("Wrong Date Format");
    }

    var day = Number(userInput.slice(0, 2));
    var month = Number(userInput.slice(3, 5));
    var year = Number(userInput.slice(6, 10));
    var userDate = new Date(year, month - 1, day);
    alert("Valid Date: " + userDate.toDateString());
    break;
  } catch (error) {
    alert(error.message);
  }
} while (true);

function isValidDate(dateStr) {
  if (dateStr.length !== 10) return false;

  if (dateStr[2] !== "-" || dateStr[5] !== "-") return false;

  var day = dateStr.slice(0, 2);
  var month = dateStr.slice(3, 5);
  var year = dateStr.slice(6, 10);

  if (isNaN(day) || isNaN(month) || isNaN(year)) return false;

  day = Number(day);
  month = Number(month);
  year = Number(year);

  if (day < 1 || day > 31) return false;
  if (month < 1 || month > 12) return false;
  if (year < 1000 || year > 2025) return false;

  var testDate = new Date(year, month - 1, day);
  return (
    testDate.getDate() === day &&
    testDate.getMonth() === month - 1 &&
    testDate.getFullYear() === year
  );
}
