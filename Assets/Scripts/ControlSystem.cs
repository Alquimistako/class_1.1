using UnityEngine;

public class ControlSystem : MonoBehaviour
{
	[Header("移動速度")]
	[Range(0,10)]
	public float movespeed = 3.5f;
	[Header("剛體")]
	public Rigidbody2D rig;
	[Header("動畫控制器")]
	public Animator ani;
	[Header("跑步參數")]
	public string parRun = "走路開關";
	private void Awake()
	{
		print("bruh");
		print("wtf");
	}

	private void Start()
	{
		print("<color=#C22002>開始</color>");
	}
	private void Update()
	{
		//print("<color=#af288f>更新</color>");

		//呼叫移動方法
		Move();
	}
		private void Move()
		{
		 float h = Input.GetAxis("Horizontal");
		 float v = Input.GetAxis("Vertical");

		 rig.velocity = new Vector2(h, v) * movespeed;

		 ani.SetBool(parRun, h != 0 || v != 0);

		 if(Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.eulerAngles = new Vector3(0, 180, 0);
		}
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.eulerAngles = new Vector3(0, 0, 0);
		}
	}
	}

