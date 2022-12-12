$(document).ready(function(){
    $("#bt1").click(function(){
        $("#gtw").attr("href", "https://github.com/");
    });
    $("#bt2").click(function(){
        $("#gtw").attr("href", "https://google.com/");
    });
    $("#bt3").click(function(){
        $("#gtw").attr("href", "https://stackoverflow.com/");
    });
    $("#bt4").click(function(){
        $("#gtw").attr("href", "https://www.w3schools.com/");
    });
    $("#bt5").click(function(){
        $("#gtw").attr("href", "https://www.bing.com/");
    });
    $("#bt6").click(function(){
        $("#gtw").removeAttr("href");
    });
});