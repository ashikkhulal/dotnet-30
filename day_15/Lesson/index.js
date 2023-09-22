// This is my first javascript code
console.log('Hello World');

// Variables:
let userName = 'Ashik';
let userPassword;

console.log(userName);

// Cannot be a reserved keyword
// Should be meaningful
// Cannot start with a number (1name)
// Cannot contain a space or hyphen
// Are case-sensitive
// Modern best practice is to declare variables in each separate lines

// Constants:
const interestRate = 0.3;

console.log(interestRate);

// Data types:
// Primitives/ value types

let firstName = 'Ashik';    // String Literal
console.log(typeof firstName);

let age = 28;   // Number Literal
console.log(typeof age);
age = 32.1;
console.log(typeof age);

let isApproved = true;  // Boolean Literal
console.log(typeof isApproved);

let lastName = undefined;
console.log(typeof lastName);

let selectedColor = null;
console.log(typeof selectedColor);


// Reference types

// Object
let person = {
    firstName: 'Ashik',
    age: 28
}

// Dot notation
person.firstName = 'Ram';

// Bracket notation
person['firstName'] = 'Lakshman';
console.log(person.firstName)

let selection = 'firstName';
person[selection] = 'Bharat'

console.log(person.firstName)

// Array

let array = [];
let colors = ['red', 'blue'];
console.log(colors);
colors[2] = 'green';
colors[3] = 10;
console.log(colors[3]);

// Function

function greet(name) {
    console.log('Hello ' + name + '!');
}

greet('Ashik');

function square(number) {
    return number * number;
}

let square_20 = square(20);
console.log(square_20);