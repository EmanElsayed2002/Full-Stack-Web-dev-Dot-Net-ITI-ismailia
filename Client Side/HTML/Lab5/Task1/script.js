var lst = [];
for (var i = 0; i < 5; i++) {
  do {
    var prmpt = prompt("Enter Your Number #" + (i + 1));
  } while (isNaN(prmpt));
  lst.push(Number(prmpt));
}
var already = document.createElement("div");
already.innerHTML = "<h4> U're Already Entered " + lst.join() + "</h4>";
already.style.color = "red";
already.style.color = document.body.appendChild(already);

var SortedLst = lst.sort(function (a, b) {
  return a - b;
});
console.log(lst);
var asList = document.createElement("div");
asList.innerHTML = "<h4> U're Ascending Items " + SortedLst.join() + "</h4>";
asList.style.color = "red";
asList.style.color = document.body.appendChild(asList);

var REversed = SortedLst.reverse();
console.log(REversed);
var revList = document.createElement("div");
revList.innerHTML = "<h4> U're Descending Items " + REversed.join() + "</h4>";
revList.style.color = "red";
revList.style.color = document.body.appendChild(revList);
