namespace review_test
{
    //a
    class Employee
    {
        public string? Name { get; set; }
        public string? Position { get; set; }
    }
    //b
    class Manager : Employee
    {
        public string? Department { get; set; }
    }
    //c
    class Developer : Employee
    {
        public string? ProgrammingLanguage { get; set; }
    }
}
