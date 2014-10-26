#pragma strict

var changeObject : GameObject;
var materialChange : Material;
var originalMaterial : Material;


function Start()
{
}
 
function OnMouseOver()
{
   changeObject.renderer.material = materialChange;
}
 
function OnMouseExit()
{
   changeObject.renderer.material = originalMaterial;
}