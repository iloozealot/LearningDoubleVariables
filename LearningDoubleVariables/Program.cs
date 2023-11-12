
//doubles can have a decimal point or be a whole number

double averageAge;

//averageAge = (43 + 22 + 62) / 3; // it is returning a whole number because I used all whole numbers
//averageAge = (43.0 + 22 + 62) / 3;// now it returned a decimal because I used a double type number
averageAge = 1.0 / 3;// it only stores out to 16 digits 0.33333333333333, this is why we don't use doubles for money because we want more precision for money

Console.WriteLine(averageAge);