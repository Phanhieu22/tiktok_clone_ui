var sizeOneSlide =1350;
var nextSlide = 0;
function nextRight(){
nextSlide += sizeOneSlide;
if(nextSlide>4050){
        nextSlide = 0;
}
document.getElementById("next").style.marginLeft = "-"+nextSlide+"px";
}
function nextLeft(){
      
if(nextSlide==0){
nextSlide=5400;
document.getElementById("next").style.marginLeft = "-"+nextSlide+"px";
        }
nextSlide=nextSlide-1350;
 document.getElementById("next").style.marginLeft = "-"+nextSlide+"px";
}

setInterval(function(){
 nextRight();       
},2000);
function myTimer() {
        var d = new Date();
        var t = d.toLocaleTimeString();
        document.getElementById("time").innerHTML = t;
      }
setInterval(function(){
        myTimer()
},1000);
