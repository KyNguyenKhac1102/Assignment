using System;
public class intern
{
    public string fName { get; set; }
    public string lName { get; set; }
    public string gender { get; set; }
    public DateTime dateOfBirth { get; set; }
    private string phoneNumber { get; set; }
    public string birthPlace { get; set; }
    public int age
    {
        get { return calcAge(); }
        set { }
    }
    public int calcAge()
    {
        int surplus = 0;
        int years = DateTime.Now.Year - dateOfBirth.Year;
        int months = DateTime.Now.Month - dateOfBirth.Month;
        int days = DateTime.Now.Day - dateOfBirth.Day;

        if (((days == 0 || days > 0) && months == 0) || (months > 0))
        {
            surplus = 1;
        }

        return years + surplus;
    }
    public bool isGraduated { get; set; }
    public string fullName()
    {
        return lName + " " + fName;
    }

    public intern(string fname, string lname, string gder, DateTime dofB, string phonenumber, string birthplace, int Age, bool isgraduated)
    {
        fName = fname;
        lName = lname;
        gender = gder;
        dateOfBirth = dofB;
        phoneNumber = phonenumber;
        birthPlace = birthplace;
        age = Age;
        isGraduated = isgraduated;
    }
}