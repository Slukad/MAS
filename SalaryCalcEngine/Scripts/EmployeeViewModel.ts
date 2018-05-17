///<reference path="typings/knockout/knockout.d.ts" />///<reference path="typings/jquery/jquery.d.ts" />
module SalaryCalcEngine {
    export class EmployeeViewModel {
        employees: KnockoutObservableArray<Employee>;
        employeeId: KnockoutObservable<string>;
        error: KnockoutObservable<string>;
        public constructor() {
            this.employeeId = ko.observable('');
            this.employees = ko.observableArray([]);
            this.error = ko.observable('');
        }

        getEmployees = () => {
            var self = this;
            self.employees.removeAll();
            self.error('');
            $.ajax({
                url: "/api/employee" + (self.employeeId().length > 0 ? ("?id=" + self.employeeId()) : ''),
                type: "GET",
                contentType: "application/json",
                dataType: "json",

            }).done(function (data) {
                if (data.length > 0) {
                    for (let employee of data) {
                        self.employees.push(new Employee(employee.Id, employee.Name, employee.RoleName, employee.AnnualSalary));
                    }
                }
                else {
                    self.error('No employees found.');
                }
            })
            .fail(function (error) {
                console.log(error);
            });
        }
    }
}