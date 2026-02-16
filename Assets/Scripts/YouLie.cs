using UnityEngine;
using System.Collections;

public class YouLie : MonoBehaviour
{
    
    public GameObject Text;
    public Transform canvasTransform; 
    private System.Random rnd = new System.Random();
    int x = 0;
    int y = 0;
    public void StartLie()
    {
        StartCoroutine(WaitAndDoLie(0.05f)); 
    }
    public void YouLiee()
    {
        for(int i = 0; i < 200; i++)
        {
            int x = rnd.Next(-750, 750);
            int y = rnd.Next(-350, 350);
            GameObject newText = Instantiate(Text, canvasTransform);
            newText.transform.localPosition = new Vector3(x, y, 0);
            StartCoroutine(WaitAndDoLie(0.05f)); 
        }     
    }

    IEnumerator WaitAndDoLie(float delay)
    {
        // Пауза
        yield return new WaitForSeconds(delay);

        // Код, который выполнится после задержки
        YouLiee();
    }

}
