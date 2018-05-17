"use strict";
///<reference path="typings/knockout/knockout.d.ts" />
var SalaryCalcEngine;
(function (SalaryCalcEngine) {
    var Employee = /** @class */ (function () {
        function Employee(id, name, roleName, annualSalary) {
            this.id = id;
            this.name = name;
            this.roleName = roleName;
            this.annualSalary = '$' + annualSalary.toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, '$1,');
        }
        return Employee;
    }());
    SalaryCalcEngine.Employee = Employee;
})(SalaryCalcEngine || (SalaryCalcEngine = {}));
