using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] A = new int[10]; // Объявляем массив A

            // Заполняем массив A случайными ненулевыми целыми числами
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                A[i] = random.Next(-100, 100); // Задай нужный диапазон случайных чисел
                if (A[i] == 0) // Если случайно сгенерировано 0, заменяем на случайное ненулевое число
                    A[i] = random.Next(-100, 100);
            }

            int result = 0; // Переменная для хранения результата

            // Перебираем элементы массива A
            for (int i = 0; i < 10; i++)
            {
                if (A[i] < A[9]) // Если находим элемент AK, удовлетворяющий неравенству AK < A9
                {
                    result = A[i]; // Присваиваем результату значение AK
                    break; // Прерываем цикл, так как нашли нужный элемент
                }
            }

            // Выводим результат на форму
            if (result != 0)
                listBox1.Items.Add($"Первый элемент AK, удовлетворяющий неравенству AK < A9: {result}");
            else
                listBox1.Items.Add("Таких элементов нет, выводим 0");
        }
    }
}
