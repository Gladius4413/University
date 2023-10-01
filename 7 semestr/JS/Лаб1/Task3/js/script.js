///////// forEach ///////////////////

var arrayOfNumber = [1,2,3,4,5,6];
var arrayOfSquareNumber = [];
 arrayOfNumber.forEach(function(element,i){
    arrayOfSquareNumber[i] = element * element;

});
console.log("элементы массива " + arrayOfNumber + " в степени - " + arrayOfSquareNumber);


///////////// map ////////////////

var arrayOfNumber =  [2,5,4,7,9];
var devidedArray = arrayOfNumber.map(x => x % 2);
console.log("Остатки от деления на 2 таких чисел, как " + arrayOfNumber + " - " + devidedArray);


///////////// some ////////////////

function IsLessThan50(element, index, array){
    return element < 50
}

var result = [60,80,96,73,94,56].some(IsLessThan50);
var result2 = [60,80,96,73,94,56,10].some(IsLessThan50);

console.log("Результат поиска элемента меньше чем 50 для массива №1 - " + result);
console.log("Результат поиска элемента меньше чем 50 для массива №2 - " + result2);

//////////// reduce ////////////////

var resultOfMult = [1,2,3,4,5,6].reduce(function(a,b){
    return a * b;
});

console.log("Результат умножения - " + resultOfMult);