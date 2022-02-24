using System.Collections;
using UnityEngine;

public class Cylinder3 : MonoBehaviour
{

    public float maxSize;
    public float growFactor;
    public float waitTime;

    void Start()
    {
        StartCoroutine(Scale());
    }

    IEnumerator Scale()
    {
        float timer = 0;

        while (true)
        {
            // Scale up Cylinder size to growth max with respect to time.
            while (maxSize > transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
                yield return null;
            }

            // Wait after hitting growth max.
            yield return new WaitForSeconds(waitTime);

            timer = 0;

            // Scale down Cylinder size after reaching growth max.
            while (1 < transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
                yield return null;
            }

            timer = 0;

            // Wait after hitting growth min.
            yield return new WaitForSeconds(waitTime);
        }
    }

}
