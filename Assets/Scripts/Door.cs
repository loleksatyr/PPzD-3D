using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

public class Door : MonoBehaviour {
    [SerializeField] Animator animator;
    [SerializeField] UnityEvent onDoorOpen = new UnityEvent();
    [SerializeField] UnityEvent onDoorClose = new UnityEvent();
    [SerializeField] AudioMixerSnapshot otuside;
    [SerializeField] AudioMixerSnapshot inside;
    [SerializeField] AudioSource door;
    [SerializeField] AudioClip closedoor;
    [SerializeField] AudioClip opendoor;
    public static bool ifin = false;
    
  

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            animator.SetBool("character_nearby", true);
            onDoorOpen.Invoke();
           door.PlayOneShot(opendoor,1f);
            ifin = !ifin;

        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            animator.SetBool("character_nearby", false);
            onDoorClose.Invoke();
            door.PlayOneShot(closedoor, 1f);
        }
    }
    private void Update()
    {
        if (ifin)
        {
            inside.TransitionTo(1f);
          

        }
        else {
            otuside.TransitionTo(1f);
           

        }
    }
}
