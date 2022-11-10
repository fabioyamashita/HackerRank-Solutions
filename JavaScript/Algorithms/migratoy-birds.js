function migratoryBirds(arr) {
  // GENERAL SOLUTION
  //   let uniqueValues = Array.from(new Set(arr.sort()));
  //   let arrUniqueCount = [];
  //   uniqueValues.forEach((v) =>
  //     arrUniqueCount.push(arr.filter((value) => value === v).length)
  //   );

  //   const maxValueIndex = arrUniqueCount.indexOf(Math.max(...arrUniqueCount));
  //   return uniqueValues[maxValueIndex];

  // SPECIFIC SOLUTION TO 5 TYPES
  let count = new Array(5).fill(0);
  arr.forEach((value) => count[value - 1]++);
  return count.indexOf(Math.max(...count)) + 1;
}

console.log(migratoryBirds([1, 4, 4, 4, 5, 3]));
