namespace net_on_the_web.Models
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _classid;

        public Student(int id, string name, int classid)
        {
            this._id = id;
            this._name = name;
            this._classid = classid;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Classid
        {
            get => _classid;
            set => _classid = value;
        }
    }
}