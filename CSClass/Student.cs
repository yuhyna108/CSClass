namespace CSClass
{
     class Student
    {
        public Student(){}
        public string name;
        public int grade;

        public override string ToString()
        {
            // 마우스 오른쪽 클릭 -> 빠른 작업 리팩터링 -> 재정의 -> ToString 선택
            return this.name + " : "+this.grade;
        }
    }
}