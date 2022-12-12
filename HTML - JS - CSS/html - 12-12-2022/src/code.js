$(document).ready(function(){
    /*Start of Color Set*/
    $("#g").click(function(){
        $("#name").css("color", "green");
    });
    $("#B").click(function(){
        $("#name").css("color", "blue");
    });
    $("#R").click(function(){
        $("#name").css("color", "red");
    });
    $("#Y").click(function(){
        $("#name").css("color", "yellow");
    });
    $("#V").click(function(){
        $("#name").css("color", "violet");
    });
    /*End of Color Set*/

    /*Start of Font-Style Set*/
    $("#RSP").click(function(){
        $("#name").css("font-family", "Rubik Spray Paint");
    });
    $("#O").click(function(){
        $("#name").css("font-family", "Oswald");
    });
    $("#U").click(function(){
        $("#name").css("font-family", "Unbounded");
    });
    $("#CM").click(function(){
        $("#name").css("font-family", "Chivo Mono");
    });
    $("#RV").click(function(){
        $("#name").css("font-family", "Rubik Vinyl");
    });
    /*End of Font-Style Set*/

    /*Start of Remove Values*/
    $("#rem").click(function(){
        $("#name").css("color", "");
        $("#name").css("font-family", "");
    });
    /*End of Remove Values*/
});