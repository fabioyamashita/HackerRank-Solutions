function kangaroo(x1, v1, x2, v2) {
  let n = (x1 - x2) / (v2 - v1);

  if (Number.isInteger(n) && n > 0) return "YES";
  else return "NO";
}

console.log(kangaroo(0, 2, 5, 3));
console.log(kangaroo(0, 3, 4, 2));
