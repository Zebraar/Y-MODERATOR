using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class FakeCrash : MonoBehaviour
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

    public void CauseFakeError(string text)
    {
        // Вызываем окно: текст, заголовок, иконка критической ошибки (0x10)
        MessageBox(IntPtr.Zero, text, "Fatal Error", 0x10);
        
        // Сразу после закрытия окна выключаем игру
        Application.Quit();
    }
}
