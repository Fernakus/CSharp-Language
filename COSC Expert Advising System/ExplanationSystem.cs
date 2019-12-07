/*  -------------------------------------------------------
 *  ExplanationSystem.cs
 *  -------------------------------------------------------
 *  Author:  Matthew Ferlaino
 *  Course:	 COSC3117
 *  ID:      169657520
 *  Email:   mferlaino@algomau.ca
 *  Date:	 Oct 21, 2019
 *  ------------------------------------------------------- */

// Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC_Expert_System
{
    class ExplanationSystem
    {
		string explanation;

        // No-arg Constructor
        public ExplanationSystem()
        {
            explanation = "";
        }

        public string generateCurrentStudentExplanation(bool doProject, string degree, string year, bool missedYear1Classes, bool missedYear2Classes, bool missedYear3Classes, bool missedYear4Classes)
        { 
            switch (year)
            {
                case "1":
                    if (missedYear1Classes)
                        explanation = "Welcome first year student! I hope you are off to an amazing start. Since this is year one and you are a current student requesting academic advice I assume" +
                                      " you are a bit into first semester or second semester. There are some class(es) you have not yet taken this year. To ensure future academic stability " +
                                      "I have listed the class(es) above that you need to ensure you complete this year. Hope I was of help!";
                    else
                        explanation = "Looks like you are all on par for first year required courses. If you want to receive academic adivce for your second year switch the year to 2. " +
                                      " If you need anything more just let me know! Don't forget to look into computer science electives!";
                    break;

                case "2":
                    if (missedYear1Classes && missedYear2Classes)
                        explanation = "Hello second year student! I have noticed that you have currently not finished some first year class(es). You need to complete these course(s) " +
                                      "before you can continue on. As for the second year class(es) you have not completed, ensure you complete your outlying first year classes before your second year class(es). " +
                                      "I have listed your second year class(es) you have not yet completed yet aswell. Keep it up all looks good!";

                    else if (missedYear1Classes)
                        explanation = "Hello second year student! I have noticed that you have currently not finished some first year class(es). You need to complete these courses " +
                                      "before you can continue on to a stable third year. The class(es) I have listed above are what you will need to complete from first year before the end of second year. Keep it up all looks good!";

                    else if (missedYear2Classes)
                        explanation = "Hello second year student! I have noticed that you have currently not finished some second year class(es). You need to complete these courses " +
                                      "before you can continue on to a stable third year. The class(es) I have listed above are what you will need to complete for your second year before third year. Keep it up all looks good!";

                    else 
                        explanation = "Looks like you are all on par for second year required courses. If you want to receive academic adivce for your third year switch the year to 3. " +
                                      " If you need anything more just let me know! Don't forget to look into computer science electives!";
                    break;

                case "3":
                    if (missedYear1Classes && missedYear2Classes && missedYear3Classes)
                        explanation = "Hello third year student! We have a bit of a discrepancy here since you have currently not finished some first year, second year and third year class(es). You MUST complete these course(s) " +
                                      "(primarily your missed first/second year courses) before you can continue on. As for the third year class(es) you have not completed, ensure you complete your outlying classes before you worry about anything third year related. " +
                                      "I have listed your third year class(es) you have not yet completed yet aswell. Be careful, you are an upper year student and missing many required courses, ensure we get you back on track!";

                    else if (missedYear1Classes && missedYear2Classes)
                        explanation = "Hello third year student! We have a bit of a discrepancy here since you have currently not finished some first year and second year class(es). You MUST complete these course(s) " +
                                      "before you can continue on to your fourth year. I noticed you have finished all your third year classes. Before you can continue to fourth year I must recommend you complete your outlying cours(es) " +
                                      "from year 1 and 2. Be careful, you are an upper year student and missing many requird courses, ensure we get you back on track!";

                    else if (missedYear1Classes && missedYear3Classes)
                        explanation = "Hello third year student! All seems to look good except you have not finished some first year and third(current) year class(es). You should complete your first year course(s) " +
                                      "before you finish your third year course(s). Before you can continue to fourth year I must recommend you finish up the listed first year class(es) before this current year's cours(es). " +
                                      "Besides that you are pretty on track so keep it up!";

                    else if (missedYear2Classes && missedYear3Classes)
                        explanation = "Hello third year student! All seems to look good except you have not finished some second year and third(current) year class(es). You should complete your second year course(s) " +
                                      "before you finish your third year courses. Before you can continue to fourth year I must recommend you finish up the listed second year class(es) before this current year's cours(es). " +
                                      "Besides that you are pretty on track so keep it up!";

                    else if (missedYear1Classes)
                        explanation = "Hello third year student! I have noticed that you have currently not finished some first year class(es). You MUST complete these courses " +
                                      "before you can continue on to a stable fourth year. The class(es) I have listed above are what you MUST complete before fourth year. Keep it up all looks good!";

                    else if (missedYear2Classes)
                        explanation = "Hello third year student! I have noticed that you have currently not finished some second year class(es). You MUST complete these courses " +
                                      "before you can continue on to a stable fourth year. The class(es) I have listed above are what you MUST complete before fourth year. Keep it up all looks good!";

                    else if (missedYear3Classes)
                        explanation = "Hello third year student! I have noticed that you have currently not finished some third year class(es). You should definitely complete these courses " +
                                      " soon before you contine on to a stable fourth year. The class(es) I have listed above are what you should complete before fourth year. Keep it up all looks good!";

                    else
                        explanation = "Looks like you are all on par for third year required courses. If you want to receive academic adivce for your final year switch the year to 4 and select if you would like to do a project. " +
                                      " If you need anything more just let me know! Don't forget to look into computer science electives!";
                    break;

                case "4":
                    if (missedYear1Classes && missedYear2Classes && missedYear3Classes)
                        explanation = "Hello fourth year student! We have a bit of a discrepancy here since you have currently not finished some first year, second year and third year class(es). You MUST complete these course(s) " +
                                      "before you can continue on. As for the fourth year class(es) you have or have not completed, ensure you complete your outlying classes before you worry about anything fourth year related. " +
                                      "I have listed all the fourth year class(es) you have not yet completed aswell but there are different variations for fourth year students depedning on if you want to do a " +
                                      "project or not. We can focus on this a bit later, in the meantime be careful, you are an upper year student and missing many required courses, ensure we get you back on track!";

                    else if (missedYear1Classes && missedYear2Classes)
                        explanation = "Hello fourth year student! We have a bit of a discrepancy here since you have currently not finished some first year & second year class(es) but have completed all your third year classes. You MUST complete these course(s) " +
                                      "before you can continue on. As for the fourth year class(es) you have or have not completed, ensure you complete your outlying classes before you worry about anything fourth year related. " +
                                      "I have listed all the fourth year class(es) you have not yet completed aswell but there are different variations for fourth year students depedning on if you want to do a " +
                                      "project or not. We can focus on this a bit later, in the meantime be careful, you are an upper year student and missing many required courses, ensure we get you back on track!";

                    else if (missedYear1Classes && missedYear3Classes)
                        explanation = "Hello fourth year student! We have a bit of a discrepancy here since you have currently not finished some first year & third year class(es) but have completed all your second year classes. You MUST complete these course(s) " +
                                      "before you can continue on. As for the fourth year class(es) you have or have not completed, ensure you complete your outlying classes before you worry about anything fourth year related. " +
                                      "I have listed all the fourth year class(es) you have not yet completed aswell but there are different variations for fourth year students depedning on if you want to do a " +
                                      "project or not. We can focus on this a bit later, in the meantime be careful, you are an upper year student and missing many required courses, ensure we get you back on track!";

                    else if (missedYear2Classes && missedYear3Classes)
                        explanation = "Hello fourth year student! We have a bit of a discrepancy here since you have currently not finished some second year & third year class(es) but have completed all your first year classes. You MUST complete these course(s) " +
                                      "before you can continue on. As for the fourth year class(es) you have or have not completed, ensure you complete your outlying classes before you worry about anything fourth year related. " +
                                      "I have listed all the fourth year class(es) you have not yet completed aswell but there are different variations for fourth year students depedning on if you want to do a " +
                                      "project or not. We can focus on this a bit later, in the meantime be careful, you are an upper year student and missing many required courses, ensure we get you back on track!";

                    else if (missedYear1Classes)
                        explanation = "Hello fourth year student! We have a bit of a discrepancy here since you have currently not finished some first year class(es) but have completed all your classes from your other years. You MUST complete these course(s) " +
                                      "before you can continue on. As for the fourth year class(es) you have or have not completed, ensure you complete your outlying classes before you worry about anything fourth year related. " +
                                      "I have listed all the fourth year class(es) you have not yet completed aswell but there are different variations for fourth year students depedning on if you want to do a " +
                                      "project or not. We can focus on this a bit later, in the meantime be careful, you are an upper year student and missing many required courses, ensure we get you back on track!";

                    else if (missedYear2Classes)
                        explanation = "Hello fourth year student! We have a bit of a discrepancy here since you have currently not finished some second year class(es) but have completed all your classes from your other years. You MUST complete these course(s) " +
                                      "before you can continue on. As for the fourth year class(es) you have or have not completed, ensure you complete your outlying classes before you worry about anything fourth year related. " +
                                      "I have listed all the fourth year class(es) you have not yet completed aswell but there are different variations for fourth year students depedning on if you want to do a " +
                                      "project or not. We can focus on this a bit later, in the meantime be careful, you are an upper year student and missing many required courses, ensure we get you back on track!";

                    else if (missedYear3Classes)
                        explanation = "Hello fourth year student! You are almost done your degree! We need to ensure you have finished some third year class(es) you have outlying from year 3. You MUST complete these course(s) " +
                                      "before you can continue on to completing your current year. As for the fourth year class(es) you have or have not completed, ensure you complete your outlying classes before you worry about anything fourth year related. " +
                                      "I have listed all the fourth year class(es) you have not yet completed aswell but there are different variations for fourth year students depedning on if you want to do a " +
                                      "project or not. We can focus on this a bit later, in the meantime lets finish those outlying classes and continue onwards!";
                   else if (doProject)
                        explanation = "Hello fourth year student! You are almost done your degree! At this point you have a choice of if you want to do a 4th year project or not. I can see you have decided to " +
                                      "do a fourth year project. I have listed all the classes from fourth year that are available for you to take. Remember, since you are going to be doing a project you only need 6 credits from other 4th year classes. " +
                                      "If you have already begun completing some 4th year classes you can still decide to do a project. The options are on the table, I've displayed what you can take. Ensure you're project is approved by the department of computer science before " +
                                      "you begin your research!";

                    else
                        explanation = "Hello fourth year student! You are almost done your degree! At this point you have a choice of if you want to do a 4th year project or not. I can see you have decided not to " +
                                      "do a fourth year project. I have listed all the classes from fourth year that are available for you to take. Remember, since you are not going to be doing a project you only need 9 credits from other 4th year classes. " +
                                      "If you have already begun completing some 4th year classes then remember all you need is 9 credits worth. The options are on the table, I've displayed what you can take. Keep on pushing you are almost there!";
                    break;
            }

            return explanation;
        }

        public string generateNewStudentExplanation(string degree)
        {
            switch (degree)
            {
                case "Bachelor of Computer Science (Honours)":
                    explanation = "A very big welcome to Algoma University! I am happy you have decided to choose the Bachelor of Computer Science (Honours) degree. I have listed all of the classes you will need to take throughout your time at " +
                                  "Algoma University. This is a rough sketch of many of the required courses you will need to take however in fourth year you can have the choice of doing a project instead of taking a 9 credit course load. Depending on the degree the " +
                                  "specific courses you will need to take might vary. Utilize the course legend to display further information pertaining to course codes and degrees. Go thunderbirds!";
                    break;

                case "Bachelor of Computer Science - Computer Game Technology (speacialization)":
                    explanation = "A very big welcome to Algoma University! I am happy you have decided to choose the Bachelor of Computer Science - Computer Game Technology (speacialization) degree. I have listed all of the classes you will need to take throughout your time at " +
                                  "Algoma University. This is a rough sketch of many of the required courses you will need to take however in fourth year you can have the choice of doing a project instead of taking a 9 credit course load. Depending on the degree the " +
                                  "specific courses you will need to take might vary. Utilize the course legend to display further information pertaining to course codes and degrees. Go thunderbirds!";
                    break;

                case "Bachelor of Computer Science - Mobile Software Engineering(specialization)":
                    explanation = "A very big welcome to Algoma University! I am happy you have decided to choose the Bachelor of Computer Science - Mobile Software Engineering(specialization) degree. I have listed all of the classes you will need to take throughout your time at " +
                                  "Algoma University. This is a rough sketch of many of the required courses you will need to take however in fourth year you can have the choice of doing a project instead of taking a 9 credit course load. Depending on the degree the " +
                                  "specific courses you will need to take might vary. Utilize the course legend to display further information pertaining to course codes and degrees. Go thunderbirds!";
                    break;

                case "Bachelor of Science (Honours & Non-honours Single Major) Computer Science":
                    explanation = "A very big welcome to Algoma University! I am happy you have decided to choose the Bachelor of Science (Honours & Non-honours Single Major) Computer Science degree. I have listed all of the classes you will need to take throughout your time at " +
                                  "Algoma University. This is a rough sketch of many of the required courses you will need to take however in fourth year you can have the choice of doing a project instead of taking a 9 credit course load. Depending on the degree the " +
                                  "specific courses you will need to take might vary. Utilize the course legend to display further information pertaining to course codes and degrees. Go thunderbirds!";
                    break;
            }

            return explanation;
        }
    }
}
