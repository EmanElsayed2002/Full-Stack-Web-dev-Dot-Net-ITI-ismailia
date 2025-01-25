try {
  var noOfPersons = prompt("Enter the number of persons:");

  while (isNaN(noOfPersons) || noOfPersons <= 0) {
    noOfPersons = prompt(
      "Please enter a valid positive number for the number of persons:"
    );
  }

  let names = [];
  let ages = [];

  for (let i = 0; i < Number(noOfPersons); i++) {
    var username;
    do {
      username = prompt("Please enter name #" + (i + 1) + ":");
      if (!isNaN(username) || !username.trim()) {
        alert("Name must be a non-empty string. Please try again.");
      }
    } while (!isNaN(username) || !username.trim());
    names.push(username);

    var userage;
    do {
      userage = prompt("Please enter age #" + (i + 1) + ":");
      if (isNaN(userage) || userage <= 0) {
        alert("Age must be a valid positive number. Please try again.");
      }
    } while (isNaN(userage) || userage <= 0);
    ages.push(Number(userage));
  }

  var table = document.createElement("table");
  table.style.width = "60%";
  table.style.margin = "20px auto";
  table.style.borderCollapse = "collapse";
  table.style.fontFamily = "Arial, sans-serif";
  table.style.textAlign = "center";

  var thead = document.createElement("thead");
  thead.innerHTML = `
    <tr style="background-color: #007BFF; color: white;">
      <th style="padding: 10px; border: 1px solid #ccc;">Username</th>
      <th style="padding: 10px; border: 1px solid #ccc;">Age</th>
    </tr>`;
  table.appendChild(thead);

  var tbody = document.createElement("tbody");
  for (let i = 0; i < names.length; i++) {
    var row = document.createElement("tr");
    row.innerHTML = `
      <td style="padding: 10px; border: 1px solid #ccc;">${names[i]}</td>
      <td style="padding: 10px; border: 1px solid #ccc;">${ages[i]}</td>`;
    row.style.backgroundColor = i % 2 === 0 ? "#f9f9f9" : "#ffffff";
    tbody.appendChild(row);
  }
  table.appendChild(tbody);

  document.body.appendChild(table);
} catch (error) {
  console.error("An error occurred:", error.message);
}
