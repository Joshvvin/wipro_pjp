select employee.title, employee.birthdate, employee.firstname, employee.lastname 
from employee
JOIN person
on employee.businessentityid = person.personid;