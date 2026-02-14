using UnityEngine;
using UnityEngine.UI;

public class ButtonsLogic : MonoBehaviour
{

    public Sprite[] Memasiki;
    public Sprite[] Scary;
    public Image MainImage;
    public int CurrentImage = 0;

    public void OnClickApprove()
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
        Debug.Log("Одобрили изображение");
    }

    public void OnClickReject()
    {
        CurrentImage++;
        if(CurrentImage > Memasiki.Length)
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
