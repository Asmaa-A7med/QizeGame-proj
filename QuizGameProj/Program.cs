namespace QuizGameProj
{
    internal class Program
    {

       private  static bool CheckAnswer(string UserInput , string CorrectAnswer)
        {
            if (string.IsNullOrEmpty(UserInput))
            {
                throw new Exception("Answer can't be wmpty");
            }
            // check if the answer is right 
            if(UserInput == CorrectAnswer) 
            {
            return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Quiz Game !");
            Console.WriteLine();
            Console.WriteLine("Please answer the follwing qustions");

            //creat array of questions
            string[] questions = new string[3]
            {
                "1 : what is the capital of Palestine  ?",
                "1 : what is the capital of Egypt ?",
                "1 : what is the capital of Italy ?",
            };

            // create array of answers
            string[] answers = new string[3]
            {
                "Al-Quds",
                 "Cairo",
                 "Roma",
            };
            int CorrectAnswers = 0;

            // loop on the questions 
            for(int i =0; i <questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                //get answer:
                string UserAnswer = Console.ReadLine();

                try
                {
                    bool result = CheckAnswer(UserAnswer, answers[i]);
                    if (result == true)
                    {
                        Console.WriteLine("Correct Answer !");
                        CorrectAnswers++;
                    }
                    else
                    {
                        Console.WriteLine($"sorry, Incorrect Answer, the correct answer is {answers[i]}");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               

            }
            Console.WriteLine($"Your score is {CorrectAnswers} of 3");
            Console.WriteLine("Quiz completed, Thank you for playing");

        }
    }
}