create table customers(
customer_no int not null primary key,
customer_name varchar(100) not null,
address varchar(100) not null,
postal_code varchar(10) not null
);

create table job_cards(
job_card_no int not null primary key,
job_type varchar(100) not null,
no_of_days int not null,
material_used varchar(200) not null,
customer_no int not null foreign key references customers(customer_no)
);

create table job_type(
job_card_no int not null foreign key references job_cards(job_card_no),
job_type varchar(100) not null,
no_of_days int not null,
daily_rate int not null
);

create table employees(
job_card_no int not null foreign key references job_cards(job_card_no),
employee_no varchar(100) not null,
employee_name varchar (100) not null
);

create view invoice as
select jc.job_card_no, c.customer_name, (c.address + c.postal_code) as [Address], jc.job_type, e.employee_no, e.employee_name, jc.material_used,
(j.no_of_days * j.daily_rate) as subtotal, ((j.no_of_days * j.daily_rate) * 14/100) as vat, ((j.no_of_days * j.daily_rate) + ((j.no_of_days * j.daily_rate) * 14/100)) as total
from job_cards jc, customers c, employees e, job_type j
where jc.job_card_no = j.job_card_no
and c.customer_no = jc.customer_no
and e.job_card_no = jc.job_card_no
;

-- Retrieve job cards
create procedure dbo.JobCards
as 
begin
select * from job_cards
end

-- Create job cards
create procedure dbo.CreateJobcards
(
@job_card_no int,
@job_type varchar(100),
@no_of_days int,
@material_used varchar(200),
@customer_no int
)
as
begin
insert into job_cards values (@job_card_no, @job_type, @no_of_days, @material_used, @customer_no)
end

-- Retrieve Invoice
create procedure dbo.Invoices
as 
begin
select * from invoice
end

-- Update Job type
create procedure dbo.JobTypeUpdate
(
@job_card_no int,
@job_type varchar(100),
@no_of_days int,
@daily_rate int
)
as 
begin
update job_type
set job_type = @job_type,
no_of_days = @no_of_days,
daily_rate = @daily_rate
where job_card_no = @job_card_no
end

-- Retrieve employees
create procedure dbo.RetrieveEmployees
as 
begin
select * from employees
end

-- Create employees
create procedure dbo.CreateEmployees
(
@job_card_no int,
@employee_no varchar(100),
@employee_name varchar (100)
)
as
begin
insert into employees values (@job_card_no, @employee_no, @employee_name)
end

-- Update employees
create procedure dbo.UpdateEmployees
(
@job_card_no int,
@employee_no varchar(100),
@employee_name varchar (100)
)
as 
begin
update employees
set job_card_no = @job_card_no,
employee_name = @employee_name
where employee_no = @employee_no
end