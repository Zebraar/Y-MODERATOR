using UnityEngine;
using System.Collections;

public class YouLie : MonoBehaviour
{
    
    public GameObject Text;
    public Transform canvasTransform; 
    private System.Random rnd = new System.Random();
    public FakeCrash crash;
    int x = 0;
    int y = 0;
    int i = 0;
    public void StartLie()
    {
        StartCoroutine(WaitAndDoLie(0.01f));
    }
    public void YouLiee()
    {
        i++;
        if(i >= 300)
        {
            for(int i = 0; i < 10; i++)
                crash.CauseFakeError("YOU LIE");
        } else
        {
            int x = rnd.Next(-1500, 1500);
            int y = rnd.Next(-700, 700);
            GameObject newText = Instantiate(Text, canvasTransform);
            newText.transform.localPosition = new Vector3(x, y, 0);
            newText.SetActive(true);
            StartCoroutine(WaitAndDoLie(0.01f));
        }
                 
    }

    IEnumerator WaitAndDoLie(float delay)
    {
        // Пауза
        yield return new WaitForSeconds(delay);

        YouLiee();
    }

}
