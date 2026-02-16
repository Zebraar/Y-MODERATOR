using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ButtonsLogic : MonoBehaviour
{
    public Sprite[] Memasiki;
    public Sprite[] ScaryImages;
    public Sprite[] NormalImages;
    public Image MainImage;
    private AspectRatioFitter aspectFitter;
    private YouLie lie = new YouLie();
    
    private int CurrentImage = 0;
    private System.Random rnd = new System.Random();
    public int TotalSkippedImages = 0;
    private int ScaryChance = 100;

    void Start()
    {
        aspectFitter = MainImage.GetComponent<AspectRatioFitter>();
        UpdateImage();
    }

    public void OnClickApprove()
    {
        if (ScaryImages.Contains(MainImage.sprite))
        {
            lie.StartLie();
        }
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
        TotalSkippedImages++;
        UpdateImage();
    }

    private void UpdateImage()
    {
        int chance = rnd.Next(2); 
        int ShowScaryImageChance = rnd.Next(Mathf.Max(1, ScaryChance));
        Debug.Log("Шанс (1 = Normal): " + chance);

        Sprite selectedSprite = null;

        if (chance == 1)
        {
            int index = CurrentImage % NormalImages.Length;
            selectedSprite = NormalImages[index];
        }
        else
        {
            if (TotalSkippedImages >= 50) ScaryChance = 2;
            else if (TotalSkippedImages >= 30) ScaryChance = 5;
            else if (TotalSkippedImages >= 20) ScaryChance = 10;

            if (ShowScaryImageChance == 1 && ScaryImages.Length > 0)
            {
                int index = CurrentImage % ScaryImages.Length;
                selectedSprite = ScaryImages[index];
            }
            else
            {
                int index = CurrentImage % Memasiki.Length;
                selectedSprite = Memasiki[index];
            }
        }

        if (selectedSprite != null && MainImage != null)
        {
            MainImage.sprite = selectedSprite;
            
            if (aspectFitter != null)
            {
                aspectFitter.aspectRatio = selectedSprite.rect.width / selectedSprite.rect.height;
            }
        }
    }
}
