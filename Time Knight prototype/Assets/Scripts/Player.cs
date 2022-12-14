using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D _PRB;
    private Animator _PA;
    private Animator _playerAnim;
    public float playerspeed = 5;
    public bool toughingGround = false;
    public bool run = false;
    private Collider2D _myCollider;
    public bool isOnGround;
    public float Jumpforce = 10;
    public GameManager GameManager;

    // Start is called before the first frame update
    void Start()

    {
        _PRB = GetComponent<Rigidbody2D>();
        _PA = GetComponent<Animator>();
        _myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        Cum();
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Jump");
        transform.Translate(Vector2.right * Time.deltaTime * horizontalInput * playerspeed);
        transform.Translate(Vector2.up * playerspeed * Time.deltaTime * verticalInput);
    }

    void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        _PRB.velocity = new Vector2(horizontalInput * playerspeed, _PRB.velocity.y);
        if(Mathf.Abs(horizontalInput)>0.1f)
        {
            _PA.SetBool("IsRun", true);
        }
        else
        {
            _PA.SetBool("IsRun", false);
        }
    }

    void Cum()
    {
        if(_myCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {                
            _PA.SetBool("DaAir", false);
        }
        else
        {
            _PA.SetBool("DaAir", true);
        }

        if(Input.GetButtonDown("Jump") && isOnGround)
        {
            _PRB.velocity = new Vector2(_PRB.velocity.x, Jumpforce);
        }
        if(_myCollider.IsTouchingLayers(LayerMask.GetMask("Acid")))
        {
            GameManager.GameOver();
        }
        if(_myCollider.IsTouchingLayers(LayerMask.GetMask("Done")))
        {
            GameManager.GameCumlord();
        }

        bool Moving = Mathf.Abs(_PRB.velocity.x) > Mathf.Epsilon;
        if(Moving)
        {
            transform.localScale = new Vector2(Mathf.Sign(_PRB.velocity.x), 1f);
        }
    }
}