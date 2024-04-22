
namespace ConsoleApp8
{
    internal class STUDENT:PERSON
    {
        public int StudentId { get; set; }
        public double point {  get; set; }

        public STUDENT(int studentId, double point)

        {
            point = point;
            StudentId = studentId;
        }
        public void ShowFullInfo(int studentId);


        

     

    }
}
