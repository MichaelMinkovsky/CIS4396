using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class FeedbackProcessor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request["txtName"];
            string id = Request["txtID"];
            string courseName = Request["ddlCourseName"];
            int weight1, weight2, weight3, weight4, weight5, weight6, weight7, weight8, weight9, weight10, weight11, weight12;
            double courseScore = 0, professorScore = 0;
            char courseRating, professorRating;

            string message = "Your feedback has been submitted. Thank you for letting us know what you think! We use this feedback" +
                " to ensure that we are providing quality education to our students. <br /><br />";

            string message2 = "You submitted the following information. <br /><br />" +
                "Name: " + name + "<br />" +
                "TUID: " + id + "<br />" +
                "Course Name: " + courseName + "<br /><br />" + 
                "For question 1 \"The course syllabus was comprehensive, clear and accurate.\", you answered \"" + Request["optFeedback1"] + "\". <br />" + 
                "For question 2 \"The learning goals were clearly stated in the syllabus.\", you answered \"" + Request["optFeedback2"] + "\". <br />" +
                "For question 3 \"The content covered in this course was challenging.\", you answered \"" + Request["optFeedback3"] + "\". <br />" +
                "For question 4 \"The instructor was effective as a lecturer and/or class leader.\", you answered \"" + Request["optFeedback4"] + "\". <br />" + 
                "For question 5 \"The instructor's presentations were clear and organized.\", you answered \"" + Request["optFeedback5"] + "\". <br />" + 
                "For question 6 \"The instructor stimulated interest in the subject.\", you answered \"" + Request["optFeedback6"] + "\". <br />" + 
                "For question 7 \"The instructor was available and helpful to students outside the class.\", you answered \"" + Request["optFeedback7"] + "\". <br />" + 
                "For question 8 \"The instructor was concerned about student learning and development.\", you answered \"" + Request["optFeedback8"] + "\". <br />" + 
                "For question 9 \"The stated learning goals for the course were met.\", you answered \"" + Request["optFeedback9"] + "\". <br />" + 
                "For question 10 \"The graded assignments allowed me to demonstrate what I learned in the course.\", you answered \"" + Request["optFeedback10"] + "\". <br />" + 
                "For question 11 \"The instructor respected student's questions and ideas.\", you answered \"" + Request["optFeedback11"] + "\". <br />" + 
                "For question 12 \"The overall quality of this course was excellent.\", you answered \"" + Request["optFeedback12"] + "\". <br /><br />";
                    
            //question 1
            if (Request["optFeedback1"] == "Strongly Agree")
                weight1 = 5;
            else if (Request["optFeedback1"] == "Agree")
                weight1 = 4;
            else if (Request["optFeedback1"] == "Neutral")
                weight1 = 3;
            else if (Request["optFeedback1"] == "Disagree")
                weight1 = 2;
            else if (Request["optFeedback1"] == "Strongly Disagree")
                weight1 = 1;
            else
                weight1 = 0;
            
            //question 2
            if (Request["optFeedback2"] == "Strongly Agree")
                weight2 = 5;
            else if (Request["optFeedback2"] == "Agree")
                weight2 = 4;
            else if (Request["optFeedback2"] == "Neutral")
                weight2 = 3;
            else if (Request["optFeedback2"] == "Disagree")
                weight2 = 2;
            else if (Request["optFeedback2"] == "Strongly Disagree")
                weight2 = 1;
            else
                weight2 = 0;

            //question 3
            if (Request["optFeedback3"] == "Strongly Agree")
                weight3 = 5;
            else if (Request["optFeedback3"] == "Agree")
                weight3 = 4;
            else if (Request["optFeedback3"] == "Neutral")
                weight3 = 3;
            else if (Request["optFeedback3"] == "Disagree")
                weight3 = 2;
            else if (Request["optFeedback3"] == "Strongly Disagree")
                weight3 = 1;
            else
                weight3 = 0;

            //question 4
            if (Request["optFeedback4"] == "Strongly Agree")
                weight4 = 5;
            else if (Request["optFeedback4"] == "Agree")
                weight4 = 4;
            else if (Request["optFeedback4"] == "Neutral")
                weight4 = 3;
            else if (Request["optFeedback4"] == "Disagree")
                weight4 = 2;
            else if (Request["optFeedback4"] == "Strongly Disagree")
                weight4 = 1;
            else
                weight4 = 0;

            //question 5
            if (Request["optFeedback5"] == "Strongly Agree")
                weight5 = 5;
            else if (Request["optFeedback5"] == "Agree")
                weight5 = 4;
            else if (Request["optFeedback5"] == "Neutral")
                weight5 = 3;
            else if (Request["optFeedback5"] == "Disagree")
                weight5 = 2;
            else if (Request["optFeedback5"] == "Strongly Disagree")
                weight5 = 1;
            else
                weight5 = 0;

            //question 6
            if (Request["optFeedback6"] == "Strongly Agree")
                weight6 = 5;
            else if (Request["optFeedback6"] == "Agree")
                weight6 = 4;
            else if (Request["optFeedback6"] == "Neutral")
                weight6 = 3;
            else if (Request["optFeedback6"] == "Disagree")
                weight6 = 2;
            else if (Request["optFeedback6"] == "Strongly Disagree")
                weight6 = 1;
            else
                weight6 = 0;

            //question 7
            if (Request["optFeedback7"] == "Strongly Agree")
                weight7 = 5;
            else if (Request["optFeedback7"] == "Agree")
                weight7 = 4;
            else if (Request["optFeedback7"] == "Neutral")
                weight7 = 3;
            else if (Request["optFeedback7"] == "Disagree")
                weight7 = 2;
            else if (Request["optFeedback7"] == "Strongly Disagree")
                weight7 = 1;
            else
                weight7 = 0;

            //question 8
            if (Request["optFeedback8"] == "Strongly Agree")
                weight8 = 5;
            else if (Request["optFeedback8"] == "Agree")
                weight8 = 4;
            else if (Request["optFeedback8"] == "Neutral")
                weight8 = 3;
            else if (Request["optFeedback8"] == "Disagree")
                weight8 = 2;
            else if (Request["optFeedback8"] == "Strongly Disagree")
                weight8 = 1;
            else
                weight8 = 0;
            
            //question 9
            if (Request["optFeedback9"] == "Strongly Agree")
                weight9 = 5;
            else if (Request["optFeedback9"] == "Agree")
                weight9 = 4;
            else if (Request["optFeedback9"] == "Neutral")
                weight9 = 3;
            else if (Request["optFeedback9"] == "Disagree")
                weight9 = 2;
            else if (Request["optFeedback9"] == "Strongly Disagree")
                weight9 = 1;
            else
                weight9 = 0;

            //question 10
            if (Request["optFeedback10"] == "Strongly Agree")
                weight10 = 5;
            else if (Request["optFeedback10"] == "Agree")
                weight10 = 4;
            else if (Request["optFeedback10"] == "Neutral")
                weight10= 3;
            else if (Request["optFeedback10"] == "Disagree")
                weight10 = 2;
            else if (Request["optFeedback10"] == "Strongly Disagree")
                weight10 = 1;
            else
                weight10 = 0;

            //question 11
            if (Request["optFeedback11"] == "Strongly Agree")
                weight11 = 5;
            else if (Request["optFeedback11"] == "Agree")
                weight11 = 4;
            else if (Request["optFeedback11"] == "Neutral")
                weight11 = 3;
            else if (Request["optFeedback11"] == "Disagree")
                weight11 = 2;
            else if (Request["optFeedback11"] == "Strongly Disagree")
                weight11 = 1;
            else
                weight11 = 0;

            //question 12
            if (Request["optFeedback12"] == "Strongly Agree")
                weight12 = 5;
            else if (Request["optFeedback12"] == "Agree")
                weight12 = 4;
            else if (Request["optFeedback12"] == "Neutral")
                weight12 = 3;
            else if (Request["optFeedback12"] == "Disagree")
                weight12 = 2;
            else if (Request["optFeedback12"] == "Strongly Disagree")
                weight12 = 1;
            else
                weight12 = 0;

            ComputeScore myComputedScore = new ComputeScore();
            myComputedScore.Average(weight1, weight2, weight3, weight9, weight10, weight12);
            myComputedScore.ComputeLetterGrade(myComputedScore.averageScore);
            courseRating = myComputedScore.letterGrade;

            myComputedScore.Average(weight4, weight5, weight6, weight7, weight8, weight11);
            myComputedScore.ComputeLetterGrade(myComputedScore.averageScore);
            professorRating = myComputedScore.letterGrade;
            
            //courseScore = myComputedScore.Average(weight1, weight2, weight3, weight9, weight10, weight12);
            //professorScore = myComputedScore.Average(weight4, weight5, weight6, weight7, weight8, weight11);
            string message3 = "Based on your answers to questions 1, 2, 3, 9, 10 and 12, you gave this course a rating of " + courseRating + ". <br />";
            string message4 = "Based on your answers to questions 4, 5, 6, 7, 8 and 11, you gave your professor a rating of " + professorRating + "."; 

            lblMessage.Text = message;
            lblMessage2.Text = message2;
            lblCourseRating.Text = message3;
            lblProfessorRating.Text = message4;
        }
    }
}

//string temp = "optFeedback";
//int numberOfQuestion = 12;
//for (int i = 1; i <= numberofquestion; i++)
//{
//    temp = temp + i.tostring();
//}