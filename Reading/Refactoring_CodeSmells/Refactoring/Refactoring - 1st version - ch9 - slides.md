# Refactoring

Chapter 9

Simplifying Conditional Expressions



## Decompose Conditional

## Read this

if (date.before (SUMMER_START) || date.after(SUMMER_END))

charge = quantity * winterRate + _winterServiceCharge;

else charge = quantity * _summerRate;



## and then read this

if (notSummer(date))

charge = winterCharge(quantity);

else

charge = summerCharge (quantity);



# Consolidate Conditional

## Expression

## Before:


<table border="1" ><tr>
<td colspan="1" rowspan="1">double disabilityAmount() {</td>
</tr></table>

After:


<table border="1" ><tr>
<td colspan="1" rowspan="1">double disabilityAmount() {if (isNotEligableForDisability()) return θ;11...</td>
</tr></table>

# Consolidate Duplicate Conditional

## Fragments

## Before

if (isSpecialDeal()) {

doSomePreparation();

doNonRelatedwork();

total = price * 0.95;

send();

doSomeCleanUp();

else {

doSomePreparation();

total = price * 0.98;

send();

doNonRelatedWork();

doSomeCleanUp();

# Consolidate Duplicate Conditional

## Fragments

After

doNonRelatedWork();

doSomePreparation();

if (isSpecialDeal())

total=price*θ.95;

else

total=price*θ.98;

send();

doSomeCleanUp();

## Remove Control Flag

## Trace this

void checkSecurity(String[] people) {

boolean found = false;

for (int i =0;i&lt;people.length;i++)r

if (! found) {

if (people[i].equals ("Don")){

sendAlert();

found = true;

if (people[i].equals ("John")){

sendAlert();

found = true;

# Remove Control Flag

O use return, break, continue...

<!-- X  -->

set a flag and check somewhere later

## Remove Control Flag

## Alternative 1:

void checkSecurity(String[] people) {

for (int i = 0; i &lt; people.length; i++) {

if (people[i].equals ("Don")){

sendAlert();

break;

1J

if (people[i].equals ("John")){

sendAlert();

break;

## Remove Control Flag

## Alternative 2:

void checkSecurity(String[] people) {

String found = foundMiscreant(people);

someLaterCode(found);

1

String foundMiscreant(String[] people) {

for (int i = θ; i &lt; people.length; i++) {

if (people[i].equals ("Don")){

sendAlert();

return "Don";

if (people[i].equals ("John")){

sendAlert();

return "John";

return "";

# Replace Nested Conditional

with Guard Clauses

## Before

double getPayAmount() {

double result;

if (_isDead) {

result = deadAmount();

} else {

if (_isSeparated) {

result = separatedAmount();

} else {

if (_isRetired) result = retiredAmount();

else result = normalPayAmount();

return result;

# Replace Nested Conditional

with Guard Clauses

After

double getPayAmount() {

if (_isDead)

return deadAmount();

if (_isSeparated)

return separatedAmount();

if(_isRetired)

return retiredAmount();

return normalPayAmount();

};

Replace Nested Conditional

with Guard Clauses

Mind implicit semantics



## Guard clause

→(somehow) exceptional condition

## if else

→ two equivalent normal conditions

# Replace Nested Conditional with

Guard Clauses

·However,you might have seen this..

if (aquireResource1()) {

if (aquireResource2()) {

if (aquireResource3()) {

if (aquireResource4()) {

doRealWork();

releaseResource4();

1J

releaseResource3();

1

releaseResource2();

し

releaseResource1();

Replace Nested Conditional with

Guard Clauses

·or this...

if (false == aquireResource1())

return;

if (false == aquireResource2()) {

releaseResource1();

return;

if (false == aquireResource3()) {

releaseResource2();

releaseResource1();

return;

doRealWork();

releaseResource3();

releaseResource2();

releaseResource1();

return;

Replace Condition

Polymorphism

<!-- Employee _Iype 1 Employee Type Engineer Salesman Manager  -->

## Before

class Employee...

int payAmount(Employee) {

switch (getType()) {

case EmployeeType.ENGINEER:

return _monthlySalary;

case EmployeeType.SALESMAN:

return _monthlySalary + _commission;

case EmployeeType,MANAGER:

return _monthlySalary + _bonus;

default:

throw new RuntimeException("Incorrect Employee");



# Replace Conditional with Polymorphism

<!-- CAUTION switch case clauses  -->

OPolymorphism might be better, usually Replace Conditional with Polymorphism



## After

class Employee...

int payAmount() {

return_type.payAmount(this);

class Salesman...

int payAmount(Employee emp) {

return emp.getMonthlySalary() + emp.getCommission();

class Manager...

int payAmount(Employee emp) {

return emp.getMonthlySalary() +emp.getBonus();



## Introduce Null Object

### Same with Replace Conditional with Polymorphism

deal with special cases extensively checked

check type→ check NULL



## Before:

class Customer...

public String getName() {...}

public BillingPlan getPlan() {...}

public PaymentHistory getHistory() {...}

if(customer=null) plan = BillingPlan.basic();

else plan = customer.getPlan();

## Introduce Null Object

## After

plan = customer.getPlan();


<table border="1" ><tr>
<td colspan="1" rowspan="1">Customer</td>
</tr><tr>
<td colspan="1" rowspan="1">getPlan</td>
</tr></table>

class NullCustomer...

public BillingPlan getPlan(){

return BillingPlan.basic();


<table border="1" ><tr>
<td colspan="1" rowspan="1">Null Customer</td>
</tr><tr>
<td colspan="1" rowspan="1">getPlan</td>
</tr></table>

## Introduce Assertion

## Write your assumption explicitly and clearly

double getExpenseLimit() {

// should have either expense limit or a primary project

return (_expenseLimit != NULL_EXPENSE) ?

expenseLimit:

_primaryProject.getMemberExpenseLimit();

double getExpenseLimit() {

Assert.isTrue (_expenseLimit != NULL_EXPENSE || _primaryProject != null);return (_expenseLimit != NULL_EXPENSE)?

_expenseLimit:

_primaryProject.getMemberExpenseLimit();

## Introduce Assertion

Do NOT overuse

If code does work without the assertion, remove it.

## Notes

Save brain power

·Break/prune eye-tracing as early as possible

Don't Repeat Yourself

