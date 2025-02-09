import { Circle } from "./Circle.js";
import { Rectangle } from "./Rectangle.js";
import { Squre } from "./Squre.js";

const rect = new Rectangle(10, 5);
const square = new Squre(7);
const circle = new Circle(4);

console.log(rect.toString());
console.log(square.toString());
console.log(circle.toString());
let rs = document.getElementById("result");
console.log(rs);
rs.innerText = `<p>Rect ${rect}</p><p>square ${square}</p><p>circle ${circle}</p>`;
