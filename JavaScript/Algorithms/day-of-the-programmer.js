function dayOfProgrammer(year) {
  let day = 0;
  if (year <= 1917) {
    year % 4 === 0 ? (day = 12) : (day = 13);
  } else if (year === 1918) {
    day = 26;
  } else if (year >= 1919) {
    if (year % 400 === 0 || (year % 4 === 0 && year % 100 !== 0)) day = 12;
    else day = 13;
  }

  return `${day}.09.${year}`;
}

console.log(dayOfProgrammer(1800));
console.log(dayOfProgrammer(2016));
console.log(dayOfProgrammer(2019));
