using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonsLogic : MonoBehaviour
{

    public Sprite[] Memasiki;
    public Sprite[] ScaryImages;
    public Sprite[] NormalImages;
    public Image MainImage;
    public int CurrentImage = 0;
    private System.Random rnd = new System.Random();
    private int ShowNormalImageChance = 0;

    void Start()
    {
        MainImage.GetComponent<Image>().sprite = Memasiki[CurrentImage];
    }

    public void OnClickApprove()
    {
        CurrentImage++;
        ShowNormalImageChance = rnd.Next(5);
        Debug.Log("Шанс показа обычного изображения: " + ShowNormalImageChance);
        if(ShowNormalImageChance == 4)
        {
            if(CurrentImage >= NormalImages.Length)
            {
                CurrentImage = 0;
                MainImage.GetComponent<Image>().sprite = NormalImages[CurrentImage];
            } else
            {
                MainImage.GetComponent<Image>().sprite = NormalImages[CurrentImage];
            }
            
        }
        if(CurrentImage >= Memasiki.Length)
        {
            CurrentImage = 0;
            Debug.Log("Начинаем с сначала массива");
            MainImage.GetComponent<Image>().sprite = Memasiki[CurrentImage];
        } else
        {
            MainImage.GetComponent<Image>().sprite = Memasiki[CurrentImage];
        }   
        Debug.Log("Одобрили изображение");
    }

    public void OnClickReject()
    {
        CurrentImage++;
        if(CurrentImage >= Memasiki.Length)
        {
            CurrentImage = 0;
            Debug.Log("Начинаем с сначала массива");
            MainImage.GetComponent<Image>().sprite = Memasiki[CurrentImage];
        } else
        {
            MainImage.GetComponent<Image>().sprite = Memasiki[CurrentImage];
        }
        MainImage.GetComponent<Image>().sprite = Memasiki[CurrentImage];
        Debug.Log("Отклонили изображение");

    }

}
