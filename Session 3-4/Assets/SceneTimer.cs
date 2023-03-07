using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Scenetimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTimer()
    {
        StartCoroutine(Scenetimer());
    }
    public IEnumerator Scenetimer()
    {
        yield return new WaitForSeconds(20f);

        SceneManager.LoadScene(2);
    }
}
