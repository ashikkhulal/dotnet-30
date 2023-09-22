// var number = 5; // in-line comment

/* this is a 
multi-line comment 
asd
asda
1213
*/

// /* Data Types:
// undefined, null, boolean, string, symbol, number, and object
// */

// var myName = 'Ashik'; // globally
// myName = 8;
// let ourName = 'Honey Bunny'; // scoped
// const pi = 3.14; // constant

// var a;
// var b = 2;

// a = 7;

// console.log(a)

// var sum = 10 + 10;
// console.log(sum);

// var subtract = 10 - 5;
// console.log(subtract);

// var multiply = 10 * 5;
// console.log(multiply);

// var divide = 10 / 5;
// console.log(divide);

// var myVar = 87;
// myVar = myVar + 1;
// myVar++;

// myVar = myVar - 1;
// myVar--;

// var ourDecimal = 5.7;

// var product = 2.0 * 2.5;

// var x = 12;
// var y = 13;

// x = x + 12;
// y = 9 + y;

// x += 12;
// y += 9;

// // Similar notation for subtract, multiply and divide.

// var mystr = "I am a \"double\" quote"
// var twoStr = "I come first. " + "I come second"
// var newstr = "I come first. "
// newstr += "I come second"

// var newStr2 = newstr[0];

// var length = newstr.length;

// // Madlibs
// function wordBlanks(myNoun, myAdjective, myVerb, myAdverb) {

//     var result = "";
//     result += "The " + myAdjective + " " + myNoun + " " + myVerb + " to the store " + myAdverb + "."

//     return result;
// }

// console.log(wordBlanks("dog", "big", "ran", "quickly"));

// // Arrays

// var ourArray = ['John', 23];

// var myArray = [];

// // Nested / Multi-dimensional array

// var nestedArray = [['John', 23], ['David', 26]];

// // Accessing/ changing arrays elements
// var newArray = [18, 64, 99];
// newArray[1] = 72;
// console.log(newArray);

// console.log(nestedArray[1][0]); 

// // push()
// nestedArray.push(['Andrew', 33]);
// console.log(nestedArray);

// // pop()
// var poppedFromNestedArray = nestedArray.pop();
// console.log(poppedFromNestedArray);
// console.log(nestedArray);

// // shift()
// shiftedFromNestedArray = nestedArray.shift();
// console.log(shiftedFromNestedArray);
// console.log(nestedArray);

// // unshift()
// nestedArray.unshift(['Harry', 20]);
// console.log(nestedArray);

// // Functions

// function greet(name) {
//     console.log(`Hey ${name}, nice to meet you!`);
// }

// greet('Ashik');

// function sum(a, b) {
//     console.log(a + b);
// }

// sum(10, 5);

// // Global variable
// var myGlobal = 10;

// function fun1() {
//     oopsGlobal = 5;
// }

// function addRemoveItems(array, item){
//     array.push(item);
//     return array.shift();
// }

// testArray = [1, 2, 3, 4, 5];
// console.log("Before: " + testArray);
// addRemoveItems(testArray, 6);
// console.log("After: " + testArray);

// if statement

// function trueOrFalse(isItTrue) {
//     if (isItTrue) {
//         return "Yes, it's true!";
//     }
//     return "No, it's false!";
// }

// console.log(trueOrFalse(true));
// console.log(trueOrFalse(false));

// // Comparision operators:
// // == equality
// console.log(10 == 10);
// console.log(10 == '10');
// // === strict equality
// console.log(10 === 10);
// console.log(10 === '10');
// // != inequality
// console.log(10 != 17);
// console.log(10 != '17');
// // !== strict inequality
// console.log(17 !== 17);
// console.log(17 !== '17');
// // > greater than
// console.log(10 > 5);
// // >= greater or equal
// console.log(10 >= 5);
// // <= less than
// console.log(10 < 25);
// // <= less or equal
// console.log(10 <= 25);
// // && And operator
// console.log(10 >= 5 && 10 <= 25);
// // || Or operator
// console.log(10 >= 5 || 10 >= 25);
// else and else if statement
// function compare(num) {
//     if (num > 20) {
//         return "It's greater than 20!";
//     }
//     else if (num > 10) {
//         return "It's greater than 10 but less than 20!";
//     }
//     else {
//         return "It's less than 10!";
//     }
    
// }

// console.log(compare(25));
// console.log(compare(15));
// console.log(compare(10));

// var names = ['Hole-in-one', 'Eagle', 'Birdie', 'Par', 'Bogey', 'Double Bogey', 'Go Home!'];

// function golfScore(par, strokes) {
//     if (strokes == 1) {
//         console.log(names[0]);
//     }
//     else if (strokes <= par - 2) {
//         console.log(names[1]);
//     }
//     else if (strokes <= par - 1) {
//         console.log(names[2]);
//     }
//     else if (strokes == par) {
//         console.log(names[3]);
//     }
//     else if (strokes <= par + 1) {
//         console.log(names[4]);
//     }
//     else if (strokes <= par + 2) {
//         console.log(names[5]);
//     }
//     else {
//         console.log(names[6]);
//     }
// }

// golfScore(5, 1);
// golfScore(5, 2);
// golfScore(5, 4);
// golfScore(5, 5);
// golfScore(5, 6);
// golfScore(5, 7);
// golfScore(5, 8);

// // Switch statement:
// function switchStatement(option) {
//     switch(option) {
//         case 1:
//             console.log('Case 1 executed!');
//             break;
//         case 2:
//             console.log('Case 2 executed!');
//             break; 
//         case 3:
//             console.log('Case 3 executed!');
//             break;
//         default:
//             console.log('Default case executed!');
//             break;
//     }
// }

// switchStatement(2);
// switchStatement(0);

// function countCards(card) {
//     var count = 0
//     switch(card) {
//         case 2:
//         case 3:
//         case 4:
//         case 5:
//         case 6:
//             count++;
//             break;
//         case 10:
//         case "J":
//         case "Q":
//         case "K":
//             count--;
//             break;
//     }
//     var holdBet = "hold";
//     if (count > 0) {
//         holdBet = "bet";
//     }

//     return count + " " + holdBet;
// }

// console.log(countCards(2));

// Objects:

var myDog = {
    "name" : "brownie",
    "leg" : 4,
    "tail" : 1,
    "friends" :["many!"]
}

console.log(myDog.name);
myDog.name = "dot notation browneeei";
console.log(myDog.name);
myDog["name"] = "new brownieee";
console.log(myDog.name);
myDog['age'] = 4;
delete myDog.age;

function checkObj(checkProp) {
    if (myDog.hasOwnProperty(checkProp)) {
        return myDog[checkProp];
    }
    return "Not found!"
}

console.log(checkObj("tail"));