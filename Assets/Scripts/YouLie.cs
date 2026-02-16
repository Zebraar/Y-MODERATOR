using UnityEngine;
using System.Collections;

public class YouLie : MonoBehaviour
{
    
    public GameObject Text;
    private System.Random rnd = new System.Random();
    int x = 0;
    int y = 0;
    void Start()
    {
        StartCoroutine(WaitAndDoLie(0.3f)); 
    }
    public void YouLiee()
    {
            
            int x = rnd.Next(-750, 750);
            int y = rnd.Next(-350, 350);
            Instantiate(Text, new Vector3(x, y, 0), Quaternion.identity);
            WaitAndDoLie(0.3f);
    }

    IEnumerator WaitAndDoLie(float delay)
    {
        // Пауза
        yield return new WaitForSeconds(delay);

        // Код, который выполнится после задержки
        YouLiee();
    }

}
