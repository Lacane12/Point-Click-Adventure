
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    Animator anim;
    SpriteRenderer sprite;
    Collider2D _collider;
    AudioSource _source;

    public float VelocityTreshlod = 0.1f;
    public float Speed = 3;

    public bool CanMove = true;

    float Horizontal;
    float Vertical;

    Vector3 RawScale;
    Vector3 OriginScale;

    public static CharacterMovement Instance;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        LevelManager.Instance.Character = this.gameObject;

        _source = GetComponent<AudioSource>();
        _collider = GetComponent<Collider2D>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

        OriginScale = this.transform.localScale;



       
    }

    // Update is called once per frame
    void Update()
    {
        sprite.sortingOrder = -Mathf.RoundToInt((transform.position.y - 1.3f) * 10);

        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

    }

    public void ForbidMovement() { 
        CanMove = false;
    }

    public void AllowMovement() {
        CanMove = true;
    }

    public void ColliderOffOn(bool enable) {
        _collider.enabled = enable;
    }
   

    private void FixedUpdate()
    {
        if (!CanMove) {
            _rigidbody2D.velocity = Vector2.zero;
            anim.SetBool("isRunning", false);
            
            return;
        }

        _source.volume = Mathf.Clamp(_rigidbody2D.velocity.magnitude, 0f, 1f);

        Move();
    }

    private void Move()
    {
        float negative = this.transform.position.y * 0.033f;

        RawScale = new Vector3(Mathf.Clamp(OriginScale.x + negative, -0.4f, 0.4f), Mathf.Clamp(OriginScale.y - negative, -0.4f, 0.4f), Mathf.Clamp(OriginScale.z - negative, -0.4f, 0.4f));

        

        _rigidbody2D.velocity = new Vector2(Horizontal * Speed, Vertical * Speed);


        anim.SetBool("isRunning", _rigidbody2D.velocity != Vector2.zero);

        //_source.volume = 1f;

        RawScale = new Vector3(RawScale.x, RawScale.y, RawScale.z);


        if (_rigidbody2D.velocity.x > 0)
        {
            sprite.flipX = true;
        }

        if (_rigidbody2D.velocity.x < 0)
        {
            sprite.flipX = false;

        }

        this.transform.localScale = RawScale;
    }
}
