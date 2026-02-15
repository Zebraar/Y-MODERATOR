using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonsLogic : MonoBehaviour
{
    public Sprite[] Memasiki;
    public Sprite[] ScaryImages;
    public Sprite[] NormalImages;
    public Image MainImage;
    
    private int CurrentImage = 0;
    private System.Random rnd = new System.Random();

    void Start()
    {
        UpdateImage();
    }

    public void OnClickApprove()
    {
        NextImage();
        Debug.Log("Одобрили изображение");
    }

    public void OnClickReject()
    {
        NextImage();
        Debug.Log("Отклонили изображение");
    }

    private void NextImage()
    {
        CurrentImage++;
        UpdateImage();
    }

    private void UpdateImage()
    {
        int chance = rnd.Next(2); 
        Debug.Log("Шанс (1 = Normal): " + chance);

        if (chance == 1 && NormalImages.Length > 0)
        {
            int index = CurrentImage % NormalImages.Length;
            MainImage.sprite = NormalImages[index];
            return; 
        }

        if (Memasiki.Length > 0)
        {
            int index = CurrentImage % Memasiki.Length;
            MainImage.sprite = Memasiki[index];
        }
    }
}