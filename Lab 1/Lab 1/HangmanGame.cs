using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        private string[] words = { "NAGGERS", "HATCH", "MAGGOT", "PEACH", "HUNT" };
        private string secretWord;
        private char[] guessedWord;
        private int attemptsLeft = 6;
        private List<char> usedLetters = new List<char>();

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            secretWord = words[random.Next(words.Length)];

            guessedWord = new char[secretWord.Length];
            for (int i = 0; i < secretWord.Length; i++)
                guessedWord[i] = '_';

            attemptsLeft = 6;
            usedLetters.Clear();
            UpdateDisplay();
            txtLetter.Text = "";
            txtLetter.Focus();
        }

        private void UpdateDisplay()
        {
            // Обновляем слово и попытки
            lblWord.Text = string.Join(" ", guessedWord);
            lblAttempts.Text = $"Попытки: {attemptsLeft}";

            // Обновляем использованные буквы
            lstUsedLetters.Items.Clear();
            foreach (char letter in usedLetters)
                lstUsedLetters.Items.Add(letter);

            // Обновляем визуализацию виселицы
            DrawHangman();
        }

        private void DrawHangman()
        {
            Bitmap bmp = new Bitmap(picHangman.Width, picHangman.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen pen = new Pen(Color.Brown, 3);

                // Всегда рисуем основу виселицы
                g.DrawLine(pen, 20, 180, 80, 180);  // основание
                g.DrawLine(pen, 30, 180, 30, 30);   // столб
                g.DrawLine(pen, 30, 30, 100, 30);   // перекладина
                g.DrawLine(pen, 100, 30, 100, 50);  // верёвка

                // Рисуем человечка в зависимости от ошибок
                Pen manPen = new Pen(Color.Black, 2);

                if (attemptsLeft <= 5) // голова
                    g.DrawEllipse(manPen, 90, 50, 20, 20);

                if (attemptsLeft <= 4) // тело
                    g.DrawLine(manPen, 100, 70, 100, 120);

                if (attemptsLeft <= 3) // левая рука
                    g.DrawLine(manPen, 100, 80, 80, 100);

                if (attemptsLeft <= 2) // правая рука
                    g.DrawLine(manPen, 100, 80, 120, 100);

                if (attemptsLeft <= 1) // левая нога
                    g.DrawLine(manPen, 100, 120, 80, 150);

                if (attemptsLeft <= 0) // правая нога
                    g.DrawLine(manPen, 100, 120, 120, 150);
            }

            picHangman.Image = bmp;
        }

        private void CheckLetter(char letter)
        {
            if (usedLetters.Contains(letter))
            {
                MessageBox.Show("Буква уже была!");
                return;
            }

            usedLetters.Add(letter);
            bool found = false;

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == letter)
                {
                    guessedWord[i] = letter;
                    found = true;
                }
            }

            if (!found) attemptsLeft--;

            UpdateDisplay();
            CheckGameEnd();
        }

        private void CheckGameEnd()
        {
            if (new string(guessedWord) == secretWord)
            {
                MessageBox.Show($"Победа! Слово: {secretWord}");
                StartNewGame();
            }
            else if (attemptsLeft <= 0)
            {
                MessageBox.Show($"Проигрыш! Слово: {secretWord}");
                StartNewGame();
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (txtLetter.Text.Length > 0)
            {
                // Проверяем, не русская ли буква
                char letter = txtLetter.Text[0];
                if ((letter >= 'А' && letter <= 'Я') || (letter >= 'а' && letter <= 'я'))
                {
                    MessageBox.Show("Пожалуйста, вводите только английские буквы!", "Ошибка ввода",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLetter.Text = "";
                    txtLetter.Focus();
                    return;
                }

                CheckLetter(letter);
                txtLetter.Text = "";
            }
        }

        private void txtLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Английские буквы - разрешаем
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            // Русские буквы - показываем ошибку и стираем
            else if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я'))
            {
                MessageBox.Show("Пожалуйста, вводите только английские буквы!", "Ошибка ввода",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                // Очищаем текстовое поле
                txtLetter.Text = "";
            }
            // Enter - угадать букву
            else if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuess_Click(null, null);
                e.Handled = true;
            }
            // Все остальные символы - игнорируем
            else
            {
                e.Handled = true;
            }
        }

        private void txtLetter_TextChanged(object sender, EventArgs e)
        {
            // Дополнительная проверка при изменении текста
            if (txtLetter.Text.Length > 0)
            {
                char letter = txtLetter.Text[0];
                if ((letter >= 'А' && letter <= 'Я') || (letter >= 'а' && letter <= 'я'))
                {
                    MessageBox.Show("Пожалуйста, вводите только английские буквы!", "Ошибка ввода",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLetter.Text = "";
                    txtLetter.Focus();
                }
            }
        }
    }
}