var a = document.getElementById("audio");
var img = document.querySelector("img");
var playBtn = document.getElementById("play");
var pauseBtn = document.getElementById("pause");
var stopBtn = document.getElementById("stop");
var muteBtn = document.getElementById("mute");
var VolumeRange = document.getElementById("volume");
var speedRange = document.getElementById("speed");
var timeRange = document.getElementById("time");

playBtn.addEventListener("click", function () {
  a.play();
});
////////////////////////////////////////////////////////
pauseBtn.addEventListener("click", function () {
  a.pause();
});
///////////////////////////////////////////////////////
stopBtn.addEventListener("click", function () {
  a.load();
  a.pause();
});
//////////////////////////////////////////////////////
muteBtn.addEventListener("click", function () {
  a.muted = !a.muted;
  // if(a.muted==false){
  //     a.muted=true
  // }else{
  //     a.muted=false;
  // }
});
VolumeRange.addEventListener("input", function () {
  a.volume = VolumeRange.value;
});

speedRange.addEventListener("input", function () {
  a.playbackRate = speedRange.value;
});

window.addEventListener("load", function () {
  timeRange.max = a.duration;
  console.log(a.duration);
});
timeRange.addEventListener("input", function () {
  a.currentTime = timeRange.value;
});

var tracks = document.getElementsByClassName("track-list")[0];

tracks.addEventListener("click", (e) => {
  img.src = e.target.getAttribute("data-cover");
  a.src = e.target.getAttribute("data-src");
});

a.addEventListener("timeupdate", () => {
  timeRange.value = audio.currentTime;
});
