namespace MyAnt.Services {
    public class Student {
        // public int Id { set; get; }
        public string Name { set; get; }
    }

    public class DataService {
        public List<Student> GetStudents() {
            return new List<Student> {
                new Student { Name = "John" },
                new Student { Name = "Joe"}
            };
        }
    }
}
