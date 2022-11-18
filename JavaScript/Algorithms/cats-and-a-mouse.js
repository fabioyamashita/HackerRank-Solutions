// Complete the catAndMouse function below.
function catAndMouse(x, y, z) {
  const catADistance = z - x;
  const catBDistance = z - y;
  if (Math.abs(catADistance) < Math.abs(catBDistance)) return "Cat A";
  else if (Math.abs(catADistance) > Math.abs(catBDistance)) return "Cat B";
  else return "Mouse C";
}

console.log(catAndMouse(1, 2, 3));
console.log(catAndMouse(1, 3, 2));
