using System.Runtime.Intrinsics.Arm;
using System;
using System.Text;

namespace Сумматор
{
    public partial class Form1 : Form
    {
        public Form1() //инициализация формы
        {
            InitializeComponent();
        }
        // Первое число
        private int firstNumber = 0;
        // Второе число
        private int secondNumber = 0;
        // Функция, которая вызывается при каждом изменении первого числа
        private void FirstUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Первое число = текущее значение из поля с первым числом
            firstNumber = (int)FirstUpDown.Value;
            //Выводим справа в лейбле FirstBinaryLabel двоичное представление для первого числа
            //вызывая функцию GetBinary(), созданную ниже 
            FirstBinaryLabel.Text = GetBinary(firstNumber);
            //Выводим в лейбл ResultLabel результат в двоичном формате 
            ResultLabel.Text = GetBinary(firstNumber + secondNumber);
            //Выводим десятичное представление суммы в лейбле ResultDecimal
            ResultDecimal.Text = (firstNumber + secondNumber).ToString();
            //Выводим текст описания в зависимости от текущей суммы чисел
            //вызывая функция AdditionalInfo(), созданную ниже
            ResultDescription.Text = AdditionalInfo();
        }
        // Функция, которая вызывается при каждом изменении второго числа, аналогично с первым
        private void SecondUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Второе число = текущее значение из поля со вторым числом
            secondNumber = (int)SecondUpDown.Value;
            //Выводим справа в лейбле SecondBinaryLabel двоичное представление для второго числа
            SecondBinaryLabel.Text = GetBinary(secondNumber);
            //Выводим в лейбл ResultLabel результат в двоичном формате 
            ResultLabel.Text = GetBinary(firstNumber + secondNumber);
            //Выводим десятичное представление суммы в лейбле ResultDecimal
            ResultDecimal.Text = (firstNumber + secondNumber).ToString();
            //Выводим текст описания в зависимости от текущей суммы чисел
            ResultDescription.Text = AdditionalInfo();
        }
        // Функция для вывода информации о том, положительное число или отрицательное
        private string AdditionalInfo()
        {
            //если сумма чисел положительна, то выводим строку
            return (firstNumber + secondNumber) >= 0 
                ? "Число положительное, следовательно, первый бит - 0" // о положительной сумме 
                : "Число отрицательное, следовательно, первый бит - 1";//если отрицательное - об отрицательной сумме
        }
        // Функция для перевода числа из десятичной в двоичную систему счисления
        // только для 16-разрядного ЗНАКОВОГО числа (число может быть отрицательным)
        // (диапазон чисел от -32768 до 32767)
        // как для обычного 16-битного числа, переполнение может происходить.
        private string GetBinary(int num)
        {
            //создаем строку результата
            string result = "";
            //создаем переменную с текущим количеством записанных в строку бит
            int countOfBits = 0;
            //переменная для подсчета остатка от деления при переводе в двоичную систему
            int rem = 0;

            //если число равно нулю, то выводим строку с 16-ю нулями
            if (num == 0)
            {
                return new string('0', 16);
            }
            //если число больше нуля, то
            if (num > 0)
            {
                //до тех пор пока количество бит меньше 16
                while (countOfBits < 16)
                {
                    countOfBits++;  //добавляем бит в количество
                    rem = num % 2;  //считаем остаток от деления результата на 2
                    num = num / 2;  //делим текущее число на 2
                    //в начало строки вставляем остаток от деления результата на 2
                    result = result.Insert(0, rem.ToString());
                }
                //даже если результат будет 0, то и остаток будет 0 
                //следовательно, остальные незначимые биты будут 0
            }
            //если же число отрицательное, то
            else
            {
                //число = -число - 1, так как происходит перевод в доп. код
                num = -num - 1;
                //если было например число 00000011 и нам его нужно было перевести в отрицательное число, то
                //то мы должны инвертировать каждый бит числа и отнять от результата единицу.

                //теперь до тех пор пока количество бит меньше 15
                while (countOfBits < 15)
                {
                    countOfBits++;  //добавляем бит в количество
                    //инверсия остатка от деления результата на два, то есть
                    //если остаток от деления равен единице, то rem = 0, иначе rem = 1
                    rem = (num % 2 == 1) ? 0 : 1;
                    num = num / 2;  //делим текущее число на 2
                    //в начало строки вставляем значение rem
                    result = result.Insert(0, rem.ToString());
                }
                //и 16 бит у нас равен единице.
                result = result.Insert(0, "1");
            }
            //возвращаем результат
            return result;
        }
    }
}
