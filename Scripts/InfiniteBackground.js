#pragma strict
var speed : float = 0.1;
var rend: Renderer;


function Start () {
	rend = GetComponent.<Renderer>();

}
function Update () {
	var offset:float = Time.time * speed;
	rend.material.SetTextureOffset("_MainTex", Vector2(offset,0));
	//var x :float = GetComponent.<Renderer>().material.GetTextureOffset("_MainTex").x;

	//transform.Translate(Vector3.forward*Time.deltaTime);


	//var direction:Vector2=GetComponent.<Renderer>().material.GetTextureOffset("_MainTex");
}