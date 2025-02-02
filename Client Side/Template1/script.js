var loginBtn = document.getElementById("login");
console.log(loginBtn);

loginBtn.addEventListener("click", (e) => {
  e.preventDefault();
  window.location.href = "Login.html";
  console.log(window.location.href);
});
