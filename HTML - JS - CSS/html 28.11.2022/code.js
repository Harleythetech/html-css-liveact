$(document).ready(function(){
    $("#n").click(function(){
        $("#a").hide();
        $("#b").hide();
    });
    $("#a").click(function(){
        $("#n").hide();
        $("#b").hide();
    });
    $("#b").click(function(){
        $("#n").hide();
        $("#a").hide();
    });
    $("#hi").click(function(){
        $("h3").hide();
    });
});