review1.cs
int d; // elapsed time in days
int elapsedTimeInDays;

review2.cs
var dataFromDb = db.GetFromService().ToList(); // Get List of employees 
var listOfEmployee = _employeeService.GetEmployee().ToList();

review3.cs
int iCounter;
string strFullName;
DateTime dModifiedDate;
// Avoid Hungarian notation(appending with the data type)
int counter;
string fullName;
DateTime modifiedDate;

review4.cs
public bool IsShopOpen(string pDay, int pAmount)
{
    // some logic
}
public bool IsShopOpen(string day, int amount)
{
    // some logic
}

review5.cs
const int DAYS_IN_WEEK = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var Artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool Restore_database() {}

class animal {}
class Alpaca {}

//follow one notation(either camel case or consistent capitalization)
const int daysInWeek = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool eraseDatabase() {}
bool restoreDatabase() {}

class animal {}
class alpaca {}

review6.cs
public class Employee
{
    public Datetime sWorkDate { get; set; } // get set Start Working Date
    public Datetime modTime { get; set; } // get set Modification Time
}
public class employee
{
    public Datetime StartWorkingDate { get; set; } // get set Start Working Date
    public Datetime ModificationTime { get; set; } // get set Modification Time
}

review7.cs
var employeephone;
public double CalculateSalary(int workingdays, int workinghours)
{
    // some logic
}

var employeePhone;
public double CalculateSalary(int workingDays, int workingHours)
{
    // some logic
}

