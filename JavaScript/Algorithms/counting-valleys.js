function countingValleys(steps, path) {
  let level = 0;
  let countValleys = 0;

  for (let i = 0; i < steps; i++) {
    if (path[i] == "D") {
      if (level === 0) {
        countValleys++;
      }
      level--;
    } else {
      level++;
    }
  }

  return countValleys;
}

console.log(countingValleys(8, "UDDUDDUU"));
