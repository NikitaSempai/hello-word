//Программа с использованием диалогового окна
// Дополнительные аргументы
using System.Windows.Forms; 


class Afanasev_Nikita_229193 // класс программы
{
    static void Main()
    {
        MessageBox.Show("Запустить игру The Witcher 3 ?", //сообщение в окне 
        "The witcher 3 Wild Hunt",  //название окна  
        MessageBoxButtons.YesNo, //кнопки диалогового окна
        MessageBoxIcon.Question // Пиктограмма диалогового окна
        );

       MessageBox.Show("При запуске данного приложения возникла ошибка" +
       " Хотите исправить ошибку ? ", //изменяем сообщение в окне 
       "Помощник Windows",  //меняем название окна  
       MessageBoxButtons.OKCancel, //добавляем новые кнопки диалогового окна
       MessageBoxIcon.Error // вводим новую пиктограмму для данного окна
       );

        MessageBox.Show("Данное приложение может навредить вашему компьютеру !", //изменяем сообщение в окне  
       "Безопасность Windows ", //меняем название окна 
       MessageBoxButtons.RetryCancel, //добавляем новые кнопки диалогового окна
       MessageBoxIcon.Warning // вводим новую пиктограмму для данного окна
       );

       MessageBox.Show("Настройки персонализации Windows были применены", //изменяем сообщение в окне
       "Персонализация", //меняем название окна  
       MessageBoxButtons.OK, //добавляем новые кнопки диалогового окна
       MessageBoxIcon.Information // вводим новую пиктограмму для данного окна
       );

    }
}
