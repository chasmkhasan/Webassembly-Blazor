using Microsoft.AspNetCore.Components;
using Quizzing.Models;

namespace Quizzing.Pages
{
    public class QuizCardBase : ComponentBase
    {
        public List<Question> Questions { get; set;} = new List<Question>();
        protected int questionIndex = 0;
        protected int score = 0;

        protected override Task OnInitializedAsync()
        {
            LoadQuestions();

            return base.OnInitializedAsync();
        }

        protected void OptionSelected(string option)
        {
            if(option == Questions[questionIndex].Answer)
            {
                score++;
            }
            questionIndex++;
        }

        protected void RestartQuiz()
        {
            score = 0;
            questionIndex = 0;
        }

        private void LoadQuestions()
        {
            Question q1 = new Question
            {
                QuestionTitle = "How many Pilar does have in C#?",
                Options = new List<string>() { "3", "4", "2", "5" },
                Answer = "4"
            };

            Question q2 = new Question
            {
                QuestionTitle = "Which one is the First programming Languages in this planet?",
                Options = new List<string>() { "Java", "JavaScripts", "C", "C#" },
                Answer = "C"
            };

            Question q3 = new Question
            {
                QuestionTitle = "Which country has won the ICC WorldCup 2023?",
                Options = new List<string>() { "India", "South Africa", "Australia", "New Zealand" },
                Answer = "Australia"
            };
            Question q4 = new Question
            {
                QuestionTitle = "How many courtry does have in Nordic Region?",
                Options = new List<string>() { "4", "5", "6", "3" },
                Answer = "5"
            };

            Questions.AddRange(new List<Question> { q1, q2, q3, q4 });
        }
    }
}
