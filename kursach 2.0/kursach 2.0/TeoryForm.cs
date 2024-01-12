using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace kursach_2._0
{
    public partial class TeoryForm : Form
    {
        private string[] pages;
        private int currentPage = 0;
        int m, s;

        //test
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int correctAnswers = 0;

        private bool StateMenu;
        private bool root = false;
        public TeoryForm()
        {
            StateMenu = true;
            InitializeComponent(); 
            LoadQuestions("Test.txt");
            DisplayQuestion(currentQuestionIndex);
        }
        private void TeoryForm_Load(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm(this);
            lg.ShowDialog();
            string filePath = "Teory.txt"; // Укажите путь к файлу
            TeoryRTB.LoadFile(filePath, RichTextBoxStreamType.PlainText);
            string text = File.ReadAllText(filePath);
            // разделение текста на страницы по символу *
            pages = text.Split('*');
            // отображение первой страницы
            DisplayCurrentPage();
        }

        public void setRoot(bool r)
        {
            root = r;
        }

        string lg;
        string FIO;
        public void AutoRIz(string text, string fio)
        {
            //какие-то действия(запролнение инфы аккаунта)
            Console.WriteLine(text);
            lg = (text);
            FIO = fio;
            if (lg == "adm")
            {
                root = true;
            }
            label1.Text = FIO;
            if (root == true)
            {
                EditingTeoryBTN.Visible = true;
                UpdateBTN.Visible = true;
                InfoBTN1.Visible = true;
                EditingTestBTN.Visible = true;
                InfoTestBTN.Visible = true;
            }
            else
            {
                EditingTeoryBTN.Visible = false;
                UpdateBTN.Visible = false;
                InfoBTN1.Visible = false;
                EditingTestBTN.Visible = false;
                InfoTestBTN.Visible = false;
            }
            Show();
        }

        // MenuPanel
        private void MenuPB_Click(object sender, EventArgs e)
        {
            int wMin = 50, wMax = 220;
            StateMenu = !StateMenu;
            if (StateMenu)
            {
                MenuPanel.Width = wMin;
            }
            else { MenuPanel.Width = wMax; }
        }
        private void TeoryPB_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            metroTile1.Text = "Теоритический материал";
        }
        private void TestPB_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            metroTile1.Text = "Тест";

            m = 10;
            s = 0;
            timer1.Start();
        }
        private void InfoPB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Электронное учебное пособие разработал студент 3 курса группы 182 Гордеев А.А.","Справка");
        }

        //TeoryShow
        private void DisplayCurrentPage()
        {
            TeoryRTB.Text = pages[currentPage];
            if (currentPage < pages.Length)
            {
                TeoryRTB.Text = pages[currentPage].Trim();
            }
        }
        private void NextStage_Click_1(object sender, EventArgs e)
        {
            
            if (currentPage < pages.Length - 1)
            {   
                currentPage++;            
                DisplayCurrentPage();
                LastStage.Enabled = true;
            }
            else
            {
                NextStage.Enabled = false;
                TestNext.Visible = true;
            }
        }
        private void LastStage_Click_1(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                DisplayCurrentPage();
                NextStage.Enabled = true;
                TestNext.Visible=false;
            }
            else
            {
                LastStage.Enabled = false;
            }
        }
        private void TestNext_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите приступить к тесту?","Внимание", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                tabControl1.SelectTab(2);
                metroTile1.Text = "Тест";
                //teory = true;
            }
        }

        //TeoryEditing
        private void EditingTeoryBTN_Click(object sender, EventArgs e)
        {
            string filePath = "Teory.txt";
            System.Diagnostics.Process.Start(filePath);
        }
        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            TeoryRTB.Clear();
            string filePath = "Teory.txt";
            TeoryRTB.LoadFile(filePath, RichTextBoxStreamType.PlainText);
            string text = File.ReadAllText(filePath);
            pages = text.Split('*');
            DisplayCurrentPage();
        }
        private void InfoBTN1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для разделения текста на страницы необходимо использовать символ '*'.\nПример: \nСтраница1* \nСтраница2* ","Информация по редактированию теории");
        }

        //TestShow
        public class Question
        {
            public string QuestionText { get; set; }
            public string[] Options { get; set; }
            public char CorrectAnswer { get; set; }

            public Question(string question, string[] options, char correctAnswer)
            {
                QuestionText = question;
                Options = options;
                CorrectAnswer = correctAnswer;
            }
        }
        private void LoadQuestions(string filePath)
        {
            questions = new List<Question>();
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i += 5)
            {
                string question = lines[i];
                string[] options = { lines[i + 1], lines[i + 2], lines[i + 3] };
                char correctAnswer = lines[i + 4][7]; // assuming the correct answer is always in the same format

                questions.Add(new Question(question, options, correctAnswer));
            }
        }
        private void DisplayQuestion(int index)
        {
            label5.Text = questions[index].QuestionText;
            radioButton1.Text = questions[index].Options[0];
            radioButton2.Text = questions[index].Options[1];
            radioButton3.Text = questions[index].Options[2];
        }
        private void NextQuestBTN_Click(object sender, EventArgs e)
        {
            ReadAnswer();
            if (currentQuestionIndex < questions.Count - 1)
            {
                currentQuestionIndex++;
                DisplayQuestion(currentQuestionIndex);
                BackQuestBTN.Enabled = true;
            }
            if (currentQuestionIndex == questions.Count - 1)
            {
                NextQuestBTN.Enabled = false;
            }
        }
        private void BackQuestBTN_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                DisplayQuestion(currentQuestionIndex);
                NextQuestBTN.Enabled = true;
            }
            if (currentQuestionIndex == 0)
            {
                BackQuestBTN.Enabled = false;
            }
        }
        private void CheckAnswer(char selectedAnswer)
        {
            if (selectedAnswer == questions[currentQuestionIndex].CorrectAnswer)
            {
                correctAnswers++;
            }
        }
        private void ReadAnswer()
        {
            char selectedAnswer = ' ';
            if (radioButton1.Checked)
            {
                selectedAnswer = 'a';
            }
            else if (radioButton2.Checked)
            {
                selectedAnswer = 'b';
            }
            else if (radioButton3.Checked)
            {
                selectedAnswer = 'c';
            }
            CheckAnswer(selectedAnswer);
        }
        private void ReportBTN_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label7.Text = "00";
            label8.Text = "00";

            ReadAnswer();
            int totalQuestions = questions.Count;
            double percentage = (double)correctAnswers / totalQuestions * 100;
            string grade = GetGrade(percentage);
            string comments = GetComments(percentage);
            MessageBox.Show($"Результат теста: Счет - {percentage}%, Оценка - {grade}, Коментарий - {comments}");
        }
        private string GetGrade(double percentage)
        {
            if (percentage >= 90)
            {
                return "5";
            }
            else if (percentage >= 75)
            {
                return "4";
            }
            else if (percentage >= 50)
            {
                return "3";
            }
            else
            {
                return "2";
            }
        }
        private string GetComments(double percentage)
        {
            if (percentage >= 90)
            {
                return "Отличная работа!";
            }
            else if (percentage >= 75)
            {
                return "Хорошая работа!";
            }
            else if (percentage >= 50)
            {
                return "Вы хорошо справились, но в некоторых областях есть куда совершенствоваться.";
            }
            else
            {
                return "Вам нужно больше учиться.";
            }
        }

        //EditingTest
        private void EditingTestBTN_Click(object sender, EventArgs e)
        {
            string filePath = "Test.txt";
            System.Diagnostics.Process.Start(filePath);
        }
        private void NextQuestBTN_EnabledChanged(object sender, EventArgs e)
        {
            ReportBTN.Visible = !NextQuestBTN.Enabled;
        }

        private void InfoTestBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для корректного вывода вопроса и ответов к нему, необходимо записать все построчно.\nПример: \nВопрос 1 \na) Вариант ответа 1 \nb) Вариант ответа 2 \nc) Вариант ответа 3 \nОтвет: a" ,"Информация по редактированию теста");
        }



        private void exitPB_Click(object sender, EventArgs e)
        {
            lg = "";
            FIO = "";
            tabControl1.SelectTab(0);

            LoginForm f = new LoginForm(this);
            f.ShowDialog();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == 0 && s == 0)
            {
                timer1.Stop();
                label7.Text = "00";
                label8.Text = "00";

                ReadAnswer();
                int totalQuestions = questions.Count;
                double percentage = (double)correctAnswers / totalQuestions * 100;
                string grade = GetGrade(percentage);
                string comments = GetComments(percentage);
                MessageBox.Show($"Результат теста: Счет - {percentage}%, Оценка - {grade}, Коментарий - {comments}","Время вышло");

            }
            label7.Text = Convert.ToString(m);
            label8.Text = Convert.ToString(s);
        }
    }
}
