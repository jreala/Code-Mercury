using UnityEngine;
using Assets.Scripts;

public class PlayableCharacter : MonoBehaviour
{
    public BasePlayer _player;
    public float speed;
    private Rigidbody _playerBody;

	// Use this for initialization
	void Start ()
    {
        _player = BasePlayer.GetInstance();
        _player.BaseClass = new Brawler();
        _player.SecondaryClass = new Manipulator();
        _player.TertiaryClass = new Conjurer();

        _playerBody = GetComponent<Rigidbody>();
	}
	
    void FixedUpdate()
    {
        var horizMovement = Input.GetAxis("Horizontal");
        var vertMovement = Input.GetAxis("Vertical");

        var movement = new Vector3(horizMovement, 0.0f, vertMovement);

        _playerBody.velocity = movement * speed;
    }

	// Update is called once per frame
	void Update ()
    {
        ActivateAbility();
    }

    private void ActivateAbility()
    {
        if (Input.GetButtonDown("AbilityOne") && !(Input.GetButton("L2") || Input.GetButton("R2")))
        {
            _player.BaseAbilityOne();
        }

        if (Input.GetButtonDown("AbilityTwo") && !(Input.GetButton("L2") || Input.GetButton("R2")))
        {
            _player.BaseAbilityTwo();
        }

        if (Input.GetButtonDown("AbilityThree") && !(Input.GetButton("L2") || Input.GetButton("R2")))
        {
            _player.BaseAbilityThree();
        }

        if (Input.GetButton("L2") && Input.GetButtonDown("AbilityOne") && !Input.GetButton("R2"))
        {
            _player.SecondaryAbilityOne();
        }

        if (Input.GetButton("L2") && Input.GetButtonDown("AbilityTwo") && !Input.GetButton("R2"))
        {
            _player.SecondaryAbilityTwo();
        }

        if (Input.GetButton("L2") && Input.GetButtonDown("AbilityThree") && !Input.GetButton("R2"))
        {
            _player.SecondaryAbilityThree();
        }

        if (Input.GetButton("R2") && Input.GetButtonDown("AbilityOne"))
        {
            _player.TertiaryAbilityOne();
        }

        if (Input.GetButton("R2") && Input.GetButtonDown("AbilityTwo"))
        {
            _player.TertiaryAbilityTwo();
        }

        if (Input.GetButton("R2") && Input.GetButtonDown("AbilityThree"))
        {
            _player.TertiaryAbilityThree();
        }
    }
}
