
var progress : float = 0;
var pos : Vector2 = new Vector2(20,40);
var size : Vector2 = new Vector2(60,20);
var progressBarEmpty : Texture2D;
var progressBarFull : Texture2D;
 
function OnGUI()
{
   // GUI.DrawTexture(Rect(pos.x, pos.y, size.x, size.y), progressBarEmpty);
    //GUI.DrawTexture(Rect(pos.x, pos.y, size.x * Mathf.Clamp01(progress), size.y), progressBarFull);
GUI.DrawTexture(Rect(pos.x, pos.y, size.x, size.y), progressBarEmpty);
GUI.BeginGroup(new Rect (pos.x, pos.y, size.x * Mathf.Clamp01(progress), size.y));
GUI.DrawTexture(new Rect(0, 0, size.x, size.y), progressBarFull);
GUI.EndGroup();
} 
 
function Update()
{
    progress = Time.time * 0.05;
}

   GUI.DrawTexture(Rect(pos.x, pos.y, size.x * Mathf.Clamp01(progress), size.y), progressBarFull, ScaleMode.ScaleAndCrop, false, size.x/size.y);
   
  /* var customStyle: GUIStyle;
   private var progress : int;
   var mySpeed: int;
   var pos : Vector2;
   var size : Vector2; 
 
   function OnGUI () {
        // Constrain all drawing to be within a pixel area .
        GUI.BeginGroup (new Rect (pos.x, pos.y, progress, size.y));
 
        // Define progress bar texture within customStyle under Normal > Background
        GUI.Box (Rect (0,0, size.x, size.y),"", customStyle);
 
        // Always match BeginGroup calls with an EndGroup call
        GUI.EndGroup ();
    } 
 
    function Update (){
        progress = size.x - Mathf.Floor(Time.time * mySpeed);
 
    }*/