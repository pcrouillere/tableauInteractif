#pragma strict
var initialColor : Color;
var materialChange : Material;
var initialMaterial : Material;
var changeObject : GameObject;
var originalMaterial : Material;


function Start()
{
}
 
function OnMouseOver()
{
   renderer.material = materialChange;
   changeObject.renderer.material = materialChange;
}
 
function OnMouseExit()
{
   renderer.material = initialMaterial;
   changeObject.renderer.material = originalMaterial;
}