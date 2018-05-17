"use strict";
///<reference path="typings/knockout/knockout.d.ts" />
///<reference path="typings/jquery/jquery.d.ts" />
var SalaryCalcEngine;
(function (SalaryCalcEngine) {
    var EmployeeViewModel = /** @class */ (function () {
        function EmployeeViewModel() {
            var _this = this;
            this.getEmployees = function () {
                var self = _this;
                self.employees.removeAll();
                self.error('');
                $.ajax({
                    url: "/api/employee" + (self.employeeId().length > 0 ? ("?id=" + self.employeeId()) : ''),
                    type: "GET",
                    contentType: "application/json",
                    dataType: "json",
                }).done(function (data) {
                    if (data.length > 0) {
                        for (var _i = 0, data_1 = data; _i < data_1.length; _i++) {
                            var employee = data_1[_i];
                            self.employees.push(new SalaryCalcEngine.Employee(employee.Id, employee.Name, employee.RoleName, employee.AnnualSalary));
                        }
                    }
                    else {
                        self.error('No employees found.');
                    }
                })
                    .fail(function (error) {
                    console.log(error);
                });
            };
            this.employeeId = ko.observable('');
            this.employees = ko.observableArray([]);
            this.error = ko.observable('');
        }
        return EmployeeViewModel;
    }());
    SalaryCalcEngine.EmployeeViewModel = EmployeeViewModel;
})(SalaryCalcEngine || (SalaryCalcEngine = {}));
