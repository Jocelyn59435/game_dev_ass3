using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject item;
    public AudioSource audioClip;
    private Tweener tweener;
    private float interval = 0.25f;
    private float passedTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        audioClip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        passedTime += Time.deltaTime;

        if (passedTime >= interval)
        {
            audioClip.Play();
            passedTime = 0.0f;
        }
        
        if (item.transform.position == new Vector3(-12.5f, 14.5f, 0.0f))
        {
            item.transform.localRotation = Quaternion.Euler(0, 0, 0);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-7.5f, 14.5f, 0.0f), 1.0f);
        }
        if (item.transform.position == new Vector3(-7.5f, 14.5f, 0.0f))
        {
            item.transform.localRotation = Quaternion.Euler(0, 0, 270);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-7.5f, 10.5f, 2.0f), 1.0f);
        }
        if (item.transform.position == new Vector3(-7.5f, 10.5f, 2.0f))
        {
            item.transform.localRotation = Quaternion.Euler(0, 180, 0);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-12.5f, 10.5f, 2.0f), 1.0f);
        }
        if (item.transform.position == new Vector3(-12.5f, 10.5f, 2.0f))
        {
            item.transform.localRotation = Quaternion.Euler(0, 0, 90);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-12.5f, 14.5f, 0.0f), 1.0f);
        }
    }
}

