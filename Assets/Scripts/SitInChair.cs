using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

public class SitinChair : MonoBehaviour
{
    [SerializeField] private GameObject _cutscene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _cutscene.SetActive(true);
        }
    }

}
