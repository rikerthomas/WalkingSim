using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    public float MovementSpeed = 1;
    public float Gravity = 9.8f;
    private float velocity = 0;

    public AudioSource audioSource;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // player movement - forward, backward, left, right
        float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed;
        characterController.Move((Vector3.right * horizontal + Vector3.forward * vertical) * Time.deltaTime);

        // Gravity
        if (characterController.isGrounded)
        {
            velocity = 0;
        }
        else
        {
            velocity -= Gravity * Time.deltaTime;
            characterController.Move(new Vector3(0, velocity, 0));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch(other.tag)
        {
            case ("audio1"):
                audioSource.Stop();
                audioSource.PlayOneShot(clip1);
                break;
            case ("audio2"):
                audioSource.Stop();
                audioSource.PlayOneShot(clip2);
                break;
            case ("audio3"):
                audioSource.Stop();
                audioSource.PlayOneShot(clip3);
                break;
            case ("audio4"):
                audioSource.Stop();
                audioSource.PlayOneShot(clip4);
                break;
            default:
                break;
              
        }

            
            






    }
}

