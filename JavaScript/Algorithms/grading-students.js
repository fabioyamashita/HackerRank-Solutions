function gradingStudents(grades) {
  grades.forEach((grade, index) => {
    if (grade >= 38 && grade % 5 >= 3) grades[index] = Math.ceil(grade / 5) * 5;
  });

  return grades;
}

console.log(gradingStudents([75, 67, 48, 33]));
