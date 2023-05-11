using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp3
{
    
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        string otvet;
        Button button;
        Category category1 = new Category("Category1", new List<Question>
        {
                new Question("Вопрос1", "Ответ", 100),
                new Question("Вопрос2", "Ответ", 200),
                new Question("Вопрос3", "Ответ", 300),
                new Question("Вопрос4", "Ответ", 400),
                new Question("Вопрос5", "Ответ", 500)
        });
        Category category2 = new Category("Category2", new List<Question>
        {
                new Question("Вопрос1", "Ответ", 100),
                new Question("Вопрос2", "Ответ", 200),
                new Question("Вопрос3", "Ответ", 300),
                new Question("Вопрос4", "Ответ", 400),
                new Question("Вопрос5", "Ответ", 500)
        });
        Category category3 = new Category("Category3", new List<Question>
        {
                new Question("Вопрос1", "Ответ", 100),
                new Question("Вопрос2", "Ответ", 200),
                new Question("Вопрос3", "Ответ", 300),
                new Question("Вопрос4", "Ответ", 400),
                new Question("Вопрос5", "Ответ", 500)
        });
        Category category4 = new Category("Category4", new List<Question>
        {
                new Question("Вопрос1", "Ответ", 100),
                new Question("Вопрос2", "Ответ", 200),
                new Question("Вопрос3", "Ответ", 300),
                new Question("Вопрос4", "Ответ", 400),
                new Question("Вопрос5", "Ответ", 500)
        });
        Category category5 = new Category("Category5", new List<Question>
        {
                new Question("Вопрос1", "Ответ", 100),
                new Question("Вопрос2", "Ответ", 200),
                new Question("Вопрос3", "Ответ", 300),
                new Question("Вопрос4", "Ответ", 400),
                new Question("Вопрос5", "Ответ", 500)
        });

        private void Input(Question question, object sbutton)
        {
            ques.Content = question.Vopros;
            otvet = question.Answer;
            button = (Button)sbutton;
        }
        private void Answer(string _answer, Button button)
        {
            if (_answer.ToLower() == otvet.ToLower())
            {
                button.IsEnabled = false;
                answer.Clear();
                ques.Content = "";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Input(category1.Questions[0], sender);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Input(category1.Questions[1], sender);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Input(category1.Questions[2], sender);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Input(category1.Questions[3], sender);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Input(category1.Questions[4], sender);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        { 
            Input(category2.Questions[0], sender);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Input(category2.Questions[1], sender);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        { 
            Input(category2.Questions[2], sender);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Input(category2.Questions[3], sender);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Input(category2.Questions[4], sender);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Input(category3.Questions[0], sender);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Input(category3.Questions[1], sender);
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Input(category3.Questions[2], sender);
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Input(category3.Questions[3], sender);
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Input(category3.Questions[4], sender);
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            Input(category4.Questions[0], sender);
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            Input(category4.Questions[1], sender);
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            Input(category4.Questions[2], sender);
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
           Input(category4.Questions[3], sender);
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            Input(category4.Questions[4], sender);
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            Input(category5.Questions[0], sender);
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            Input(category5.Questions[1], sender);
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        { 
            Input(category5.Questions[2], sender);
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            Input(category5.Questions[3], sender);
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            Input(category5.Questions[4], sender);
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        { 
            Answer((string)answer.Text, button);
        }
    }




}
