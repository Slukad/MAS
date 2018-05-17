///<reference path="typings/knockout/knockout.d.ts" />
module SalaryCalcEngine {
    export class Employee {
        id: number;
        name: string;
        roleName: string;
        annualSalary: any;
        constructor(id: number, name: string, roleName: string, annualSalary: number) {
            this.id = id;
            this.name = name;
            this.roleName = roleName;
            this.annualSalary = '$' + annualSalary.toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, '$1,');
        }
    }
}