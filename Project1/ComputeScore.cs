using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1
{
    public class ComputeScore
    {
        public double courseScore;
        public double professorScore;
        public double averageScore;
        public char letterGrade;

        public void Average(int score1, int score2, int score3, int score4, int score5, int score6)
        {
            averageScore = ((score1 + score2 + score3 + score4 + score5 + score6) / 30) * 100;
        }

        public void ComputeLetterGrade(double averageScore)
        {
            if (averageScore >= 90 && averageScore <= 100)
                letterGrade = 'A';
            else if (averageScore >= 80 && averageScore <= 90)
                letterGrade = 'B';
            else if (averageScore >= 70 && averageScore <= 80)
                letterGrade = 'C';
            else
                letterGrade = 'D';
        }
    }
}