using prct_6.Interface;
using System;

namespace prct_6
{
    internal class GraduationExam : IExam, ITest
    {
        public event Action<string> GraduationExamEvent;
        public void ConductExam()
        {
            GraduationExamEvent?.Invoke("Написали Іспит");
        }
        public void TakeTest()
        {
            GraduationExamEvent?.Invoke("Написали Тест");
        }
        public void PassGraduationExam()
        {
            GraduationExamEvent?.Invoke("Склали випускний екзамен");
        }
    }
}