const employeeObj = {
    name : "Anton",
    midname: "Alexeevich",
    surname: "Kozlov",
    
    Working: function(){
        console.log(this.name + " is working")
    }
}

console.log(employeeObj);
employeeObj.Working();


class Person{
    name;
    surname;
    midname

    constructor(name, surname, midname){
        this.name = name;
        this.surname = surname;
        this.midname = midname;
    }


    Working(){
        console.log("Person is not working");
    }
}

class Employee extends Person{
    #salary;

    get salary(){
        return this.#salary;
    }

    set salary(salary){
        this.#salary = salary;
    }

    Working(){
        console.log(this.name + " is working");
    }
}


Employee.prototype.company = "Altenar";

Employee.prototype.MakeTeamBuilding = function(company){
    console.log(company + " made team building");
};

var employee = new Employee("Vahev","Airapetyan", "Maksimovich");
employee.salary = 35000;
console.log(employee);
employee.Working();
employee.MakeTeamBuilding(employee.company);