using UnityEngine;
using UnityEngine.UI;

public class ButtonsLogic : MonoBehaviour
{

    public Sprite[] images;
    public Image MainImage;
    public int CurrentImage = 0;

    public void OnClickApprove()
    {
        CurrentImage++;
        if(CurrentImage > images.Length)
        {
            CurrentImage = 0;
            Debug.Log("Начинаем с сначала массива");
        } else
        {
            MainImage.GetComponent<Image>().sprite = images[CurrentImage];
        }   
        Debug.Log("Одобрили изображение");
    }

    public void OnClickReject()
    {
        CurrentImage++;
        if(CurrentImage > images.Length)
        {
            CurrentImage = 0;
            Debug.Log("Начинаем с сначала массива");
        } else
        {
            MainImage.GetComponent<Image>().sprite = images[CurrentImage];
        }
        MainImage.GetComponent<Image>().sprite = images[CurrentImage];
        Debug.Log("Отклонили изображение");

    }

}
