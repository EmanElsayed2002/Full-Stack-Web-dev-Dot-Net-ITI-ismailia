import { Shape } from "./Shape.js";
class Circle extends Shape {
  constructor(side) {
    super(side);
  }
  getArea() {
    return Math.PI * this.side ** 2;
  }
  getPerimeter() {
    return 2 * Math.PI * this.side;
  }
}
export { Circle };
