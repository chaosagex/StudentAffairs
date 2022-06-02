namespace StudentAffairs.Models
{
    public class CreateView
    {
        //public CreateView(Student std)
        //{
        //    this.std = std;
        //    this.mother = std.Parents.First();
        //    if (mother.ParentType > 0)
        //    {
        //        mother = std.Parents.Last();
        //        father = std.Parents.First();
        //    }
        //    else
        //    {
        //        mother = std.Parents.First();
        //        father = std.Parents.Last();
        //    }
        //}
        public Student std { get; set; }
        public Parent father { get; set; }
        public Parent mother { get; set; }
    }
}
