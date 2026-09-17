using UnityEngine;
using System.Collections;

public class Disolver : MonoBehaviour
{
    public float disolveDuration = 2f;
    public float disolveStrength;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartDisolve();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            StartAppear();
        }
    }

    private void StartDisolve()
    {
      StartCoroutine(Disolve());
    }
    
    private void StartAppear()
    {
      StartCoroutine(Appear());
    }

    private IEnumerator Disolve()
    {
        float elapsedTime = 0f;
        
        Material disolveMaterial = GetComponent<Renderer>().material;

        while (elapsedTime < disolveDuration)
        {
            elapsedTime += Time.deltaTime;

            disolveStrength = Mathf.Lerp(0f, 1f, elapsedTime / disolveDuration);
            disolveMaterial.SetFloat("_EscalaDisolver", disolveStrength);

            yield return null;
        }
    }

    private IEnumerator Appear()
    {
        float elapsedTime = 0f;
        
        Material disolveMaterial = GetComponent<Renderer>().material;

        while (elapsedTime < disolveDuration)
        {
            elapsedTime += Time.deltaTime;

            disolveStrength = Mathf.Lerp(1f, 0f, elapsedTime / disolveDuration);
            disolveMaterial.SetFloat("_EscalaDisolver", disolveStrength);

            yield return null;
        }
    }
}
