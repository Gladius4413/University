let age = 18;
let checkAge = (age >= 18) ? alert("Вам есть 18") : alert("вам нет 18 ")


for(let i = 3; i < 12; i++){
    if( i % 2 == 0){
        console.log(i + "- не натуральное");
         continue;
        }
    if(i % 3 == 0 && i != 3){
        console.log(i + "- не натуральное");
        continue;
        } ;
     if(i % 5 == 0 && i != 5){
        console.log(i + "- не натуральное");
        continue;
        } 
    console.log(i + "- натуральное");

}