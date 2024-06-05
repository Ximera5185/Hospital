namespace Hospital
{
    internal class Patient
    {
        public Patient(string fullName, string disease, int age) 
        {
            FullName = fullName;

            Disease = disease;

            Age = age;
        }

        public string FullName { get; private set; }
        public string Disease{ get; private set; }

        public int Age { get; private set; }
    }
}