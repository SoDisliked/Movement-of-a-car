<h2>Moving Car with JavaScript and CSS</h2>


<style>
body{
  font-size:1.3em;
}
#wrapper{
  color:blue;
}
.wheel{
  display:inline-block;
  -webkit-animation: rotation 2s infinite linear;
}
@-webkit-keyframes rotation{
  from{
    -webkit-transform: rotate(0deg);
  }
  to{
    -webkit-transform: rotate(360deg);
  }
}
</style>

<div id="wrapper">
  &nbsp;____/*******************************\________<br>
  |________ <div class="wheel">@</div> _______________________ <div class="wheel">@</div> _______|
</div>


<script>
  var element = document.getElementById('wrapper');
  var current_margin = 1;

  setInterval(function(){
    if(window.innerWidth<=current_margin+100){
      current_margin = 1;
    }
    new_margin = parseInt(current_margin)+1;
    current_margin = new_margin;
    element.style.marginLeft = new_margin;
  },15);
</script>