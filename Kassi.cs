using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Kassi : MonoBehaviour
{
 
    public static int count=0;
    public GameObject sprenging;
    private TextMeshProUGUI countText;
    void Start()
    {
        countText = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
        //sprenging= GetComponent<Explosion>
        count = 0;
        SetCountText();
    }
    private void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "kula")
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
            Debug.Log("varð fyrir kúlu");
            count = count + 1;
            SetCountText();
            Sprengin();
        }
    }
    void SetCountText()
    {
        countText.text = "Stig: " + count.ToString();
        if (count >= 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation);
    }
}
